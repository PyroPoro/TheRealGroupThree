using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{   
    GameObject parentObject;
    Parent parentScript;

    GameObject phoneMovementObject;
    PhoneMovement phoneMovementScript;

    public GameObject gameOverCanvas;
    public GameObject score;
    public TMP_Text scoreText;

    public bool isGameOver = false;
    void Start()
    {
        parentObject = GameObject.Find("Parent Controller");
        phoneMovementObject = GameObject.Find("Phone Controller");
        parentScript = parentObject.GetComponent<Parent>();
        phoneMovementScript = phoneMovementObject.GetComponent<PhoneMovement>();
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (phoneMovementScript.isPhoneNonStatic == true && parentScript.doorOpen == true){
            Time.timeScale = 0;
            gameOverCanvas.SetActive(true);
            isGameOver = true;
            scoreText.text = "Score: " + (int)score.GetComponent<ScoreManager>().score;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && isGameOver){
            Debug.Log("Exit game");
            Application.Quit();
        }

        if(Input.GetKeyDown(KeyCode.R) && isGameOver){
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
