using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startButton;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
        cam.GetComponent<CameraController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        Debug.Log("Hide UI");
        cam.GetComponent<CameraController>().enabled = true;
        gameObject.SetActive(false);
    }
}
