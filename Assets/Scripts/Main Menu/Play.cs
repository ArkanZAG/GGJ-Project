using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;



public class SceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    private string gameScene = "GameScene";
    private string menuScene = "MainMenuScene";
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button menuButton;

    private void Start()
    {
        startButton.onClick.AddListener(LoadScene);
        menuButton.onClick.AddListener(MainMenu);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(gameScene);
        Debug.Log("berhasil");
    }

    void QuitScene()
    {
        Application.Quit();
    }
    
    void MainMenu()
    {
        SceneManager.LoadScene(menuScene);
        Debug.Log("berhasil");
    }
}
