using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController: MonoBehaviour
{
    public Camera eyes;
    CharacterController controller;

    public float speed;
    public float sensitivity;

    float moveFB;
    float moveLR;
    float mouseX;
    float mouseY;

    public float gravity = 1;

  


    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    } 

 
    void Update()
    {

        

              

        moveFB = Input.GetAxis("Vertical");
        moveLR = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(0, mouseX * sensitivity, 0);
        eyes.transform.Rotate(-mouseY * sensitivity, 0, 0);
        

        Vector3 movement = new Vector3(moveLR * speed * Time.deltaTime,0 , moveFB * speed * Time.deltaTime);
        movement.y -= gravity * Time.deltaTime;
        controller.Move(transform.rotation *  movement);
        
    }


}