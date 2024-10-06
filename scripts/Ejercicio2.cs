using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);
    public float speed = 1.0f;
    void Update()
    {
        transform.Translate(goal.normalized * (speed * Time.deltaTime));
    }
}