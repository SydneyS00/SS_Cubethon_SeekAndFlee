using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //My rigidbody component
    public Rigidbody rig;
    //The player's speed
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 


    void FixedUpdate()
    {
        rig.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Right movement
        if(Input.GetKey("d"))
        {
            rig.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Left movement
        if(Input.GetKey("a"))
        {
            rig.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //check position of y axis
        if(rig.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
