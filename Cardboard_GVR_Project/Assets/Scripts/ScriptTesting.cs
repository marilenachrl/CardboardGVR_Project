using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 	public void PointEnter()
 	{	
 		// Change the colour of the cube to blue when the pointer touches the cube
 		GetComponent<Renderer>().material.color = Color.blue; 

 	}

 	public void PointExit()
 	{
 		// Change the colour of the cube to white when pointer moves away from the cube 
 		GetComponent<Renderer>().material.color = Color.white; 

 	}

}
