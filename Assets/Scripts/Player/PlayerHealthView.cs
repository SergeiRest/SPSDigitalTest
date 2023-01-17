using System;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthView : MonoBehaviour
{
    [SerializeField] private Image _healthBar;

    public void SetHealthValue(int maxHealth, int currentHealth)
    {
        float value = (float)currentHealth / (float)maxHealth;
        _healthBar.fillAmount = value;
    }
}
