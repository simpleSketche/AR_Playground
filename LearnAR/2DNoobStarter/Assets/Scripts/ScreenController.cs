using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// manage UI screens
public class ScreenController : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    // Activate / Deactivate pause panel
    public void ActivatePausePanel(bool flag)
    {
        pausePanel.SetActive(flag);
    }

    // Activate / Deactivate game over panel
    public void ActivateGameOverPanel(bool flag)
    {
        gameOverPanel.SetActive(flag);
    }
}
