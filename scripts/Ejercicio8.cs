using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(goal.position - transform.position), 0.1f);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}