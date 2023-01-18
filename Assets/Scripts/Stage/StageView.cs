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

    public Action OnProgressFilled;

    
    public void Init(float duration)
    {
        _duration = duration;
        _start.onClick.AddListener(() => StageModel.OnStageStarted?.Invoke());
        StageModel.OnStageStarted += FillProgress;
    }

    private void FillProgress()
    {
        if(_start.gameObject.activeSelf)
            _start.gameObject.SetActive(false);
        
        float value = _progress.fillAmount + _step;

        _progress.DOFillAmount(value, _duration).OnComplete(() => OnProgressFilled?.Invoke());
    }

    public void EnableStageButton()
    {
        _start.gameObject.SetActive(true);
    }
}
