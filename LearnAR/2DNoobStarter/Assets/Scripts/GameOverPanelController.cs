using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanelController : MonoBehaviour
{
    public Text scoreText;
    private void Start()
    {
        scoreText.text = GameManager.Instance.Score.ToString();
    }
    public void OnHomeButtonClick()
    {
        // load main scene
        SceneManager.LoadSceneAsync("main");
               
    }
    public void OnRetryButtonClick()
    {
        SceneManager.LoadSceneAsync("game");
    }
}
