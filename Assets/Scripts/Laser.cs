using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// https://www.youtube.com/watch?v=TokDH2OSiBE&t=322s
public class Laser : MonoBehaviour
{

    private LineRenderer lr;

    public Transform startPoint;
    public bool PlayerHit = false;

    void Start()
    {
        //Get component LineRenderer
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        PlayerHit = false;
        lr.SetPosition(0, startPoint.position);
        RaycastHit hit;
        // draws a line along the length of the Ray whenever a collision is detected:
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }
            if (hit.transform.tag == "Reach")
            {
                PlayerHit = true;
            }
        }
        else lr.SetPosition(1, transform.forward * 5000);

    }
}