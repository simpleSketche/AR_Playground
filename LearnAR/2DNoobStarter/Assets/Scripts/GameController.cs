using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance
    {
        get
        {
            return instance;
        }
    }
    public SpawnManager spawnManager;
    public void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        GameManager.Instance.IsGameActive = true;
        GameManager.Instance.Score = 0;
        spawnManager.StartSpawn();
    }
    public void StopGame()
    {
        GameManager.Instance.IsGameActive = false;
        spawnManager.StopAllCoroutines();
        StartCoroutine(GameOver());
    }
    IEnumerator GameOver()
    {
        // show game over panel after wait time
        yield return new WaitForSeconds(0.5f);
        Camera.main.SendMessage("ActivateGameOverPanel", true, SendMessageOptions.DontRequireReceiver);
    }
}
