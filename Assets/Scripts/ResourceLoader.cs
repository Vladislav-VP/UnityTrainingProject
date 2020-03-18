using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadResource());
    }

    private IEnumerator LoadResource()
    {
        var sphere = Resources.Load(@"Sphere");
        Instantiate(sphere);
        yield return null;
    }
}
