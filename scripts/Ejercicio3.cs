using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Start()
    {
        transform.LookAt(goal);
    }

    void Update()
    {
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        Debug.DrawRay(transform.position, direction, Color.red);
    }
}