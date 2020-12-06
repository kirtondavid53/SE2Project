using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update

    //camera rotation variables
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    //camera movement variables
    public CharacterController controller;

    public float speed = 40f;

    public bool _camera_lockOn = false;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera look
     
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
    
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
               

        //camera movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    
    }
}
