using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _changingDuration = 3f;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_renderer.material.DOColor(Color.blue, _changingDuration));
        sequence.Append(_renderer.material.DOColor(Color.yellow, _changingDuration));
        sequence.Append(_renderer.material.DOColor(Color.green, _changingDuration));
        sequence.Append(_renderer.material.DOColor(Color.red, _changingDuration));
        sequence.SetLoops(-1);
    }
}
