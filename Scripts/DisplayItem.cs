using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour
{
    public string myString;
    public Text myText;
    
    public bool diaplayInfo;

    public RayCast rayCastScript;
        
        
     //if mouse is hovering over object and within 5f then show text 
    private void OnMouseOver()
    {
        if(rayCastScript.targetDistance < 1.5 )
        {
            myText.text = myString;
            diaplayInfo = true;
        }
       
    }

    // on mouse exit show no text 

    private void OnMouseExit()
    {
        myText.text = "";
        diaplayInfo = false;
    }
}
