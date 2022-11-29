using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private bool isGameActive;
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    public static GameManager Instance
    {
        get { return instance; }
    }

    public bool IsGameActive
    {
        get
        {
            return isGameActive;
        }
        set
        {
            isGameActive = value;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public float obstacleSpeed;
    public float spawnTimeInterval;
    public float difficultyIncrement;
}
