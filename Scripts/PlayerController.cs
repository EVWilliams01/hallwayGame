using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public Camera eyes;
    CharacterController controller;
    private Rigidbody playerRB;

    public bool isOnGround = true;

    public float speed;
    public float sensitivity;

    public float jumpForce;
    public float gravityModifier;

    float moveFB;
    float moveLR;
    float mouseX;
    float mouseY;
    

    

    void Start()
    {
        controller = GetComponent<CharacterController>();

        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    } 

 
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        moveFB = Input.GetAxis("Vertical");
        moveLR = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(0, mouseX * sensitivity, 0);
        eyes.transform.Rotate(-mouseY * sensitivity, 0, 0);
        

        Vector3 movement = new Vector3(moveLR * speed * Time.deltaTime, 0, moveFB * speed * Time.deltaTime);
        controller.Move(transform.rotation *  movement);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}