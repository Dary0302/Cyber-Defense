using LevelsLogic;
using TMPro;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    [SerializeField] private AbstractTimer timer;
    [SerializeField] private GameObject result;
    [SerializeField] private TMP_Text resultText;

    public void LoseGame()
    {
        timer.Pause();
        resultText.text = "Уровень провален!";
        result.gameObject.SetActive(true);
    }
}
