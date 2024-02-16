using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviorX : MonoBehaviour
{
    //Variables control the cube's speed forward and rotation speed
    //Variables control the cube's rotation direction
    public float cubeSpeed;
    public float rotateSpeed;
    public Vector3 rotationDirection;


    // Start is called before the first frame update
    // Randomly sets the scale of the cube from 0.05 to 0.5
    void Start()
    {
    float randomScale = Random.Range (0.05f,.5f);  
    transform.localScale = new Vector3 (randomScale, randomScale, randomScale);
    }

    // Update is called once per frame
    // Moves the cube forward and rotates it
    // Destroys the cube when it reaches a certain positon
    void Update()
    {
    transform.Translate(Vector3.forward * Time.deltaTime * cubeSpeed, Space.World);
    transform.Rotate (rotationDirection * Time.deltaTime * rotateSpeed, Space.World);
    if (transform.position.z > 100.0f) {
            Destroy (gameObject);
        }

    
   
    }
}
