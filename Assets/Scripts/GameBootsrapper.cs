using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootsrapper : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private StagePresenter _stageView;
    [SerializeField] private Player _player;

    private void Start()
    {
        _player.Init();
        _stageView.Init();
    }
}
