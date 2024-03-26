using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = currentValue/maxValue;
        if(currentValue <= 0)
        {  
            currentValue = maxValue;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
