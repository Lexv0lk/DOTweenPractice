using UnityEngine;
using DG.Tweening;

public class SimpleRotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), _speed, RotateMode.LocalAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
    }
}
