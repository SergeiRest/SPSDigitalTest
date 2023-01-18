using System;
using UniRx;
using UnityEngine;
using VSCodeEditor;

public class Gun : MonoBehaviour
{
    [SerializeField] private GunMagazine _magazine;
    [SerializeField] private int _damage;
    [SerializeField] private Enemy _target; // Удалить потом
    [SerializeField] private Transform _bulletParent;
    [SerializeField] private int _interval;

    private IDisposable _shootingDisposable;
    
    public void Shoot()
    {
        TimeSpan interval = new TimeSpan(0, 0, 0, _interval);
        _shootingDisposable = Observable.Interval(interval).TakeUntilDisable(gameObject).Subscribe(_ =>
        {
            Shoot();
        });

        void Shoot()
        {
            Bullet bullet = _magazine.GetBullet();
            bullet.transform.SetParent(_bulletParent);
            bullet.transform.localPosition = Vector3.zero;
            bullet.gameObject.SetActive(true);
            bullet.Init(_damage, _target.transform);
            bullet.OnTargetReached += _magazine.TurnBack;
        }
    }

    public void StopShooting()
    {
        _shootingDisposable?.Dispose();
    }
}
