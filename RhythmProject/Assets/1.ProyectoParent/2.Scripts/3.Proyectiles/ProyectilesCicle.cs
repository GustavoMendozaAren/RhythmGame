using UnityEngine;

public class ProyectilesCicle : MonoBehaviour
{
    [SerializeField] private GameObject textoMas1;
    [SerializeField] private SpriteRenderer proyectileSprite;

    private float velocidad = 5f;
    private PauseWinDefeatManager winDefeatManager;
    private bool isHit = false;

    [HideInInspector] public Vector2 direccion;

    void Update()
    {
        if (!isHit)
            transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            isHit = true;

            WinDefeatAciertos();

            textoMas1.SetActive(true);
            proyectileSprite.enabled = false;
            Destroy(gameObject, 1f);
        }

        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void WinDefeatAciertos()
    {
        winDefeatManager = FindFirstObjectByType<PauseWinDefeatManager>();

        winDefeatManager.Aciertos++;
        winDefeatManager.AddScoreToText();

        if (winDefeatManager.Aciertos >= 10)
            winDefeatManager.OpenWinPanel();
    }
}
