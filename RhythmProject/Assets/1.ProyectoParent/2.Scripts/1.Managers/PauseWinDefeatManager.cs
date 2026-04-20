using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWinDefeatManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject defatPanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private BeatTest1 beatTest;

    public int Aciertos { get; set; }

    public void PausePanelBtn()
    {
        pausePanel.SetActive(true);
        beatTest.musicSource.Pause();
        Time.timeScale = 0f;
    }

    public void BackPausePanelBtn()
    {
        pausePanel.SetActive(false);
        beatTest.musicSource.UnPause();
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
        scoreText.text = $"Score: {Aciertos}";
    }

    public void OpenDefeatPanel()
    {
        defatPanel.SetActive(true);
        beatTest.musicSource.Stop();
        Time.timeScale = 0f;
    }

    public void OpenWinPanel()
    {
        winPanel.SetActive(true);
        beatTest.musicSource.Stop();
        Time.timeScale = 0;
    }
}
