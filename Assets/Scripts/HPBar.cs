using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider hpSlider;

    public void SetValue(float hpValue){
        hpSlider.value = hpValue;
    }

    public void InitBar(float maxValue){
        hpSlider.maxValue = maxValue;
        hpSlider.value = maxValue;
    }

}
