using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var serializedObject = new SerializedObject();
        string json = JsonUtility.ToJson(serializedObject);
        Debug.Log(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
