using TMPro;
using UnityEngine;

public class Viewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private Counter _counter;

    private void Update()
    {
        Show();
    }

    private void Show()
    {
        _timerText.text = _counter.Number.ToString();
    }
}