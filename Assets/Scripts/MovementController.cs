using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;

    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime, Space.Self);
        Debug.DrawRay(startPosition, transform.position);
    }
}