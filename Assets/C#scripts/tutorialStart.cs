using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tutorialStart : MonoBehaviour, IPointerClickHandler
{
    public string[] sentences;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("DialogueSystem 스크립트를 불러옵니다.");
        if (DialogueSystem.instance.dialogueGroup.alpha == 0)
        {
            DialogueSystem.instance.OnDialogue(sentences);
        } 
    }

}
