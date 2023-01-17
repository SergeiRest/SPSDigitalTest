using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform attackZone;
    [SerializeField] private PlayerCharacteristic _character;
    [SerializeField] private Gun _gun;

    public PlayerCharacteristic Character => _character;

    public Transform AttackZone => attackZone;

    private void Start()
    {
        TimeSpan interval = new TimeSpan(0, 0, 1);
        Observable.Interval(interval).TakeUntilDisable(gameObject).Subscribe(_ =>
        {
            _gun.Shoot();
        });
    }
}
