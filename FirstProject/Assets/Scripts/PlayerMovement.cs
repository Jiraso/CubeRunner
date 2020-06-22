using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 600f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start!");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            //(x-axis, y-axis, z-axis)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //(x-axis, y-axis, z-axis)
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            //(x-axis, y-axis, z-axis)
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
