using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    // public float JumpForce = 60f;
    //  private bool isJump;
    // private float moveVertical;

    //float fixedDeltaTime = 0;

    bool iswalking = false;
    bool isgrounded = false;

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
       // iswalking = IsWalking();
    }

    public void MovementUpdate(Vector2 playerInput)
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity += 0.1f * Vector2.left;

          // return FacingDirection.left;

            iswalking = true;
            Debug.Log("Moving");
        }
       

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity += 0.1f * Vector2.right;
            iswalking = true;
            Debug.Log("Moving");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            iswalking = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            iswalking = false;
            Debug.Log("Stopmoving");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            iswalking = false;
            Debug.Log("Stopmoving");
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
        return iswalking;
    }
    public bool IsGrounded()
    {
        return isgrounded;
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
