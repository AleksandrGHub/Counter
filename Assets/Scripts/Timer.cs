using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _delay = 0.5f;
    private bool _isActive;

    public int Number { get; private set; }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (_isActive)
            {
                _isActive = false;
                StopCoroutine(IncreaseNumber());
            }
            else
            {
                _isActive = true;
                StartCoroutine(IncreaseNumber());
            }
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