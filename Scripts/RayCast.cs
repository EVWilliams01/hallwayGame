using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float targetDistance;

    
    

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit TheHit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out TheHit))
        {
            targetDistance = TheHit.distance;
        }

    }
}
