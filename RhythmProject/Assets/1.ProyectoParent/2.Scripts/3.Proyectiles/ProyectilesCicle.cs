using UnityEngine;

public class ProyectilesCicle : MonoBehaviour
{
    private PauseWinDefeatManager winDefeat;
    private float velocidad = 5f;
    [HideInInspector] public Vector2 direccion;

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            winDefeat = FindFirstObjectByType<PauseWinDefeatManager>();
            winDefeat.OpenDefeatPanel();
        }
    }
}
