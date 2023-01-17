using System.Collections;
using EnemyState;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _player; // Удалить потом
    private StateContoller _stateContoller = new StateContoller();

    public StateContoller StateContoller => _stateContoller;
    
    
    private void Start()
    {
        StartCoroutine(StartMovement());
    }

    private IEnumerator StartMovement()
    {
        yield return new WaitForSecondsRealtime(2f);
        _stateContoller.Init(_player, transform);
    }
}
