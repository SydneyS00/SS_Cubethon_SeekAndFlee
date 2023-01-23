using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingObstacle : MonoBehaviour
{
    //This is the seeking script 
    //Will be put on top of Seeking Obstacle 

    public Transform seeker;
    public Transform player;

    public float seekerMaxSpeed; 

    public Steering getSteering()
    {
        //Basically create a new Steering class that holds the new data
        Steering result = new Steering();

        //Get the direction of the Player
        result.velocity = player.position - seeker.position;

        //Get to the player at max speed
        result.velocity.Normalize();
        result.velocity *= seekerMaxSpeed;

        //Face the direction of the player
        //Noticing that Unity does not have a orientation component 
        //Using replacement line from Slease code 
        //Turns it into a float variable that we will later use to assign to the seeker
        float newDirAngle = newOrientation(seeker.rotation.eulerAngles.y, result.velocity);
        seeker.eulerAngles = new Vector3(0, newDirAngle, 0);

        result.rotation = 0;
        return result; 

    }

    private float newOrientation(float currentVal, Vector3 velocity)
    {

        //First check to see if there is a velocity/movement?
        if (velocity.magnitude > 0)
        {
            //Calculate the angle that we need to face the player
            float playerAngle = Mathf.Atan2(velocity.x, velocity.z);

            //Convert into degrees instead of rads
            playerAngle *= Mathf.Rad2Deg;

            return playerAngle;
        }
        else
        {
            return currentVal; 
        }
       
    }
    

    
}
