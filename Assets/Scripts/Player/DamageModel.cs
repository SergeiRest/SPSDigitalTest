using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageModel : MonoBehaviour
{
    [SerializeField] private DamageText _prefab;
    [SerializeField] private Transform _parent;

    public void Show(int damage)
    {
        DamageText text = Instantiate(_prefab, _parent);
        text.transform.localPosition = Vector3.zero;
        text.SetValue(damage);
    }
}
