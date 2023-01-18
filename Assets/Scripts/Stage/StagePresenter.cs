using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagePresenter : MonoBehaviour
{
    [SerializeField] private StageView _stageView;
    [SerializeField] private StageModel _stageModel;

    public void Init()
    {
        _stageModel.OnStageInited += _stageView.Init;
        _stageModel.OnStageComplete += _stageView.EnableStageButton;
        _stageView.OnProgressFilled += _stageModel.CheckStage;
        _stageModel.Init();
    }
}
