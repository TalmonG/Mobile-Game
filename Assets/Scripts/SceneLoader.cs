using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Loading()
    {
        SceneManager.LoadScene(1);
    }

    public void Lobby()
    {
        SceneManager.LoadScene(2);
    }

    public void MultiplayerGame()
    {
        SceneManager.LoadScene(3);
    }

    
}
