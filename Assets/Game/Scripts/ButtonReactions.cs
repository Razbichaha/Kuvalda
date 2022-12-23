using UnityEngine;
using UnityEngine.Events;

public class ButtonReactions : MonoBehaviour
{
    [SerializeField] private UnityEvent _batonClic;

    private int _valueLife = 100;
    private int _incrementValue = 10;
    private int _maxProcent = 100;
    private int _minProcent = 0;

    public int ValueLife { get => _valueLife; }

    public void Damage()
    {
        _valueLife -= _incrementValue;
        _valueLife = Mathf.Clamp(_valueLife, _minProcent, _maxProcent);

        _batonClic.Invoke();
    }

    public void TakeDamage()
    {
        _valueLife += _incrementValue;
        _valueLife = Mathf.Clamp(_valueLife, _minProcent, _maxProcent);

        _batonClic.Invoke();
    }
}