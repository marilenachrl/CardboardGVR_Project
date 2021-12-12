using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour	
{
	public GameObject Player; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pointerClick()
    {

    	Player.transform.position = new Vector3(transform.position.x, transform.position.y - 27.0f, transform.position.z + 10.0f);


    }
}
