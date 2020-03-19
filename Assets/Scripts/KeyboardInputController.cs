using System.Collections;
using UnityEngine;

public class KeyboardInputController : MonoBehaviour
{
    private float lastTimePressed = -float.MaxValue;
    private float duration = 10f;

    private void Start()
    {
        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                lastTimePressed = Time.time;
            }

            if (Time.time < lastTimePressed + duration)
            {
                Debug.Log(duration - (Time.time - lastTimePressed));
            }

            yield return null;
        }
    }
}