using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trig : MonoBehaviour {

    public Text goal;
   

    void Start()
    {
        goal.text = "";
        
    }

  


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            goal.text = "GOAL";
            
        }
        else if (other.gameObject.CompareTag("car"))
        {
            goal.text = "";
        }
    }

   
 
	}

