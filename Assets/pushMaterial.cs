using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pushMaterial : MonoBehaviour
{
    public Slider sliderValue;
    public void OnPushClick()
    {
        Debug.Log("ㅗ");
        if (Input.GetKey(KeyCode.Mouse0) == true)
        {
            Debug.Log("ㅗㅗ");
            sliderValue.value += 0.5f * Time.deltaTime;
            if (sliderValue.value > 1f)
                sliderValue.value = 1f;
        }
        
    }
}