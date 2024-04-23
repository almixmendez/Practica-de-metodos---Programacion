using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] float points;
    [SerializeField] TextMeshProUGUI scoreText;

    public void ScoreUpdate(int score)
    {
        points = points + score;

        scoreText.text = "Coins: " + points;
    }
}
