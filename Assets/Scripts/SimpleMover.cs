using UnityEngine;
using DG.Tweening;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private void Start()
    {
        transform.DOMove(transform.forward * _speed, 1).SetRelative().SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}