using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class TMP_InputValidator : MonoBehaviour
{
    public TMP_InputField tmpInputField; 
    public Text outputText; // ���� ��� ������ ����������� ��������

    // ���������� ����� ��������
    private readonly string validCharacters = "G734#26H";

    public void ValidateInput()
    {
        string inputValue = tmpInputField.text; 
        string TrueSymbols = "";
        bool isValid = true;

        // ���������, ��� ����� ������ ������ (�.�. ���� ������� - ��� ��� �������)
        if (inputValue.Length % 2 != 0)
        {
            outputText.text = "Input length must be even!";
            return; // ��������� ��������, ���� ����� ��������
        }

        // ��������� ������ ���� ��������
        for (int i = 0; i < inputValue.Length; i += 2)
        {
            string element = inputValue.Substring(i, 2); // �������� ���� ��������

            // ���������, ��� ��� ������� � ���������� ������
            foreach (char c in element)
            {
                if (!validCharacters.Contains(c.ToString()))
                {
                    isValid = false; // ���� ����� ������������ ������
                    break; // ������������� ��������
                }
                if (isValid)
                {
                    TrueSymbols += c;
                }
            }

            if (!isValid) break; // �������������, ���� ���� �� ���� ���� �����������
        }

        if (TrueSymbols.Contains(validCharacters))
        {
            outputText.text = "Input is valid!"; // ��� ���� ���������
        }
    }

    private void Update()
    {
        ValidateInput();
    }
}
