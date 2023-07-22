using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }

    void Reset()
    {
        Debug.Log("Reset");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    void OnEnable()
    {
        Debug.Log("Enable");
    }

    void OnDisable()
    {
        Debug.Log("Disable");
    }

    void OnDestroy()
    {
        Debug.Log("Destroy");
    }
}
