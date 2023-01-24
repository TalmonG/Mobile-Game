using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;


public class GameManager : MonoBehaviour
{
    public GameObject ballSpawner;

    [Header("Ball")]
    public GameObject[] ball;
    public GameObject[] ballClone;

    [Header("Player 1")]
    //public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    //public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Start()
    {
        ballSpawner = GameObject.Find ("BallSpawner");
    }

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
        PhotonNetwork.Instantiate ("Ball", ballSpawner.transform.position, ballSpawner.transform.rotation, 0);
        Debug.Log("1");

    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
        PhotonNetwork.Instantiate ("Ball", ballSpawner.transform.position, ballSpawner.transform.rotation, 0);
        Debug.Log("2");
    }

    private void ResetPosition()
    {
        //GameObject.Find("Ball").GetComponent<Ball>().Reset();
        //ball.GetComponent<Ball>().Reset();
        Destroy(gameObject);
        //Instantiate("ball", new Vector2(0, 0));
        //player1Paddle.GetComponent<Paddle>().Reset();
        //player2Paddle.GetComponent<Paddle>().Reset();
    }

}
