using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    private Slider slider;
    private void Awake()
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.value);
    }
    void Update()
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.value);
    }

    public void SetNumberText(float value)
    {
        numberText.text = value.ToString("F2");
    }
}
