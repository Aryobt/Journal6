using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
     public float JumpForce = 20f;
    public LayerMask GroundLayer;
    public BoxCollider2D GroundCollider;

    public float terminalSpeed = 2f;//

    bool terminalVelocity = false;//
    //  private bool isJump;
    // private float moveVertical;

    //float fixedDeltaTime = 0;

    bool iswalking = false;
    bool isgrounded = false;

    public float acceleration = 1f;//
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
       falling(playerInput);
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
            iswalking = false;
            Debug.Log("Stopmoving");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            iswalking = false;
            Debug.Log("Stopmoving");
        }

       // if (terminalSpeed / acceleration)//
       // {
        //    terminalVelocity = true;
        //}

    }
    public void falling(Vector2 playerInput)
    {
        if (rb.linearVelocity.x < -2.5 && rb.linearVelocity.x > -3.6)
        {
            isgrounded = true;
            Debug.Log("Fall");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            isgrounded = false;
            Debug.Log("Jump");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isgrounded = true;
            Debug.Log("Jump");
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

     public void OnTriggerEnter2D(Collider2D other)
    {
      if (GroundLayer == (1 << other .gameObject.layer))
     {
          isgrounded = false;
       }

}
}
