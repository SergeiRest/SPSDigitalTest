using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform attackZone;
    [SerializeField] private PlayerCharacteristic _character;

    public PlayerCharacteristic Character => _character;

    public Transform AttackZone => attackZone;
}
