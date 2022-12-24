using UnityEngine;
using UnityEngine.UI;
using System;

public class Health : MonoBehaviour
{
   [SerializeField] private Slider _health;

    public static Action OnClic;

    private int _valueLife = 100;
    private int _maxHealth = 100;
    private int _minHealth = 0;

    public int ValueLife { get => _valueLife; }

    public void Damage(int incrementValue)
    {
        _valueLife -= incrementValue;
        _valueLife = Mathf.Clamp(_valueLife, _minHealth, _maxHealth);

        OnClic?.Invoke();
    }

    public void TakeDamage(int incrementValue)
    {
        _valueLife += incrementValue;
        _valueLife = Mathf.Clamp(_valueLife, _minHealth, _maxHealth);

        OnClic?.Invoke();
    }

    private void Start()
    {
        _health.maxValue = _maxHealth;
        _health.minValue = _minHealth;
    }
}
