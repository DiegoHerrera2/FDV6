using System;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public float speed = 5f;
    
    private List<Transform> _waypoints;
    private int _currentWaypointIndex;
    public float threshold = 0.1f;

    private void Start()
    {
        var waypointObjects = GameObject.FindGameObjectsWithTag("waypoint");
        _waypoints = new List<Transform>();
        foreach (var waypoint in waypointObjects)
        {
            _waypoints.Add(waypoint.transform);
        }

        _currentWaypointIndex = 0;
        // Ordenar waypoints por nombre
        _waypoints.Sort((w1, w2) => string.Compare(w1.name, w2.name, StringComparison.Ordinal));
    }

    private void Update()
    {
        var targetWaypoint = _waypoints[_currentWaypointIndex];
        var direction = targetWaypoint.position - transform.position;
        transform.position += direction.normalized * (speed * Time.deltaTime);
        transform.LookAt(targetWaypoint);
        if (Vector3.Distance(transform.position, targetWaypoint.position) < threshold)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Count;
        }
    }
}