using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    // public float JumpForce = 60f;
    //  private bool isJump;
    // private float moveVertical;

    //float fixedDeltaTime = 0;

    public float acceleration;
    public enum FacingDirection
    {
        left, right
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //  isJump = false;
    }

    void Update()
    {
        Vector2 playerInput = new Vector2();
        MovementUpdate(playerInput);
        // moveVertical = Input.GetAxisRaw("Vertical");
    }

    public void MovementUpdate(Vector2 playerInput)
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity += 0.1f * Vector2.left;

          // return FacingDirection.left;

         //  return IsWalking = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity += 0.1f * Vector2.right;
           // IsWalking = true;
        }
    }
    private void FixedUpdate()
    {

        // if (!isJump && Input.GetKey(KeyCode.Space))
        // {
        //     rb.AddForce(new Vector2(0f, moveVertical * JumpForce), ForceMode2D.Impulse);
        // }

    }

    public bool IsWalking()
    {
        return false;
    }
    public bool IsGrounded()
    {
        return false;
    }

    public FacingDirection GetFacingDirection()
    {


        return FacingDirection.left;
        //return FacingDirection.right;
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    //{
    //   if ((collision.gameObject.tag == "Platform"))
    //   {
    //       isJump = false;
    //   }

//}
}
