using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

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
            paused = true;
            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("Exited game");
                Application.Quit();
            }
        }
        // Resume
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            pauseMenu.SetActive(false);
            paused = false;
            Time.timeScale = 1;
        }
    }
}
