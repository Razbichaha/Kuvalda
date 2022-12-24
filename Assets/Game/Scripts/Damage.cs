using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private GameObject _health;

    private int _damage = 10;
    private const string NameGameObject = "Slider";

    public void OnClick()
    {
        _health.GetComponent<Health>().Damage(_damage);
    }

    private void Start()
    {
        _health = GameObject.Find(NameGameObject);
    }
}
