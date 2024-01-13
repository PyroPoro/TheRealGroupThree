using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //public Button exitButton;
    private bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        // Button exitButtonComponent = exitButton.GetComponent<Button>();
        //exitButtonComponent.onClick.AddListener(ExitApplication);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !paused)
        {
            gameObject.SetActive(true);
            paused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            paused = false;
        }
    }

    void ExitApplication()
    {
        Application.Quit();
    }
}
