using UnityEngine;

public class PlaceHolderChar : MonoBehaviour
{
    [SerializeField] private GameObject swordCollider;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ClickDerecho()
    {
        animator.SetTrigger("Attack");
        transform.localScale = new Vector3(1f,1f,1f);
    }

    public void ClicIzquierdo()
    {
        animator.SetTrigger("Attack");
        transform.localScale = new Vector3(-1f, 1f, 1f);
    }

    private void ActiveSwordCollider()
    {
        swordCollider.SetActive(true);
    }

    private void DeactiveSwordCollider()
    {
        swordCollider.SetActive(false);
    }
}
