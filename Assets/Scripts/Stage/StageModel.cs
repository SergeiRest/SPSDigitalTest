using System;
using UnityEngine;

public class StageModel : MonoBehaviour
{
    [SerializeField] private float _duration;

    public Action<float> OnStageInited;
    public static Action OnStageStarted;

    
    public void Init()
    {
        OnStageInited?.Invoke(_duration);
    }
    
    private void OnDisable()
    {
        OnStageStarted = null;
    }
}
