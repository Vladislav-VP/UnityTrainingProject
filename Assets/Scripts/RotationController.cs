using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(RotateObject());
    }

    private IEnumerator RotateObject()
    {
        Quaternion startRotation = transform.rotation;
        var xAxis = new Vector3(1, 0, 0);
        var yAxis = new Vector3(0, 1, 0);

        transform.Rotate(xAxis, 90);
        yield return new WaitForSeconds(5);
        transform.Rotate(yAxis, 90);

        Quaternion finalFotation = transform.rotation;

        float rotationAngle = Quaternion.Angle(startRotation, finalFotation);
        Debug.Log(rotationAngle);
    }    
}
