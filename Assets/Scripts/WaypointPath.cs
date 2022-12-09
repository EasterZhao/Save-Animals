using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// https://www.youtube.com/watch?v=ly9mK0TGJJo&t=29s
public class WaypointPath : MonoBehaviour
{
    // Set waypoint to guide the direction of platform movement

    public Transform GetWaypoint(int waypointIndex)
    {
        //Get the required children under the waypoint by calling transform GetChild
        return transform.GetChild(waypointIndex);
    }

    // Give the current waypoint a guide to each point it reaches and to the next point in the path.
    public int GetNextWaypointIndex(int currentWaypointIndex)
    {
        // When the number of indexes of the waypoint equals the number of child objects, then the path has reached the end and the start point is returned.
        int nextWaypointIndex = currentWaypointIndex + 1;

        if (nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }

        return nextWaypointIndex;
    }
}