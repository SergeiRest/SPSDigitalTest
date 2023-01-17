using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteristicPresenter : MonoBehaviour
{
    [SerializeField] private PlayerCharacteristic _playerCharacteristic;
    [SerializeField] private PlayerView _playerView;
    private void Start()
    {
        _playerCharacteristic.OnHealthLeft += _playerView.SetHealthValue;
    }
}
