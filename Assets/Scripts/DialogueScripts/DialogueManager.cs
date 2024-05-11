using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueWindow;
    public TMP_Text dialogueText;
    public TMP_Text nameSpeaker;
    public float delayBetweenCharacters = 0.05f;

    private int currentDialogueNumber;
    private Queue<Dialogue.Sentence> sentences;

    public void Awake()
    {
        sentences = new();
    }

    public void StartDialogue(Dialogue dialogue, int dialogueNumber)
    {
        if (dialogueNumber != PlayerStats.LevelsCompletedNumber)
        {
            dialogueWindow.gameObject.SetActive(false);
            return;
        }
            
        sentences.Clear();
        currentDialogueNumber = dialogueNumber;
        
        foreach (var sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        var sentence = sentences.Dequeue();
        nameSpeaker.text = "";
        if (sentence.Name == Names.Robot)
            nameSpeaker.text = "Robot";
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence.Text));
    }

    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (var letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delayBetweenCharacters);
        }
    }

    public void EndDialogue()
    {
        PlayerPrefs.SetInt("lastDialogueNumber", currentDialogueNumber + 1);
        PlayerPrefs.Save();
        dialogueWindow.gameObject.SetActive(false);
    }
}
