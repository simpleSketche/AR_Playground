using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudPanelController : MonoBehaviour
{
    private static HudPanelController instance;
    public static HudPanelController Instance
    {
        get
        {
            return instance;
        }
    }

    public Text scoreText;

    public void Awake()
    {
        instance = this;
        scoreText.text = "0";
    }
    public void OnPauseButtonClick()
    {
        Camera.main.SendMessage("ActivatePausePanel", true, SendMessageOptions.DontRequireReceiver);
    }
    public void UpdateScore()
    {
        scoreText.text = GameManager.Instance.Score.ToString();
    }
}
