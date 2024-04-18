using DG.Tweening;
using UnityEngine;

public class UIPulsate : MonoBehaviour
{
    [SerializeField] private float _pulseDuration = 1f;
    [SerializeField] private float _scaleFactor = 1.2f;

    private Tween _pulsateTween;

    public void StartPulsating()
    {
        transform.localScale = Vector3.one;
        _pulsateTween = transform.DOScale(_scaleFactor, _pulseDuration).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopPulsating()
    {
        if (_pulsateTween != null && _pulsateTween.IsActive())
        {
            _pulsateTween.Kill();
        }
    }
}