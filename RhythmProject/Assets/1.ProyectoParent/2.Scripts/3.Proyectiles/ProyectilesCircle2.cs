using UnityEngine;

public class ProyectilesCircle2 : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 targetPos;

    public float spawnTime;
    public float hitTime;
    public float travelTime;

    void Update()
    {
        float songTime = Conductor.instance.songPosition;

        float t = (songTime - spawnTime) / travelTime;

        transform.position = Vector3.Lerp(startPos, targetPos, t);

        if (t > 1.2f)
        {
            Destroy(gameObject);
        }
    }
}
