using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UniRx;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    private int _damage;
    private Enemy _target;
    private IDisposable _disposable;
    
    public Action<Bullet> OnTargetReached;

    public void Init(int damage, Enemy target)
    {
        _damage = damage;
        _target = target;
        MoveTo();
    }

    private void MoveTo()
    {
        _disposable = Observable.EveryUpdate().TakeUntilDisable(gameObject).Subscribe(_ =>
        {
            if (_target == null)
            {
                Clear();
                return;
            }
            
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
            
            if ((transform.position - _target.transform.position).sqrMagnitude < 0.1f)
            {
                _target.Characteristic.TakeDamage(_damage);
                Clear();
            }
        });
    }

    private void Clear()
    {
        gameObject.SetActive(false);
        _disposable?.Dispose();
        OnTargetReached?.Invoke(this);
    }
}
