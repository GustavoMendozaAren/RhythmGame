using UnityEngine;

public class BeatTest1 : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private SpawnProyectiles spawnProyectiles;
    [SerializeField] private AudioClip[] audioClips;
    public AudioSource musicSource;
    public float bpm = 120f;

    [Tooltip("Tiempo que tarda el proyectil en llegar al centro")]
    public float travelTime = 1f;

    // Timing interno
    private double dspStartTime;
    private double beatInterval;
    private int lastSpawnedBeat = -1;

    private double songTime;
    private int currentBeat;
    private double spawnTime;

    void Start()
    {
        musicSource.clip = audioClips[StaticVariablesManager.SongNumber];
        beatInterval = 60.0 / bpm;

        // Guardamos el tiempo DSP exacto cuando inicia la música
        dspStartTime = AudioSettings.dspTime;
        musicSource.Play();
    }

    void Update()
    {
        

        if (musicSource.isPlaying)
        {
            songTime = AudioSettings.dspTime - dspStartTime;
            
            // Calculamos en qué beat estamos
            currentBeat = Mathf.FloorToInt((float)(songTime / beatInterval));

            // Calculamos cuándo debería aparecer el proyectil
            spawnTime = (currentBeat * beatInterval) - travelTime;

            // Si ya es momento de spawnear ese beat
            if (currentBeat > 0 && songTime >= spawnTime && currentBeat > lastSpawnedBeat)
            {
                spawnProyectiles.SpawnProyectile();
                lastSpawnedBeat = currentBeat;
            }
        }
    }
}
