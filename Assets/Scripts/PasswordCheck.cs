using UnityEngine;
using TMPro;

public class PasswordCheck : MonoBehaviour
{
    [SerializeField] private GameObject result;
    [SerializeField] private TMP_Text resultText;
    [SerializeField] private TMP_InputField tmpInputField; 
    [SerializeField] private Timer timer;
    [SerializeField] private string validCharacters = "G734#26H";

    private void ValidateInput()
    {
        var inputValue = tmpInputField.text; 
        var trueSymbols = "";
        var isValid = true;

        // ���������, ��� ����� ������ ������ (�.�. ���� ������� - ��� ��� �������)
        if (inputValue.Length != validCharacters.Length || inputValue.Length % 2 != 0)
        {
            return; // ��������� ��������, ���� ����� ��������
        }

        // ��������� ������ ���� ��������
        for (var i = 0; i < inputValue.Length; i += 2)
        {
            var element = inputValue.Substring(i, 2); // �������� ���� ��������

            // ���������, ��� ��� ������� � ���������� ������
            foreach (var c in element)
            {
                if (!validCharacters.Contains(c.ToString()))
                {
                    isValid = false; // ���� ����� ������������ ������
                    break; // ������������� ��������
                }

                trueSymbols += c;
            }

            if (!isValid) break; // �������������, ���� ���� �� ���� ���� �����������
        }

        if (trueSymbols == validCharacters)
        {
            timer.timerStop = true;
            resultText.text = "������� �������!";
            result.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        ValidateInput();
    }
}
