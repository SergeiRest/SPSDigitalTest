using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _damage;

    public void SetValue(int damage)
    {
        _damage.text = damage.ToString();
    }
}
