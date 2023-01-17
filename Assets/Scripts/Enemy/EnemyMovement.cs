using System;
using UnityEngine;
using DG.Tweening;

public class EnemyMovement
{
    private Player _target;
    private Transform _transform;
    private float _movementDuration = 3f;

    private Tweener _tweener;
    
    public EnemyMovement(Player player, Transform transform)
    {
        _target = player;
        _transform = transform;
    }
    
    public void Move(Action callback)
    {
        _tweener = _transform.DOMove(_target.AttackZone.position, _movementDuration).OnComplete(() => callback?.Invoke());
    }

    public void Stop()
    {
        _tweener?.Kill();
    }
}
