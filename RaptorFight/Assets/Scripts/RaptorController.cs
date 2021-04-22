using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaptorController : MonoBehaviour
{
    #region Startup
    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody>();

        if (rb == null)
            Debug.LogError("No RigidBody found");

        pc = new PlayerControls();
    }

    private void Start()
    {
    }

    private void OnEnable()
    {
        pc.Enable();
    }

    private void OnDisable()
    {
        pc.Disable();
    }
    #endregion

    #region Variables
    [HideInInspector]
    Rigidbody rb;
    PlayerControls pc;

    [Header("Movement")]
    Vector2 moveInput;
    bool isFacingRight = true;
    bool canMove = true;
    public bool CanSprint = false;

    public float Speed = 5f;
    public float SprintSpeed = 10f;
    float currentSpeed = 0f;

    [Space]
    [Header("Jumping")]
    public float JumpForce = 5f;
    private bool canJump = true;
    public int NumberOfJumps = 2;
    public int jumpsLeft;
    public float FallMultiplier = 2.5f;
    public float LowJumpMultiplier = 2f;
    bool isGrounded;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask WhatIsGround;
    public float GroundedRememberTime = 0.1f;
    float groundedRemember = 0;
    float startGravityScale;
    #endregion

    // Update is called once per frame
    void Update()
    {
        moveInput = pc.Land.Movement.ReadValue<Vector2>().normalized;
        DoJumping();
    }

    private void FixedUpdate()
    {
        DoMovement();
    }

    #region Jumping
    void DoJumping()
    {
        // if we are on the ground, we can jump
        if (Physics.Raycast(GroundCheck.position, Vector2.down, CheckRadius, WhatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        groundedRemember -= Time.deltaTime;

        if (isGrounded)
        {
            // setting this allows us to be considered 'grounded' for a time after not being grounded. Coyote time!
            groundedRemember = GroundedRememberTime;
        }

        if (isGrounded)
        {
            jumpsLeft = NumberOfJumps;
        }

        if (((groundedRemember > 0 && canJump) || jumpsLeft > 0) && pc.Land.Jump.triggered)
        {
            groundedRemember = 0;
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            canJump = false;
            jumpsLeft--;
        }

        if (pc.Land.Jump.ReadValue<float>() == 0)
        {
            if (!canJump)
                canJump = true;
        }

        // if jumping or falling, alter gravity to allow for medium and large jumps
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * FallMultiplier * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && pc.Land.Jump.ReadValue<float>() == 0f)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * LowJumpMultiplier * Time.deltaTime;
        }
    }
    #endregion

    #region Movement
    void DoMovement()
    {
        if (!canMove)
            return;

        //check if sprinting and change current speed
        if (CanSprint && pc.Land.Sprint.ReadValue<float>() > 0)
        {
            currentSpeed = SprintSpeed;
        }
        else
        {
            currentSpeed = Speed;
        }

        // the Z component of the Vector is set as Y as the control input is sent through as a Vector2
        //so instead of setting the Y value (up/down) we have to set the Z (towards/away)
        rb.velocity = new Vector3(moveInput.x * currentSpeed, rb.velocity.y, moveInput.y * currentSpeed);

        #region Flipping
        // If the input is moving the player right and the player is facing left...
        if (rb.velocity.x > 0 && !isFacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (rb.velocity.x < 0 && isFacingRight)
        {
            // ... flip the player.
            Flip();
        }
        #endregion
    }

    IEnumerator DisableMovement(float time)
    {
        canMove = false;
        yield return new WaitForSeconds(time);
        canMove = true;
    }
    #endregion

    #region Flip Function
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        isFacingRight = !isFacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
    #endregion
}
