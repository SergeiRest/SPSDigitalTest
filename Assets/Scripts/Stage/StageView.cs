using System;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class StageView : MonoBehaviour
{
    [SerializeField] private Button _start;
    [SerializeField] private Image _progress;

    [SerializeField] private float _step; 
    private float _duration;

    
    public void Init(float duration)
    {
        _duration = duration;
        _start.onClick.AddListener(() => StageModel.OnStageStarted?.Invoke());
        StageModel.OnStageStarted += FillProgress;
    }

    private void FillProgress()
    {
        float value = _progress.fillAmount + _step;

        _progress.DOFillAmount(value, _duration);
    }
}
