using TMPro;
using UnityEngine;

public class Viewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private Timer _timer;

    private void Update()
    {
        Show();
    }

    private void Show()
    {
        _timerText.text = _timer.Number.ToString();
    }
}