using TMPro;
using UnityEngine;

public class SelectSong : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numberSongText;

    private int songNumber = 1;

    private void Start()
    {
        StaticVariablesManager.SongNumber = 0;
    }

    public void RightArrowButton()
    {
        songNumber++;

        if (songNumber > 3)
            songNumber = 1;

        numberSongText.text = songNumber.ToString();

        StaticVariablesManager.SongNumber = songNumber - 1;
    }

    public void LeftArrowButton()
    {
        songNumber--;

        if (songNumber < 1)
            songNumber = 3;

        numberSongText.text = songNumber.ToString();

        StaticVariablesManager.SongNumber = songNumber - 1;
    }
}
