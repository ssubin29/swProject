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
<<<<<<< HEAD:Assets/C#scripts/pushMaterial.cs

        else
        {
            if (doingPush == false&&sliderValue.value!=0)
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
=======
        
>>>>>>> 0fdfed069cdef576181d3ca15b84e0fdd1d39639:Assets/pushMaterial.cs
    }
}