using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
