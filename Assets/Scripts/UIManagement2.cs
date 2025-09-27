using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagement2 : MonoBehaviour
{
    public GameObject pauseUI;
    public PlayerMovement playerMovement;
    public void OnRestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnGameResumePress()
    {
        pauseUI.SetActive(false);
        playerMovement.enabled = true;
    }
    public void OnGameExitPress()
    {
        Application.Quit();
    }

    public void OnEnterPausePress()
    {
        pauseUI.SetActive(true);
        playerMovement.enabled = false;
    }
}
