using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class DamageMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _moveDuration;
    [SerializeField] private float _fadeDuration;
    [SerializeField] private TextMeshProUGUI _text;
    
    public void Start()
    {
        transform.DOLocalMove(_offset, _moveDuration).OnComplete(Fade);
    }

    private void Fade()
    {
        _text.DOFade(0, _fadeDuration).OnComplete(() => Destroy(gameObject));
    }
}
