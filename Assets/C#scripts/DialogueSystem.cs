using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueSystem : MonoBehaviour, IPointerDownHandler
{
    public Text buttontext;
    public Text dialogueText;
    public GameObject nextText;
    public CanvasGroup dialogueGroup;
    public Queue<string> sentences;
    public AudioSource keyboardSound;

    private string currentSentence;

    public float typingSpeed = 0.1f;

    private bool istyping;

    public static DialogueSystem instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void OnDialogue(string[] lines)
    {
        sentences.Clear();
        foreach (string line in lines)
        {
            sentences.Enqueue(line);
        }
        dialogueGroup.alpha = 1;
        dialogueGroup.blocksRaycasts = true;

        NextSentence();
    }

    public void NextSentence()
    {
        if (sentences.Count != 0)
        {
            currentSentence = sentences.Dequeue();//코루틴
            istyping = true;
            nextText.SetActive(false);
            StartCoroutine(Typing(currentSentence));
        }
        else
        {
            dialogueGroup.alpha = 0;
            dialogueGroup.blocksRaycasts = false;
        }
    }

    IEnumerator Typing(string line)
    {
        dialogueText.text = "";
        buttontext.text = "Tutorial...";
        foreach (char letter in line.ToCharArray())
        {
            keyboardSound.volume = 0.5f;
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            keyboardSound.volume = 0f;
            
        }
    }

    void Update()
    {
        //dialogue == currentSentence 대사 한줄 끝.
        if (dialogueText.text.Equals(currentSentence))
        {
            nextText.SetActive(true);
            istyping = false;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("nextsentence를 실행하지 않습니다.");
        if (!istyping)
        {
            NextSentence();
        }

    }
}
