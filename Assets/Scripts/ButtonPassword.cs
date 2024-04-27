using UnityEngine;
using UnityEngine.UI;
using TMPro; // ��� TextMesh Pro

public class ButtonToTMPInputField : MonoBehaviour
{
    public TMP_InputField targetInputField; // ���� ����� TextMesh Pro

    // ����� ��� ����������� ������ � ���� �����
    public void CopyTextToInputField(string text)
    {
        if (targetInputField != null)
        {
            targetInputField.text += text; // ������������� ����� � ���� �����
        }
    }
}
