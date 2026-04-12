using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWinDefeatManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject defatPanel;

    public void PausePanelBtn()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void BackPausePanelBtn()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void MainMenuBtn()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void RestartBtn()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    public void OpenDefeatPanel()
    {
        defatPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
