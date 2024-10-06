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
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
    }
}