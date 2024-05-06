using TMPro;
using UnityEngine;

public class SecondTimer : MonoBehaviour
{
    public float timerDuration = 6f; // ������������ ������� � ��������
    private float timer; // ������� ����� �� �������
    private bool isTimerRunning = false; // ���� ������� �������

    [SerializeField] private GameObject grid;
    [SerializeField] private TMP_Text timerText; // ������ �� ��������� ���� ��� ����������� �������

    private void Update()
    {
        // ���������, ���� �� ������
        if (isTimerRunning)
        {
            // ��������� ������
            timer -= Time.deltaTime;

            // ��������� �������� ������� � ������� ��� � ��������� ����
            timerText.text = Mathf.Round(timer).ToString();

            // ���� ����� ������� �������
            if (timer <= 0f)
            {
                // ��������� ������
                grid.SetActive(false);

                // ������������� ������
                isTimerRunning = false;

                timerText.text = string.Empty;
            }
        }
    }

    // ����� ��� ������� �������
    public void StartTimer()
    {
        // ������������� ��������� ����� ������� � ��������� ���
        timer = timerDuration;
        isTimerRunning = true;
    }
}
