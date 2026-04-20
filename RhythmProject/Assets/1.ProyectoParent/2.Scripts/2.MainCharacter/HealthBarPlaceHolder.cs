using UnityEngine;

public class HealthBarPlaceHolder : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private PauseWinDefeatManager defeatManager;
    private int numberOfHearts = 4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Proyectil"))
        {
            hearts[numberOfHearts].SetActive(false);

            if (numberOfHearts <= 0)
            {
                numberOfHearts = 0;
                defeatManager.OpenDefeatPanel();
            }

            numberOfHearts--;
        }
    }
}
