using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotator : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _player;

    void Update()
    {
        transform.localEulerAngles = _player.transform.position - _enemy.transform.position;
    }
}
