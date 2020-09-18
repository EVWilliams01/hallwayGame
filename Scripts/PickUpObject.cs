using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;

    public float throwForce = 10;

    bool hasPlayer = false;
    bool beingCarried = false;
    public bool touched = false;
    
    
    void Update()
    {


        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        //if the player is 3f away or less from object then it will do soemthing

        if (dist <= 1f)
        {
            
            hasPlayer = true;
            
        }
        else
        {
            
            hasPlayer = false;
            
        }

        //if has player is true and mouse button is clicked then put object as child of camera and being carried is true 

        if (hasPlayer && Input.GetMouseButtonDown(0))
        {
            
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
            
        }


        // being carried is true so do something
        
        if (beingCarried)
        {

            


            if (Input.GetMouseButtonUp(0))
            {
               
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                
            }
            else if (Input.GetMouseButtonDown(1))
            {
               
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
               
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
}
