using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Loading()
    {
        SceneManager.LoadScene("Loading");
    }

    public void Lobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void MultiplayerGame()
    {
        SceneManager.LoadScene("MultiplayerGame");
    }

    public void DelayStartWaitingRoom()
    {
        SceneManager.LoadScene("DelayStartWaitingRoom");
    }


}
