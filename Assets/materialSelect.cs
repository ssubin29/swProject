using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum MaterialType
{
    orangeJuice,
    vodka,
    rime

}

public class materialSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Outline buttonOutline;
    public Text buttonText;
    public MaterialType currentMaterial;

    public void onMaterialClick()
    {
        Debug.Log("오렌지 주스를 클릭하셨습니까?");
        //tiltMaterial();

    }

    public void tiltMaterial()
    {
        StartCoroutine(startTilt());
    }

    IEnumerator startTilt()
    {
        Debug.Log("Hello");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonOutline=GetComponent<Outline>();
        buttonOutline.enabled = true;
        buttonText.text = "orange juice";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonOutline = GetComponent<Outline>();
        buttonOutline.enabled = false;
        buttonText.text = "";
    }
}
