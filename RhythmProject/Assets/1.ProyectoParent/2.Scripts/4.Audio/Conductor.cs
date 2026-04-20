using UnityEngine;

public class Conductor : MonoBehaviour
{
    public static Conductor instance;

    [Header("Audio")]
    public AudioSource musicSource;

    [Header("Song Settings")]
    public float bpm = 120f;
    public float songOffset = 0f; // ajuste manual si hay latencia

    private double dspSongTime;
    private double songStartTime;

    public float songPosition;        // tiempo actual en segundos
    public float songPositionInBeats; // tiempo en beats

    private float secondsPerBeat;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        secondsPerBeat = 60f / bpm;

        // Programar inicio preciso
        songStartTime = AudioSettings.dspTime + 1.0;
        musicSource.PlayScheduled(songStartTime);
    }

    void Update()
    {
        // Tiempo actual basado en DSP (MUCHO más preciso)
        dspSongTime = AudioSettings.dspTime;

        songPosition = (float)(dspSongTime - songStartTime) - songOffset;

        songPositionInBeats = songPosition / secondsPerBeat;
    }
}
