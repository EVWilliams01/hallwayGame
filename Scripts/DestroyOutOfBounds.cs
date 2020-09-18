using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float aboveBound = 50f;
 

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > aboveBound)
        {
            Destroy(gameObject);
        }
    }
}
