using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;

    public BallController ballController;

    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        playerPaddle.position = new Vector3(-7f, 0f, 0f);
        enemyPaddle.position = new Vector3(7f, 0f, 0f);


        ballController.ResetBall();
    }
}
