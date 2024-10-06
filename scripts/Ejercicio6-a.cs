using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    void Update()
    {
        transform.LookAt(goal);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}