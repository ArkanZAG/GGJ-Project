using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;


public class Collectible : MonoBehaviour
{
    [SerializeField] private int scoreValue;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private GameObject imageGameObject;
    private bool collected;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;
        Debug.Log("Trigger Enter");
        if (other.gameObject.tag != "Player") return;
        Debug.Log("Score Added");
        scoreCounter.AddScore(scoreValue);
        scoreCounter.UpdateScore();
        imageGameObject.gameObject.SetActive(false);
        collected = true;
    }
}
