using UnityEngine;
using TMPro; // ��� TextMesh Pro

public class ButtonPassword : MonoBehaviour
{
    public TMP_InputField targetInputField; // ���� ����� TextMesh Pro
    [SerializeField] private TMP_Text enterPassword;

    // ����� ��� ����������� ������ � ���� �����
    public void CopyTextToInputField(string text)
    {
        if (targetInputField != null)
        {
            enterPassword.text = "";
            targetInputField.text += text; // ������������� ����� � ���� �����
        }
    }
}
