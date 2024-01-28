using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    private string gameScene = "GameScene";
    private string menuScene = "MainMenuScene";
    private string levelScene = "GameScene2";
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private Button nextButton;

    private void Start()
    {
        startButton.onClick.AddListener(LoadScene);
        menuButton.onClick.AddListener(MainMenu);
        nextButton.onClick.AddListener(NextLevel);
        quitButton.onClick.AddListener(QuitScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(gameScene);
        Debug.Log("berhasil");
    }

    public void QuitScene()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    
    void MainMenu()
    {
        SceneManager.LoadScene(menuScene);
        Debug.Log("berhasil");
    }
    void NextLevel()
    {
        SceneManager.LoadScene(levelScene);
    }
}

