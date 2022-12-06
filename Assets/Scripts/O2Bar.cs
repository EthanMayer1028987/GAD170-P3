using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Bar : MonoBehaviour
{
    public Slider o2Slider;

    public void SetValue(float o2Value)
    {
        o2Slider.value = o2Value;
    }

    public void InitBar(float maxValue)
    {
        o2Slider.maxValue = maxValue;
        o2Slider.value = maxValue;
    }

}
