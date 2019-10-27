using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int modeGame = 1;
    public int nbEnemy = 20;
    public int nbLivesPlayer = 50;

    int[] wave1 = new int[] { 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 2 };
    int[] wave2 = new int[] { 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 1, 1, 2, 2, 2 };

    //public GameObject gameOverUI;
    //public GameObject completeLevelUI;

    // Use this for initialization
    void Start () {
        //GameIsOver = false;
    }

    void Update()
    {
        //if (GameIsOver)
        //    return;

        //if (PlayerStats.Lives <= 0)
        //{
        //    EndGame();
        //}
    }

    //void EndGame()
    //{
    //    GameIsOver = true;
    //    gameOverUI.SetActive(true);
    //}

    //public void WinLevel()
    //{
    //    GameIsOver = true;
    //    completeLevelUI.SetActive(true);
    //}

    public int getcurrentEnemyType(int i)
    {
        return wave1[i];
    }
}
