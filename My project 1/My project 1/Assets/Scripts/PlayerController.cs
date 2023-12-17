using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    public float maxSpeed;
    public float acceleration = 0.1f;
    private int desiredLane = 1;//0:left 1:middle 2:right
    public float laneDistance = 4;//distance between 2 lanes
   

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Handles Right lane changes on user input.
    
    void Update()
    {
       
        

        forwardSpeed += acceleration;

        if (forwardSpeed > maxSpeed)
            forwardSpeed = maxSpeed;

        direction.z = forwardSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }
        // Handles left lane changes on user input.

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }
        // Calculates the target position based on the desired lane and updates the player's position.

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
       
        transform.position = targetPosition; 

        // player can now collide with objects
        controller.center = controller.center;
    }
    // Moves the player using the CharacterController in FixedUpdate.
    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }
    // Handles collisions with obstacles using the CharacterController.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if(hit.transform.tag == "Obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }
}
