using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagement2 : MonoBehaviour
{
    public GameObject pauseUI;
    public void OnRestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnGameResumePress()
    {
        pauseUI.SetActive(false);

    }
    public void OnGameExitPress()
    {
        Application.Quit();
    }

    public void OnEnterPausePress()
    {
        pauseUI.SetActive(true);
    }
}
