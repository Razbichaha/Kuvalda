using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    private GameObject _health;

    private int _healting = 10;
    private const string NameGameObject = "Slider";

    public void OnClick()
    {
        _health.GetComponent<Health>().TakeDamage(_healting);
    }

    private void Start()
    {
        _health = GameObject.Find(NameGameObject);
    }
}
