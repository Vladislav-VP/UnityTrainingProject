using System.Collections;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    private const float maxRotationAngle = 90f;

    private float xRotation;
    private float yRotation;

    private void Start()
    {
        StartCoroutine(RotateObject());
    }

    private IEnumerator RotateObject()
    {
        Quaternion startRotation = transform.rotation;

        while (xRotation < maxRotationAngle)
        {
            xRotation += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(xRotation, 0, 0);
            yield return null;
        }

        while (yRotation < maxRotationAngle)
        {
            yRotation += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            yield return null;
        }

        Quaternion finalFotation = transform.rotation;
        float rotationAngle = Quaternion.Angle(startRotation, finalFotation);
        Debug.Log($"Total rotation angle: {rotationAngle}");
    }
}
