using System.Collections;
using EnemyState;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _player; // Удалить потом
    [SerializeField] private EnemyFight _fight;
    
    private StateContoller _stateContoller = new StateContoller();

    public EnemyFight Fight => _fight;

    private void Start()
    {
        StartCoroutine(StartMovement());
    }

    private IEnumerator StartMovement()
    {
        yield return new WaitForSecondsRealtime(2f);
        _stateContoller.Init(_player, this);
    }
}
