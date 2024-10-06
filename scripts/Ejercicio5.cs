using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    void Update()
    {
        
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        transform.LookAt(goal);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 1.0f;
        }
    }
}