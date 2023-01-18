using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMagazine : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    
    private Queue<Bullet> _bullets = new Queue<Bullet>();

    public Bullet GetBullet()
    {
        Bullet bullet;
        if (_bullets.Count > 0)
        {
            bullet = _bullets.Dequeue();
            return bullet;
        }
        else
        {
            bullet = Instantiate(_bulletPrefab);
            return bullet;
        }
    }

    public void TurnBack(Bullet bullet)
    {
        if(_bullets.Contains(bullet))
            return;
        
        _bullets.Enqueue(bullet);
    }
}
