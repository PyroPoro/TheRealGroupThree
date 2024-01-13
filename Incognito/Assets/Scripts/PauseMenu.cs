using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject cam;

    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Pause
        if (Input.GetKeyDown(KeyCode.Space) && !paused)
        {
            pauseMenu.SetActive(true);
            cam.GetComponent<CameraController>().enabled = false;
            paused = true;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        //Unpause
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            pauseMenu.SetActive(false);
            cam.GetComponent<CameraController>().enabled = true;
            paused = false;
        }
    }
}
