using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private const string Fire1 = "Fire1";

    private float _delay = 0.5f;
    private bool _isActive;
    private Coroutine _coroutine;

    public int Number { get; private set; }

    private void Start()
    {
        Restart();
    }

    private void Update()
    {
        if (Input.GetButtonDown(Fire1))
        {
            if (_isActive)
            {
                _isActive = false;
                Stop();
            }
            else
            {
                _isActive = true;
                Restart();
            }
        }
    }

    private void Restart()
    {
        _coroutine = StartCoroutine(IncreaseNumber());
    }

    private void Stop()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator IncreaseNumber()
    {
        var wait = new WaitForSeconds(_delay);

        while (_isActive)
        {
            Number++;
            yield return wait;
        }
    }
}