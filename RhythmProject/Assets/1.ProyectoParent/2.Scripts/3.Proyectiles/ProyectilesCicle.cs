using UnityEngine;

public class ProyectilesCicle : MonoBehaviour
{
    [SerializeField] private GameObject textoMas1;
    [SerializeField] private SpriteRenderer proyectileSprite;
    [SerializeField] private CircleCollider2D circleCollider;

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
            circleCollider.enabled = false;
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

        if (winDefeatManager.Aciertos >= 250)
            winDefeatManager.OpenWinPanel();
    }
}
