using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowAmountOfLife : MonoBehaviour
{
    [SerializeField] private Slider _lineLife;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        InputText();
    }

    public void InputText()
    {
        float procent = 100;

        _text.text = ((int)(_lineLife.value * procent)).ToString();
    }
}
