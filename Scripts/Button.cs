using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Material startingMaterial;
    private Material afterClickMaterial;
    public GameObject button;
    private MeshRenderer mr;

    public bool buttonOn = false;


    // Start is called before the first frame update
    void Start()
    {
        // these are the strating and after click materials

        startingMaterial = Resources.Load("Red") as Material;
        afterClickMaterial = Resources.Load("Green") as Material;

        // this is grabbing the mesh renderer component inside the object

        mr = this.GetComponent<MeshRenderer>();

        
    }

    private void OnMouseOver()
    {

        // if mouse button down and button is on tyhen change color to after click material and button is on is true

        if (Input.GetMouseButtonDown(0) && !buttonOn)
        {
            Debug.Log("Done");
            mr.material = afterClickMaterial;
            buttonOn = true;
            
            
        }
    }
}
 