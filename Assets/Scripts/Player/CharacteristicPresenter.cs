using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteristicPresenter : MonoBehaviour
{
    [SerializeField] private PlayerCharacteristic _playerCharacteristic;
    [SerializeField] private PlayerHealthView _playerView;
    [SerializeField] private DamageModel _damageModel;
    
    private void Start()
    {
        _playerCharacteristic.OnHealthLeft += _playerView.SetHealthValue;
        _playerCharacteristic.OnDamageTaken += _damageModel.Show;
    }
}
