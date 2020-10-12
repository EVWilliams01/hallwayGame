using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;

    public float throwForce = 10;

    bool hasPlayer = false;
    bool beingCarried = false;
    public bool touched = false;

    public Camera character;

    public DisplayItem displayItemScript;
    public GameObject key;


    float mouseX;
    float mouseY;
    public float sensitivity;




    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        float dist = Vector3.Distance(key.transform.position, player.position);

        Debug.Log(dist);

        //if the player is 1f away or less from object then it will do soemthing

        if (dist <= 1.5f)
        {
            
            hasPlayer = true;
            
        }
        else
        {
            
            hasPlayer = false;
            
        }

        //if has player is true and mouse button is clicked then put object as child of camera and being carried is true 
       
        if (hasPlayer && displayItemScript.diaplayInfo == true && Input.GetMouseButtonDown(0) )
        {
            Debug.Log("aa");
            
            GetComponent<Rigidbody>().isKinematic = true;
            
            beingCarried = true;
            
        }
 

        // being carried is true so do something
        
        if (beingCarried)
        {
            transform.rotation = character.transform.rotation;


            transform.position = character.transform.position;
                        
            transform.Rotate(0, mouseX * sensitivity, 0);
            transform.Rotate(-mouseY * sensitivity, 0, 0);


            if (Input.GetMouseButtonUp(0))
            {
               
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                
            }
        }
    }

    private void OnTriggerEnter()
    {

        //if being carried then touched is true
        if (beingCarried)
        {
            touched = true;
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);

       if( collision.gameObject.CompareTag("Key Lock"))
        {
           Destroy(gameObject);
            
        }
    }
}