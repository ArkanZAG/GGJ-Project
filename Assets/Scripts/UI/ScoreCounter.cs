using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    private int currentScore;
    public void AddScore(int value)
    {
        currentScore += value;
    }

    private void UpdateScore()
    {
        counterText.text += currentScore;
    }

    
}
