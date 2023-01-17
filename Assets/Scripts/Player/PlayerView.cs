using System;
using UnityEngine.UI;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Image _healthBar;

    public void SetHealthValue(int maxHealth, int currentHealth)
    {
        float value = Convert.ToSingle(maxHealth / currentHealth);
        Debug.Log(value);
    }
}
