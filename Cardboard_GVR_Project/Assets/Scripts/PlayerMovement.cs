using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Transform vrCamera;			// use this to calculate wheather the player walks or not
	public float toggleAngle = 15.0f;	// looking down to 30 degrees means the player starts to move
	public float speed = 600.0f; 		// speed of walking 
	public bool moveForward;			// when true walk, when false stop / stay still 

	private CharacterController cc;		// only gets executed in this class 


    // Start is called before the first frame update
    void Start()
    {
    	cc = GetComponent<CharacterController>(); // head movement
        
    }

    // Update is called once per frame

    void Update()
    {
    	if (vrCamera.eulerAngles.x >=toggleAngle && vrCamera.eulerAngles.x < 90.0f)  // checks if the camera angle is equal to the moving Angle 
    																				 // or lower than 90 degrees
    	{

    		moveForward = true;	// if the camera angle is at the given degree then moveForword is set to true

    	}

    	else 
    	{

    		moveForward = false;  // if not then moveforward is set to false 

    	}

    	if (moveForward) // if the bool its true the character controller is called to move forward 
    	{

    		Vector3 forward = vrCamera.TransformDirection(Vector3.forward); 	// get the direction of the camera 
    		cc.SimpleMove(forward * speed * Time.deltaTime); 					// the character controller will move the camera to the direction caught 
    																			// in the forward attribute and using the speed it will move there
    																		
    	}
    }
}
