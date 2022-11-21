using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        // huoqu dangqian dexuanzhuanjiaodu
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        // Limit the rotation of character
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Returns a rotation that rotates z degrees around the x axis
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Shorthand for writing Vector3(0, 1, 0) zuoyouxuanzhuan
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
