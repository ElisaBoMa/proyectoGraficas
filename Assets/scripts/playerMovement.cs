using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	[SerialzeField]float movementSpeed = 100f;
	[SerialzeField]float turnSpeed = 60f;
    
    transform myT;
    void Awake(){
    	myT = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Turn();
        Thrust();
    }
     void Turn(){

     }

    void Thrust(){
    	if(Input.GetAxis("Vertical")>0)
    		myT.position += myT.forward = movementSpeed *Time.deltaTime * Input.GetAxis("Vertical");
    }
}
