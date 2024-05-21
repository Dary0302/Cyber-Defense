using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public Dialogue[] dialogue;
    [SerializeField] private DialogueManager dialogueManager;
    private Dialogue currentDialogue = null;

    public void Start()
    {
        var lastDialogueNumber = 0;
        if (PlayerPrefs.HasKey("lastDialogueNumber"))
        {
            lastDialogueNumber = PlayerPrefs.GetInt("lastDialogueNumber");
        }

        if (lastDialogueNumber < dialogue.Length && lastDialogueNumber == PlayerStats.LevelsCompletedNumber) //todo доделать проверку на кол-во пройденных уровней
        {
            dialogueManager.gameObject.SetActive(true);
            dialogueManager.StartDialogue(dialogue[lastDialogueNumber], lastDialogueNumber);
        }
    }
}