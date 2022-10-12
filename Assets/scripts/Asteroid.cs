using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour

{
	Transform myT;
	Vector3 randomRotation;
    // Start is called before the first frame update
    void Awake()
    {
        myT=Transform;

    }
    void start(){
    	Vector3 scale=3;
    	sacale.x=Random.Range(.8f,1.2f);
    	myT.localScale=scale;
    }

    
    void Update()
    {
        
    }
}
