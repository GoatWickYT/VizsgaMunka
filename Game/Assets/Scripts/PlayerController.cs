using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    private Vector2 input;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("MoveX", input.x);
        animator.SetFloat("MoveY", input.y);

        var targetPos = transform.position;

        targetPos.x += input.x;
        targetPos.y += input.y;

        transform.position = Vector3.MoveTowards(transform.position, targetPos, MoveSpeed * Time.deltaTime);

    }
}
