using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWinDefeatManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject defatPanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI scoreText;

    public int Aciertos { get; set; }

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

    public void AddScoreToText()
    {
        scoreText.text = $"Score: {Aciertos}/10";
    }

    public void OpenDefeatPanel()
    {
        defatPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OpenWinPanel()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
