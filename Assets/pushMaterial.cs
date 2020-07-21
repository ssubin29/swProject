using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pushMaterial : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Slider sliderValue;
    bool isBtnDown;
    float currentValue;
    bool doingPush;

    private void Start()
    {
        doingPush = false;
    }

    private void Update()
    {
        if (isBtnDown)
        {
            sliderValue.value += 0.5f * Time.deltaTime;
            if (sliderValue.value > 1f)
                sliderValue.value = 1f;
        }

        else
        {
            if (doingPush == false)
            {
                saveValue();
            }
            
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;

    }

    public void saveValue()
    {
        doingPush = true;
        Debug.Log(sliderValue.value);
    }
}