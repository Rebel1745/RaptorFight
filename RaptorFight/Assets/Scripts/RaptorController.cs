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

        anim = GetComponentInChildren<Animator>();
        if (anim == null)
            Debug.LogError("Animator not found");

        pc = new PlayerControls();
    }

    private void Start()
    {
        currentSpeed = Speed;

        jumpsLeft = NumberOfJumps;
        dashesLeft = NumberOfDashes;
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
    Rigidbody rb;
    PlayerControls pc;
    Animator anim;

    [Header("Abilities")]
    public bool CanGroundSlam = false;
    public bool CanDash = false;
    public bool CanSprint = false;
    public bool CanFly = false;
    public bool CanMeleeAttack = false;

    [Space]
    [Header("Movement")]
    private bool canMove = true;
    public float Speed = 3f;
    public float SprintSpeed = 4f;
    float currentSpeed;
    Vector2 moveInput;
    bool isFacingRight = true;

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

    [Space]
    [Header("Ground Slam")]
    public float GroundSlamSpeed = 20f;
    public float PreSlamHoverTime = 1f;
    public float SlamMinHeight = 2f;
    bool isGroundSlam = false;

    [Space]
    [Header("Dashing")]
    bool isDashing = false;
    public float DashSpeed = 50f;
    public int NumberOfDashes = 1;
    int dashesLeft;
    public float DashDuration = 0.1f;

    [Space]
    [Header("Flying / gliding")]
    public float FlyUpForce = 0.5f; // low number for glide, high to fly
    public float FlyingCooldownTime = 0.1f;
    float flyingCooldown;

    [Space]
    [Header("Attacks")]
    bool meleeAttackAvailable = false;
    public float MeleeAttackCooldown = 1f;
    private float meleeAttackCooldown = 0f;
    #endregion

    #region Update Funtions
    private void FixedUpdate()
    {
        DoMovement();
    }

    private void Update()
    {
        DoJumping();
        DoDashing();
        DoFlying();
        CheckGroundSlam();
        UpdateAttack();
        moveInput = pc.Land.Movement.ReadValue<Vector2>().normalized;
    }
    #endregion

    #region Ground Slam
    void CheckGroundSlam()
    {
        if (isGrounded)
            isGroundSlam = false;

        if (!CanGroundSlam && isGroundSlam)
            return;
        

        if(!Physics.Raycast(GroundCheck.position, Vector3.down, out RaycastHit hit, SlamMinHeight, WhatIsGround) && pc.Land.Crouch.triggered)
        {
            isGroundSlam = true;
            // stay static 
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            Invoke("DoGroundSlam", PreSlamHoverTime);
        }
            
    }

    void DoGroundSlam()
    {
        rb.useGravity = true;
        rb.velocity = new Vector2(0f, Mathf.Abs(GroundSlamSpeed) * -1);
    }
    #endregion

    #region Flying
    void DoFlying()
    {
        if (flyingCooldown > 0)
            flyingCooldown -= Time.deltaTime;

        // check to see if we are falling
        if (CanFly && jumpsLeft == 0 && !isGrounded && rb.velocity.y < 0 && flyingCooldown <= 0)
        {
            if (pc.Land.Jump.triggered)
            {
                rb.velocity = new Vector2(rb.velocity.x, FlyUpForce);
                flyingCooldown = FlyingCooldownTime;
            }
        }
    }
    #endregion

    #region Dashing
    void DoDashing()
    {
        if (CanDash && dashesLeft > 0 && !isDashing && (pc.Land.DashLeft.triggered || pc.Land.DashRight.triggered))
        {
            isDashing = true;
            Vector2 dir;
            dir = pc.Land.DashRight.triggered ? Vector2.right : Vector2.left;
            rb.velocity = dir * DashSpeed;
            dashesLeft--;

            Invoke("StopDash", DashDuration);
        }
    }

    void StopDash()
    {
        isDashing = false;
        currentSpeed = Speed;
    }
    #endregion

    #region Jumping
    void DoJumping()
    {
        // if we are on the ground, we can jump
        isGrounded = Physics.Raycast(GroundCheck.position, Vector2.down, CheckRadius, WhatIsGround);
        groundedRemember -= Time.deltaTime;

        if (((groundedRemember > 0 && canJump) || jumpsLeft > 0) && pc.Land.Jump.triggered)
        {
            groundedRemember = 0;
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            canJump = false;
            jumpsLeft--;
            anim.SetBool("Jumping", true);
        }

        if (isGrounded)
        {
            // setting this allows us to be considered 'grounded' for a time after not being grounded. Coyote time!
            groundedRemember = GroundedRememberTime;
            jumpsLeft = NumberOfJumps;
            dashesLeft = NumberOfDashes;
        }

        if (pc.Land.Jump.ReadValue<float>() == 0)
        {
            if (!canJump)
                canJump = true;

            if(isGrounded)
                anim.SetBool("Jumping", false);
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
        if (!canMove || isDashing || isGroundSlam)
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

        rb.velocity = new Vector3(moveInput.x * currentSpeed, rb.velocity.y, moveInput.y * currentSpeed);
        if(isGrounded)
            anim.SetFloat("Speed", Mathf.Abs(moveInput.x + moveInput.y));
        else
            anim.SetFloat("Speed", 0);

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

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        isFacingRight = !isFacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
    #endregion

    #region Attacking
    void UpdateAttackCountdowns()
    {
        if (!meleeAttackAvailable)
            meleeAttackCooldown -= Time.deltaTime;

        if (meleeAttackCooldown <= 0f)
            meleeAttackAvailable = true;
    }

    void UpdateAttack()
    {
        UpdateAttackCountdowns();

        if (CanMeleeAttack && meleeAttackAvailable && pc.Land.MeleeAttack.ReadValue<float>() > 0.1f)
        {
            // melee attack with the hand facing the screen
            if(isFacingRight)
                anim.SetTrigger("AttackMeleeRight");
            else
                anim.SetTrigger("AttackMeleeLeft");

            meleeAttackAvailable = false;
            meleeAttackCooldown = MeleeAttackCooldown;
        }
    }

    #endregion
}