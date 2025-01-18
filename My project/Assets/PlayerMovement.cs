<<<<<<< Updated upstream
using System.Collections;
=======
>>>>>>> Stashed changes
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

<<<<<<< Updated upstream
<<<<<<< Updated upstream:My project/Assets/Scripts/Mechanics/PlayerMovement.cs
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;

    private void Update()
    {
        if (isDashing)
=======
=======
>>>>>>> Stashed changes
    private bool doubleJump;

    private bool canDash = true;
    private bool isDashing;
    public float dashingPower = 24f;
    public float dashingTime = 0.2f; 
    public float dashingCooldown = 1f;



    private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr; 


    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    

    void Update()
    {


        horizontal = Input.GetAxisRaw("Horizontal");

        if (IsGrounded() && !Input.GetButton("Jump")) 
<<<<<<< Updated upstream
>>>>>>> Stashed changes:My project/Assets/PlayerMovement.cs
        {
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
=======
        {
            doubleJump = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if(IsGrounded() || doubleJump)
            {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);

            doubleJump = !doubleJump;
            }
>>>>>>> Stashed changes
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream:My project/Assets/Scripts/Mechanics/PlayerMovement.cs
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
=======
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash && !isDashing)
        {
            StartCoroutine(Dash()); 
>>>>>>> Stashed changes:My project/Assets/PlayerMovement.cs
=======
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash && !isDashing)
        {
            StartCoroutine(Dash()); 
>>>>>>> Stashed changes
        }

        Flip();
    }

    private void FixedUpdate()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream:My project/Assets/Scripts/Mechanics/PlayerMovement.cs
        if (isDashing)
        {
            return;
        }
=======
>>>>>>> Stashed changes:My project/Assets/PlayerMovement.cs
=======
>>>>>>> Stashed changes

        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
<<<<<<< Updated upstream
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
=======
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
>>>>>>> Stashed changes
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.linearVelocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
<<<<<<< Updated upstream
<<<<<<< Updated upstream:My project/Assets/Scripts/Mechanics/PlayerMovement.cs
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
=======
=======
>>>>>>> Stashed changes
        isDashing = false; 
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true; 
    }







<<<<<<< Updated upstream
>>>>>>> Stashed changes:My project/Assets/PlayerMovement.cs
=======
>>>>>>> Stashed changes
}