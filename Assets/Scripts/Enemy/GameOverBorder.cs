using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBorder : MonoBehaviour
{
    private string gameOverScene = "GameOver";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player") return;
        SceneManager.LoadScene(gameOverScene);
    }
}
