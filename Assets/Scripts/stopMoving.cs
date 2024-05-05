using UnityEngine;

public class DisableScrollOnCollision : MonoBehaviour
{
    private HorizontalDrag scrollScript;

    void Start()
    {
        // �������� ��������� Scroll �� ���� �������
        scrollScript = GetComponent<HorizontalDrag>();

        // ���������, ���� �� ��������� Scroll
        if (scrollScript == null)
        {
            Debug.LogError("Scroll �� ������ �� ���� �������!");
        }
    }

    // ����������, ����� ���������� ������������ � ������ �����������
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ���������, �������� �� ������, � ������� ���������� ������ ������, �������� �������
        if (collision.gameObject.CompareTag("Area"))
        {
            // ��������� ������ Scroll
            if (scrollScript != null)
            {
                scrollScript.enabled = false;
            }
        }
    }

    // ����������, ����� ������ ��������� ������������ � ������ �����������
    private void OnCollisionExit2D(Collision2D collision)
    {
        // ���������, �������� �� ������, � ������� �������� ������������ ������ ������, �������� �������
        if (collision.gameObject.CompareTag("Area"))
        {
            // �������� ������ Scroll
            if (scrollScript != null)
            {
                scrollScript.enabled = true;
            }
        }
    }
}
