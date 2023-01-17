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
    private Transform _target;
    private IDisposable _disposable;
    
    public Action<Bullet> OnTargetReached;

    public void Init(int damage, Transform target)
    {
        _damage = damage;
        _target = target;
        MoveTo();
    }

    private void MoveTo()
    {
        _disposable = Observable.EveryUpdate().TakeUntilDisable(gameObject).Subscribe(_ =>
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
            if ((transform.position - _target.position).sqrMagnitude < 0.1f)
            {
                gameObject.SetActive(false);
                _disposable?.Dispose();
                OnTargetReached?.Invoke(this);
            }
        });
    }
}
