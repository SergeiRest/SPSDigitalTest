using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GunMagazine _magazine;
    [SerializeField] private int _damage;
    [SerializeField] private Enemy _target; // Удалить потом
    [SerializeField] private Transform _bulletParent;
    
    public void Shoot()
    {
        Bullet bullet = _magazine.GetBullet();
        bullet.transform.SetParent(_bulletParent);
        bullet.transform.localPosition = Vector3.zero;
        bullet.gameObject.SetActive(true);
        bullet.Init(_damage, _target.transform);
        bullet.OnTargetReached += _magazine.TurnBack;
    }
}
