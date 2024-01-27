using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int scoreValue;
    private ScoreCounter scoreCounter;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player") return;
        scoreCounter.AddScore(scoreValue);
    }
}
