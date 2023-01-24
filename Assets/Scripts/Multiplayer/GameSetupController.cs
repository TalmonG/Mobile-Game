using UnityEngine;
using System.IO;
using Photon.Pun;

public class GameSetupController : MonoBehaviour
{
    
    public GameObject playerOneSpawner;
    public GameObject playerTwoSpawner;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
        playerOneSpawner = GameObject.Find ("PlayerOneSpawner");
        playerTwoSpawner = GameObject.Find ("PlayerTwoSpawner");
    }

    //Vector3.zero
    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate ("PhotonPlayer", playerOneSpawner.transform.position, playerOneSpawner.transform.rotation, 0);
        }
        else
        {
            PhotonNetwork.Instantiate ("PhotonPlayer", playerTwoSpawner.transform.position, playerTwoSpawner.transform.rotation, 0);
        }
    }

}
