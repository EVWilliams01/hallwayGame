using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // hide cursor from scene and lock it to the middle of the screen
        
  Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        

   

    }
}
