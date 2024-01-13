using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneMovement : MonoBehaviour
{
    // Variable to track phone state
    public bool isPhoneUp = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         // Check for key presses and update phone state
        HandleInput();  
    }

    // Function to handle key presses and update phone state
    void HandleInput()
    {
        // Toggle phone state when 'A' key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            isPhoneUp = true;
            //just print for now
            //should trigger animation and show phone in player's hand
            Debug.Log("Phone is up");
        }

        // Set phone state to false when 'L' key is pressed
        if (Input.GetKeyDown(KeyCode.L))
        {
            isPhoneUp = false;
            //just print for now
            //should trigger animation to put phone down
            Debug.Log("Phone is down");
        }
    }
}
