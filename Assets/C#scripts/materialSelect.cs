using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum MaterialType
{
    orangeJuice,
    rimeJuice,
    cranberryJuice,
    lemonJuice,
    pineappleJuice,
    tomatoJuice,
    kahlua,
    jin,
    rum,
    tequila,
    grenadine,
    whiskey,
    tripleSec,
    galliano,
    tonic,
    vodka,
    cola
}

public class materialSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Outline buttonOutline;
    public Text buttonText;
    public MaterialType currentMaterial;

    public void onMaterialClick()
    {
        //Debug.Log("오렌지 주스를 클릭하셨습니까?");

        //tiltMaterial();

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonOutline=GetComponent<Outline>();
        buttonOutline.enabled = true;
        buttonText.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonOutline = GetComponent<Outline>();
        buttonOutline.enabled = false;
        buttonText.enabled = false;
    }
}
