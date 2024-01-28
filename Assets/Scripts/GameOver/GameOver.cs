using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using Random = System.Random;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverQuote;
    private string[] gameOverString = 
            {
                "Gapapa pertama kali coba",
                "Jangan ngulang kesalahan yang sama",
                "Yah kasian udah jauh malah mati",
                "Hapalin jebakan-jebakannya",
                "Never give up",
                "Jangan mudah menyerah walaupun sulit",
                "Focus",
                "Hati-hati",
                "Awas jatuh",
                "Minum air biar fokus",
                "Kamu belajar dari kesalahan ga sih?...",
                "Skill issue",
                "Landaknya Lucu",
                "Koin bukan segalanya",
                "Hampir",
                "Coba ganti usernya",
                "Udah nolep kamu",
                "Santai aja ga usah buru-buru",
                "Semua masalah pasti ada jalannya",
                "Never gonna give you up",
                "Yah ngulang lagi",
                "Jangan buang-buang waktu kamu:D",
                "Tetap menyerah dan janganlah berusaha"
            };
    public void GetRandomText()
    {
        if (gameOverString.Length > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, gameOverString.Length);
            string randomQuote = gameOverString[randomIndex];
            gameOverQuote.text = randomQuote;
        }
        else
        {
            Debug.LogWarning("Array Kosong");
        }
    }

    private void Start()
    {
        GetRandomText();
    }
}
