using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform attackZone;

    public Transform AttackZone => attackZone;
}
