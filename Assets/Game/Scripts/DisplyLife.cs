using UnityEngine;
using UnityEngine.UI;

public class DisplyLife : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;

    [SerializeField] private float _increment = 1f;

    private float _startValue ;
    private float _endValue ;

    public void DisplyingValue(float value)
    {
        _endValue = CheckValue(value);
    }

    private void Update()
    {
        _startValue = _lineLife.value;

        _lineLife.value = Mathf.MoveTowards(_startValue, _endValue, _increment * Time.deltaTime);
    }

    private float CheckValue(float value)
    {
        float verifiedValue = 0;

        if (value >= 0 | value <= 1)
        {
            verifiedValue = value;
        }

        if (value < 0)
        {
            verifiedValue = 0;
        }

        return verifiedValue;
    }
}
