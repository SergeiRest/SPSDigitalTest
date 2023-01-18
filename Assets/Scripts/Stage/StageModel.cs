using System;
using EnemyState;
using UnityEngine;

public class StageModel : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _maxSteps;
    
    public Action<float> OnStageInited;
    public static Action OnStageStarted;
    public static Action OnStepComplete;
    public Action OnStageComplete;

    private int _stageStep = 0;

    
    public void Init()
    {
        OnStageInited?.Invoke(_duration);
        OnStageStarted += IncreaseStageStep;
    }
    
    private void OnDisable()
    {
        OnStageStarted = null;
    }

    private void IncreaseStageStep()
    {
        _stageStep++;
    }

    public void CheckStage()
    {
        if (_stageStep < _maxSteps)
        {
            OnStepComplete?.Invoke();
            //OnStageStarted?.Invoke();
        }
        else
        {
            OnStageComplete?.Invoke();
            Debug.Log("Complete");
        }
    }
}
