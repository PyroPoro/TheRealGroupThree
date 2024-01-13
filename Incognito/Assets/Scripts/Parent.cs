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



    // Start is called before the first frame update
    void Start()
    {
        currentInterval = Random.Range(upperInterval, lowerInterval);
        timer = 0f;
        
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
        Debug.Log("Walk in");
    }
}
