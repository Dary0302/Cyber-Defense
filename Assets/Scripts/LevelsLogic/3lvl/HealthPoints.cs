using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    private int countHealthPoints = 1;

    void Start()
    {
        //todo: � ������ ��������� �������� � ����
    }

    void Update()
    {
        //todo: � ������� ��������� ���������� ��������
    }

    public void WrongAnswer()
    {
        countHealthPoints--;
        Debug.Log("Aghhh");
    }
}
