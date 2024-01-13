using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{

    public float upperInterval;  // maximum time before a parent comes in
    public float lowerInterval; // minimum time before a parent comes in
    public float intervalReductionRate;  // Rate at which interval reduces
    private float currentInterval;  // Current interval between 'hi'
    private float timer;  // Timer to keep track of time

    public float minUpper;
    public float minLower;

    // Audio
    public AudioClip doorOpenSound; 
    public AudioClip doorCloseSound; 
    private AudioSource audioSource;

    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        currentInterval = Random.Range(upperInterval, lowerInterval);
        timer = 0f;
        audioSource = GetComponent<AudioSource>();

        // Check if an audio clip is assigned
        if (doorOpenSound == null)
        {
            Debug.LogError("Audio clip not assigned! Please assign an AudioClip in the Unity Editor.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to print 'hi'
        if (timer >= currentInterval)
        {
            WalkIn();
            timer = 0f;

            // Reduce the interval
            upperInterval -= intervalReductionRate;
            lowerInterval -= intervalReductionRate;

            // Ensure the interval doesn't go below a minimum value
            if (upperInterval < minUpper)
            {
                upperInterval = minUpper;
            }

            if(lowerInterval < minLower){
                lowerInterval = minLower;
            }

            currentInterval = Random.Range(upperInterval, lowerInterval);


        }
    }

    // Parent walks in

    void WalkIn()
    {
        audioSource.clip = doorOpenSound;
        Debug.Log("Walk in");
        audioSource.PlayOneShot(doorOpenSound);
        door.GetComponent<Animator>().SetTrigger("toggle");
        Invoke("WalkOut", 2f);
    }

    void WalkOut()
    {
        audioSource.clip = doorCloseSound;
        Debug.Log("Walk out");
        audioSource.PlayOneShot(doorCloseSound);
        door.GetComponent<Animator>().SetTrigger("toggle");
    }
}
