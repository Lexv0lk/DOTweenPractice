using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _targetedScale;
    [SerializeField] private float _scaleTime;

    private void Start()
    {
        transform.DOScale(_targetedScale, _scaleTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
