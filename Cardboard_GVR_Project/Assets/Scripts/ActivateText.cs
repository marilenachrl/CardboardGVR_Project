using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
	public GameObject UIObject;
	

	void Start ()
	{
		UIObject.SetActive(false); 
	}

  	public void onTriggerEnter()
  	{
  		
  			
  			UIObject.SetActive(true);  // when the Player walks on the information cube the text is set active(display)
  		

  	}

  	public void onTriggerExit()
  	{

  		UIObject.SetActive(false); 
  	 	// move away from the object the text is set active false (stop displaying)

  	}


}
