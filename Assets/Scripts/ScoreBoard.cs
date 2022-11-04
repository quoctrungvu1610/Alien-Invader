using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score = 0;
    TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score : {score}";
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
    }
}
