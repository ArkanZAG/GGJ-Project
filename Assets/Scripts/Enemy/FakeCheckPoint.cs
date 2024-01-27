using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeCheckPoint : MonoBehaviour
{
    private string gameScene = "GameScene";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player") return;
        SceneManager.LoadScene(gameScene);
    }
}
