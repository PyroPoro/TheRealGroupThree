using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text playerScoreText;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro playerScoreObj = GetComponent<TMP_text>();
        UpdateScoreText(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PhoneMovement.isPhoneUp)
        {
            score += (int)Mathf.Round(Time.deltaTime);
        }
        UpdateScoreText(score);
    }

    private void UpdateScoreText(int score)
    {
        playerScoreText.text = "Score: " + score;
    }


}
