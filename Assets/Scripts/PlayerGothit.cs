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
     transform.position = new Vector3(-1.14f, -0.72f, -35.5f);
     transform.Rotate(0, 0, 0,Space.World);
 }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(L.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L1.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L2.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L3.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L4.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L5.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L6.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L7.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L8.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L9.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L10.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }
            if(L11.PlayerHit)
        {
            //to position
           MoveGameObject();
            Debug.Log("1");
        }

    }
}
