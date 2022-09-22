using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{

    public float mouseSens = 2;
    public Transform playerBody;
    float xRotate = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSens*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSens*Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -5, 35);

        transform.localRotation = Quaternion.Euler(xRotate, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
