using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealthView : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Image _healthBar;
    [SerializeField] private DamageModel _damageModel;
    
    private void Start()
    {
        _enemy.Characteristic.OnDamageTaken += _damageModel.Show;
        _enemy.Characteristic.HealthLeft += UpdateHealthBar;
    }

    private void UpdateHealthBar(float health)
    {
        _healthBar.fillAmount = health;
    }
}
