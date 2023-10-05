using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _replacedText;
    [SerializeField] private string _additionText;
    [SerializeField] private string _hackedText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_replacedText, _duration));
        sequence.Append(_text.DOText(_additionText, _duration).SetRelative());
        sequence.Append(_text.DOText(_hackedText, _duration, true, ScrambleMode.Lowercase));
        sequence.SetLoops(-1);
    }
}