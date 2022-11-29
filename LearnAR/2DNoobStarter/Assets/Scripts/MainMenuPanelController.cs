using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPanelController : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        // open the game scene or switch to the game scene
        SceneManager.LoadSceneAsync("game");
    }
}
