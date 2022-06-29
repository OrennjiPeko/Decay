using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

    Rigidbody playerRB;
    Vector3 movementUp, movementRight;
    [Range(0f, 1000f)]
    public float speed = 500;
    
    // Use this for initialization
    void Start()
    {
        movementUp = new Vector3(0, 0, speed);
        movementRight = new Vector3(speed, 0, 0);
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.AddForce(movementUp * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddForce(movementRight * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddForce(-movementRight * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRB.AddForce(-movementUp * Time.deltaTime);
        }
       
    }
}

