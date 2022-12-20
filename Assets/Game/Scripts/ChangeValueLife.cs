using UnityEngine;
using UnityEngine.UI;

public class ChangeValueLife : MonoBehaviour
{
    private int _valueLife = 100;
    private int _incrementValue = 10;
    private int _maxProcent = 100;
    private int _minProcent = 0;

    [SerializeField] private Slider _life;

    private void Start()
    {
        ShowValueLife();
    }

    public void TakeLife()
    {
        _valueLife -=  _incrementValue;

        if (_valueLife<_minProcent)
        {
            _valueLife = _minProcent;
        }
        ShowValueLife();
    }

    public void AddLife()
    {
        _valueLife += _incrementValue;
        if (_valueLife > _maxProcent)
        {
            _valueLife = _maxProcent;
        }
        ShowValueLife();
    }

    private void ShowValueLife()
    {
        float procent = 100f;

        _life.value = (int)_valueLife/procent;
    }
}
