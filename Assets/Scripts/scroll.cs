using UnityEngine;

public class HorizontalDrag : MonoBehaviour
{
    private bool isDragging = false;
    private float offsetX;

    void OnMouseDown()
    {
        // ��� ����� �� ������ ��������� ��������� ��������
        offsetX = transform.position.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (!isDragging)
            return;

        // �������� ������� ������� ���� � ������� �����������
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // ������������� ������� �������, �������� ��������� �������� � ����������� ����������� �� �����������
        transform.position = new Vector3(mousePos.x + offsetX, transform.position.y, transform.position.z);
    }

    void OnMouseUp()
    {
        // ��� ���������� ���� ��������� ��������������
        isDragging = false;
    }
}
