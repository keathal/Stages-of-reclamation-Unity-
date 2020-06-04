using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float speedTr = 150.0f;
    Vector3 moveVector;
    CharacterController controller;

    // Use this for initialization
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetKey(KeyCode.Q) ? -1 : (Input.GetKey(KeyCode.E) ? 1 : 0);
        moveVector.z = Input.GetAxisRaw("Vertical");
        moveVector = transform.TransformVector(moveVector);
        if (transform.position.y >= 800 && moveVector.y > 0)
            moveVector.y = 0;
        else if (transform.position.y <=100 && moveVector.y < 0)
            moveVector.y = 0;
        controller.Move(moveVector * Time.deltaTime * speedTr);

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        if (pitch < -45.0f)
            pitch = -45;
        if (pitch > 90.0f)
            pitch = 90;
        
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
