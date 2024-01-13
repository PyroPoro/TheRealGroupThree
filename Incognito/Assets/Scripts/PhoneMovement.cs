using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneMovement : MonoBehaviour
{
    // Variable to track phone state
    public static bool isPhoneUp = true;
    public GameObject phonehand;

    //audio variables
    public AudioClip phoneUpSound;
    public AudioClip phoneDownSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
        if (Input.GetKeyDown(KeyCode.A) && isPhoneUp == false)
        {
            isPhoneUp = true;
            //just print for now
            //should trigger animation and show phone in player's hand
            Debug.Log("Phone is up");
            audioSource.clip = phoneUpSound;
            audioSource.PlayOneShot(phoneUpSound);
            phonehand.GetComponent<Animator>().SetTrigger("toggle");
        }

        // Set phone state to false when 'L' key is pressed
        if (Input.GetKeyDown(KeyCode.L) && isPhoneUp == true)
        {
            isPhoneUp = false;
            //just print for now
            //should trigger animation to put phone down
            Debug.Log("Phone is down");
            audioSource.clip = phoneDownSound;
            audioSource.PlayOneShot(phoneDownSound);
            phonehand.GetComponent<Animator>().SetTrigger("toggle");
        }
    }
}
