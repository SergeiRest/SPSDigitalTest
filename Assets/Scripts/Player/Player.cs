using System;
using System.Collections;
using System.Collections.Generic;
using PlayerStates;
using UniRx;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform attackZone;
    [SerializeField] private PlayerCharacteristic _character;
    [SerializeField] private Gun _gun;

    private PlayerStateMachine _stateMachine;

    public PlayerCharacteristic Character => _character;
    public Gun Gun => _gun;

    public Transform AttackZone => attackZone;

    public void Init()
    {
        _stateMachine = new PlayerStateMachine(this);
    }
}
