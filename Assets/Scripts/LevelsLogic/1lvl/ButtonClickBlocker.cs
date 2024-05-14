using UnityEngine;
using UnityEngine.UI;

public class ButtonClickBlocker : MonoBehaviour
{
    // ������ �� ������, ������� ����� �������������
    public Button[] buttonsToBlock;

    private void Awake()
    {
        // ���������, ��� ������ ������
        if (buttonsToBlock == null || buttonsToBlock.Length == 0)
        {
            Debug.LogError("Buttons to block are not assigned!");
        }
    }

    private void OnEnable()
    {
        // ��������� ������ ��� ��������� �������
        BlockButtons();
    }

    private void OnDisable()
    {
        // ������������ ������ ��� ���������� �������
        UnblockButtons();
    }

    private void BlockButtons()
    {
        // ��������� ������� �� ��� ������
        foreach (var button in buttonsToBlock)
        {
            button.interactable = false;
        }
    }

    private void UnblockButtons()
    {
        // ������������ ������� �� ��� ������
        foreach (var button in buttonsToBlock)
        {
            button.interactable = true;
        }
    }
}
