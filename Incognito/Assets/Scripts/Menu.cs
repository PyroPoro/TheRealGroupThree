using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public GameObject cam;
    public GameObject phoneController;
    public GameObject parentController;
    public GameObject scoreController;
    public GameObject pauseController;
    // Start is called before the first frame update
    void Start()
    {
        Button startButtonComponent = startButton.GetComponent<Button>();
        startButtonComponent.onClick.AddListener(StartGame);

        Button exitButtonComponent = exitButton.GetComponent<Button>();
        exitButtonComponent.onClick.AddListener(ExitApplication);

        cam.GetComponent<CameraController>().enabled = false;
        phoneController.GetComponent<PhoneMovement>().enabled = false;
        parentController.GetComponent<Parent>().enabled = false;
        scoreController.GetComponent<ScoreManager>().enabled = false;
        pauseController.GetComponent<PauseMenu>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Debug.Log("Hide UI");
        cam.GetComponent<CameraController>().enabled = true;
        cam.GetComponent<CameraController>().DestroyAnimator();
        phoneController.GetComponent<PhoneMovement>().enabled = true;
        parentController.GetComponent<Parent>().enabled = true;
        scoreController.GetComponent<ScoreManager>().enabled = true;
        pauseController.GetComponent<PauseMenu>().enabled = true;
        cam.GetComponent<Animator>().SetTrigger("start");
        gameObject.SetActive(false);
    }

    void ExitApplication()
    {
        Application.Quit();
    }
}
