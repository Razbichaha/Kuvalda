using UnityEngine;
using UnityEngine.UI;

public class StandardOfLiving : MonoBehaviour
{
    [SerializeField] private DisplyLife _displyLife;

    private int _valueLife = 100;
    private int _incrementValue = 10;
    private int _maxProcent = 100;
    private int _minProcent = 0;

    private void Start()
    {
        ShowValueLife();
    }

    public void Damage()
    {
        _valueLife -= _incrementValue;

        if (_valueLife < _minProcent)
        {
            _valueLife = _minProcent;
        }
        ShowValueLife();
    }

    public void TakeDamage()
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

        _displyLife.DisplyingValue((float)_valueLife / procent);
    }
}
