using UnityEngine;
using UnityEngine.UI;

public class LinearDisplay : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;
    [SerializeField] private DamagCalculation _calculator;
    [SerializeField] private float _increment = 10f;

    private float _startValue;
    private float _endValue;

    private void Update()
    {
        _endValue = Mathf.Clamp(_calculator.ValueLife, _lineLife.minValue, _lineLife.maxValue);
        _startValue = _lineLife.value;

        _lineLife.value = Mathf.MoveTowards(_startValue, _endValue, _increment * Time.deltaTime);
    }
}
