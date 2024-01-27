using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    

    void LoadScene()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }
}
