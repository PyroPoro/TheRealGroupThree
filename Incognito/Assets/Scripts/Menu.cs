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
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        Debug.Log("Hide UI");
        cam.GetComponent<CameraController>().enabled = true;
        phoneController.GetComponent<PhoneMovement>().enabled = true;
        parentController.GetComponent<Parent>().enabled = true;
        gameObject.SetActive(false);
    }

    void ExitApplication()
    {
        Application.Quit();
    }
}
