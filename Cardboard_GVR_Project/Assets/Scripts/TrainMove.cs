using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove : MonoBehaviour
{

	public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1533.0f, -1.0f, -1423.5f);  // trains initial position 
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x - speed; 
        if (newX < -1583)
        {
        	newX = 1533.0f; 
        }

        transform.position = new Vector3(newX, -1.0f, -1423.5f);
    }
}
