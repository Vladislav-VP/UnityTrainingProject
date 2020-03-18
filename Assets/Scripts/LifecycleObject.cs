using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LifecycleObject : MonoBehaviour
{
    private void Awake()
    {
      //  Debug.Log("Awake");
    }

    private void OnEnable()
    {
       // Debug.Log("OnEnable");
    }

    private void Start()
    {
       // Debug.Log("Start");
    }

    private void Update()
    {
        //Debug.Log("Update");
        Debug.Log($"Time.time: {Time.time}");
        Debug.Log($"Time.deltaTime: {Time.deltaTime}");
    }
    
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    private void Reset()
    {
       // Debug.Log("Reset");
    }

    private void OnDestroy()
    {
       // Debug.Log("OnDestroy");
    }

    private void OnDisable()
    {
        //Debug.Log("OnDisable");
    }

    private void OnApplicationQuit()
    {
        //Debug.Log("OnApplicationQuit");
    }
}
