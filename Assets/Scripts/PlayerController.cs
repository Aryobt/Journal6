using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce = 150f;
    

   //float fixedDeltaTime = 0;

    public float acceleration;
    public enum FacingDirection
    {
        left, right
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
     

      Vector2 playerInput = new Vector2();
        MovementUpdate(playerInput);
    }

    public void MovementUpdate(Vector2 playerInput)
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity += 0.1f * Vector2.left;
           
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity += 0.1f * Vector2.right;
        }
    }

    public void PlayerJump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           // rb.AddForceAtPosition(FacingDirection * JumpForce, acceleration, ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
        //float fixedDeltaTime = Time.fixedDeltaTime;


    }

    public bool IsWalking()
    {
        return true;
    }
    public bool IsGrounded()
    {
        return true;
    }

    public FacingDirection GetFacingDirection()
    {
        return FacingDirection.left;
//return FacingDirection.right;
    }
}
