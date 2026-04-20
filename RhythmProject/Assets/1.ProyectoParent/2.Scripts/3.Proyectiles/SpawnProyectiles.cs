using UnityEngine;

public class SpawnProyectiles : MonoBehaviour
{
    [SerializeField] private GameObject proyectilPrefab;

    [SerializeField] private Transform spawnIzquierdo;
    [SerializeField] private Transform spawnDerecho;

    private bool isSpawnRigth = true;

    //private void Start()
    //{
    //    InvokeRepeating("SpawnProyectilRight", 0f, tiempoEntreSpawns);
    //    InvokeRepeating("SpawnProyectilLeft", 0.5f, tiempoEntreSpawns);
    //}

    public void SpawnProyectile()
    {
        if (isSpawnRigth)
        {
            SpawnProyectilRight();
            isSpawnRigth = false;
        }
        else
        {
            SpawnProyectilLeft();
            isSpawnRigth = true;
        }
    }

    private void SpawnProyectilRight()
    {             
        GameObject der = Instantiate(proyectilPrefab, spawnDerecho.position, Quaternion.identity);
        der.GetComponent<ProyectilesCicle>().direccion = Vector2.left;
    }

    private void SpawnProyectilLeft()
    {
        GameObject izq = Instantiate(proyectilPrefab, spawnIzquierdo.position, Quaternion.identity);
        izq.GetComponent<ProyectilesCicle>().direccion = Vector2.right;
    }
}
