using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

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
}
