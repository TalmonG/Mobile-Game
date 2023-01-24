using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class SceneLoader : MonoBehaviourPunCallbacks
{
    public void DelayStartMenu()
    {
        SceneManager.LoadScene("DelayStartMenu");
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

    public void LeaveGame()
    {
        PhotonNetwork.LeaveRoom();
    }
}
