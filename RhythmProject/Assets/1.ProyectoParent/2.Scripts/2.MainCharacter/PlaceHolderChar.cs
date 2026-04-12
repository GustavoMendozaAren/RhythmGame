using UnityEngine;

public class PlaceHolderChar : MonoBehaviour
{
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
        spriteRenderer.flipX = false;
    }

    public void ClicIzquierdo()
    {
        animator.SetTrigger("Attack");
        spriteRenderer.flipX = true;
    }
}
