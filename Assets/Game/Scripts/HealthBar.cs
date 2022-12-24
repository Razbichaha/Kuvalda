using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;
    [SerializeField] private Health _calculator;

    private float _endValue;

    private void OnEnable()
    {
        Health.OnClic += Counting;
    }

    private void OnDisable()
    {
        Health.OnClic -= Counting;
    }

    private  void Counting()
    {
        _endValue = Mathf.Clamp(_calculator.ValueLife, _lineLife.minValue, _lineLife.maxValue);

        _lineLife.DOValue(_endValue, 1);
    }
}
