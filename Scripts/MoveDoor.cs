using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    public float speed = 2f;

    public Button buttonScript;

    

    void Update()
    {
        //if button click is true then move object up

        if(buttonScript.buttonOn == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);      
        }
          
    }
}

