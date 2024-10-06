using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public Vector3 goal = new Vector3(0, 0, 0);
    void Update()
    {
        transform.Translate(goal);
    }
}
