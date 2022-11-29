using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanelController : MonoBehaviour
{
    private void OnEnable()
    {
        // it changes timescale to 0;
        Time.timeScale = 0;
    }

    public void OnHomeButtonClick()
    {
        SceneManager.LoadSceneAsync("main");
    }
    public void OnPlayButtonClick()
    {
        Camera.main.SendMessage("ActivatePausePanel", false, SendMessageOptions.DontRequireReceiver);
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }
}
