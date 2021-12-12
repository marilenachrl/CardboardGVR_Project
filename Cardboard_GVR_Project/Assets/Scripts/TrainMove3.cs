using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove3 : MonoBehaviour
{
  	public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-1623.0f, -1.0f, 1595.5f);  // trains initial position 
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x + speed; 
        if (newX > 1550)
        {
        	newX = -1623.0f; 
        }

          transform.position = new Vector3(newX, -1.0f, 1595.5f);
    }
}
