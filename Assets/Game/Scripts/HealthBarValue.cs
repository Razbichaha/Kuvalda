using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarValue : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        InputText();
    }

    public void InputText()
    {
        _text.text = ((int)(_lineLife.value)).ToString();
    }
}
