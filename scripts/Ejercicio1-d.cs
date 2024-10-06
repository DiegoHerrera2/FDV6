using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public Vector3 point1 = new Vector3(0, 0, 0);
    public Vector3 point2 = new Vector3(0, 0, 0);
    public Vector3 point3 = new Vector3(0, 0, 0);
    
    private float t = 0;
    void Update()
    {
        t += Time.deltaTime;
        switch (t)
        {
            case < 1:
                transform.Translate(point1 * Time.deltaTime);
                break;
            case < 3:
                transform.Translate(point2 * Time.deltaTime);
                break;
            case < 4:
                transform.Translate(point3 * Time.deltaTime);
                break;
        }
    }
}
