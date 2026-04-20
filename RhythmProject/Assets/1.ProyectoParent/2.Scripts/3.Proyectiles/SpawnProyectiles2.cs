using UnityEngine;

[System.Serializable]
public class ProyectilData
{
    public float time;   // momento en que llega al centro
    public bool fromLeft;
}

public class SpawnProyectiles2 : MonoBehaviour
{
    [SerializeField] private GameObject proyectilPrefab;

    [SerializeField] private Transform spawnIzquierdo;
    [SerializeField] private Transform spawnDerecho;
    [SerializeField] private Transform centro;

    [SerializeField] private float travelTime = 2f;

    [SerializeField] private ProyectilData[] proyectiles;

    private int nextIndex = 0;

    void Update()
    {
        float songTime = Conductor.instance.songPosition;

        while (nextIndex < proyectiles.Length &&
               songTime >= proyectiles[nextIndex].time - travelTime)
        {
            Spawn(proyectiles[nextIndex]);
            nextIndex++;
        }
    }

    void Spawn(ProyectilData data)
    {
        Transform spawnPoint = data.fromLeft ? spawnIzquierdo : spawnDerecho;

        GameObject obj = Instantiate(proyectilPrefab, spawnPoint.position, Quaternion.identity);

        ProyectilesCircle2 p = obj.GetComponent<ProyectilesCircle2>();

        p.startPos = spawnPoint.position;
        p.targetPos = centro.position;

        p.spawnTime = data.time - travelTime;
        p.hitTime = data.time;
        p.travelTime = travelTime;
    }
}
