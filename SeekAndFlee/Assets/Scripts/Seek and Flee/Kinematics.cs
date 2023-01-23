using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematics : MonoBehaviour
{
    //Similar variables that are inside the Steering script
    Vector3 velocity;
    float rotation;

    private SeekingObstacle mySteering;
    public Transform thePlayer;
    public float maxSpeed;


    //Start function
    private void Start()
    {
        mySteering = new SeekingObstacle(); 
        mySteering.player = thePlayer;
        mySteering.seeker = this.transform;
        mySteering.seekerMaxSpeed = maxSpeed; 
    }

    private void KinematicUpdate(Steering steering, float time)
    {
        //Using Millington's last lines for this function

        velocity += steering.velocity * time;
        transform.position += velocity * time; 
    }
}

