using System.Collections;
using UnityEngine;

public class KeyboardInputController : MonoBehaviour
{
    private bool isFirstTime = true;

    private void Start()
    {
        StartCoroutine(WorkForSeconds(10));
    }

    private IEnumerator WorkForSeconds(float workDuration)
    {
        while (true)
        {
            float timePassed = 0f;
            while (timePassed < workDuration)
            {
                bool isSpacePressed = Input.GetKeyDown(KeyCode.Space);
                if(!isSpacePressed && isFirstTime)
                {
                    yield return null;
                    continue;
                }
                isFirstTime = false;

                if (isSpacePressed)
                {
                    timePassed = 0f;
                }
                timePassed += Time.deltaTime;
                Debug.Log($"Time passed: {timePassed}");

                yield return null;
            }
            isFirstTime = true;
        }        
    }
}