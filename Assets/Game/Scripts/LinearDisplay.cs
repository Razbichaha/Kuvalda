using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LinearDisplay : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;
    [SerializeField] private ButtonReactions _calculator;

    private float _endValue;

    public void Counting()
    {
        _endValue = Mathf.Clamp(_calculator.ValueLife, _lineLife.minValue, _lineLife.maxValue);

        _lineLife.DOValue(_endValue, 1);
    }
}
