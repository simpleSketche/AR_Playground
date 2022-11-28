using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
    }

    public float obstacleSpeed;
    public float spawnTimeInterval;
    public float difficultyIncrement;
}
