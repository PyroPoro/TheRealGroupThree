using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float score = 0;
    public TMP_Text playerScoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PhoneMovement.isPhoneUp)
        {
            score += Time.deltaTime;
        }
        UpdateScoreText(score);
    }

    private void UpdateScoreText(float score)
    {
        int scoreInt = (int) score;
        playerScoreText.text = "Score: " + (int) score;
    }


}
