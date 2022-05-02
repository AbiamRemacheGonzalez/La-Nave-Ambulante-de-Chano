using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarController : MonoBehaviour
{
    private Slider sliderLife;
    public Image fillImage;

    private float maxValue;
    private Gradient gradient;

    void Awake()
    {
        sliderLife = GetComponent<Slider>();

        gradient = new Gradient();

        // Populate the color keys at the relative time 0 and 1 (0 and 100%)
        GradientColorKey[] colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.green;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.red;
        colorKey[1].time = 1.0f;

        // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
        GradientAlphaKey[] alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 1.0f;

        gradient.SetKeys(colorKey, alphaKey);
    }

    public void SetValuesTo(int max)
    {
        maxValue = max;
        sliderLife.maxValue = max;
        sliderLife.value = max;
    }

    public void SetLife(int value)
    {
        sliderLife.value = value;
        fillImage.color = gradient.Evaluate(((float)value)/maxValue);
    }
}
