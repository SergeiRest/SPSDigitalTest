using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotator : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _damping;

    void Update()
    {
        transform.LookAt(_enemy.transform);
    }
}
