using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

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

    private void MovementUpdate(Vector2 playerInput)
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

    private void FixedUpdate()
    {
        //float fixedDeltaTime = Time.fixedDeltaTime;


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
    }
}
