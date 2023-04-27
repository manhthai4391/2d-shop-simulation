using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    IAnimationBase anim;

    [SerializeField]
    float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<IAnimationBase>();
    }


    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 direction = horizontal * Vector2.right + vertical * Vector2.up;
        rb.MovePosition((Vector2)transform.position + speed * Time.fixedDeltaTime * direction);
        anim.Move(direction);
    }
}
