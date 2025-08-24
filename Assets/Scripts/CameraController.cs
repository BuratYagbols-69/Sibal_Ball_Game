using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    public GameObject Sanic;
    private Vector3 offset; // <-- Add this line

    void Start()
    {
        offset = transform.position - Sanic.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Sanic.transform.position + offset;
    }
}