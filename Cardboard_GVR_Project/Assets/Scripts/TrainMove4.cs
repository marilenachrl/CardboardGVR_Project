using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove4 : MonoBehaviour
{
	public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-1764.7f, -1.0f, -1267.8f);  // trains initial position 
    }

    // Update is called once per frame
    void Update()
    {
        float newZ = transform.position.z + speed; 
        if (newZ > 1450)
        {
        	newZ = -1267.8f; 
        }

        transform.position = new Vector3(-1764.7f, -1.0f, newZ);
    }
}
