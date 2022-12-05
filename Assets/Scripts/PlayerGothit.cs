using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGothit : MonoBehaviour
{
    public Laser L;
    public Laser L1;
    public Laser L2;
    public Laser L3;
    public Laser L4;
    public Laser L5;
    public Laser L6;
    public Laser L7;
    public Laser L8;
    public Laser L9;
    public Laser L10;
    public Laser L11;
    private Vector3 myPosition;

    public void MoveGameObject()
    {
        // The player moves to a specific coordinate and does not change direction
        transform.position = new Vector3(-1.14f, -0.72f, -35.5f);
        transform.Rotate(0, 0, 0, Space.World);
    }

    // Read the PlayerHit event in the Laser script 
    // Run the MoveGameObject method if it is true.
    void Update()
    {
        if (L.PlayerHit)
        {
            MoveGameObject();
        }
        if (L1.PlayerHit)
        {
            MoveGameObject();
        }
        if (L2.PlayerHit)
        {
            MoveGameObject();
        }
        if (L3.PlayerHit)
        {
            MoveGameObject();
        }
        if (L4.PlayerHit)
        {
            MoveGameObject();
        }
        if (L5.PlayerHit)
        {
            MoveGameObject();
        }
        if (L6.PlayerHit)
        {
            MoveGameObject();
        }
        if (L7.PlayerHit)
        {
            MoveGameObject();
        }
        if (L8.PlayerHit)
        {
            MoveGameObject();
        }
        if (L9.PlayerHit)
        {
            MoveGameObject();
        }
        if (L10.PlayerHit)
        {
            MoveGameObject();
        }
        if (L11.PlayerHit)
        {
            MoveGameObject();
        }

    }
}
