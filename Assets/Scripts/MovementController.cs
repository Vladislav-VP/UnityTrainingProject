using System.Collections;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Vector3 startPosition = Vector3.zero;
    private Vector3 nextPosition = Vector3.zero;

    private void Start()
    {
        StartCoroutine(DrawRay());
    }
    private IEnumerator DrawRay()
    {
        float duration = 5f;
        while (nextPosition.x < 1f && nextPosition.z < 1f)
        {
            nextPosition.x += Time.deltaTime*0.1f;
            nextPosition.z += Time.deltaTime*0.1f;
            Debug.DrawRay(startPosition, nextPosition, Color.white, duration);
            yield return null;
        }
    }
}
