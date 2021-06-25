using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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

        leapTargets = new List<GameObject>();
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
    public bool CanLeap = false;

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
    [Header("Leaping")]
    private bool canLeap = true;
    private bool isLeaping = false;
    public float LeapHeight = 5f;
    public float LeapDuration = 2f;
    public float MaxLeapDistance = 10f;
    private float currentLeapTime = 0f;
    private Vector3 leapStartPos = Vector3.zero;
    private Vector3 leapEndPos = Vector3.zero;
    private List<GameObject> leapTargets;
    public LayerMask WhatIsEnemy;

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
        DoLeaping();
        DoDashing();
        DoFlying();
        CheckGroundSlam();
        UpdateAttack();
        moveInput = pc.GameControls.Movement.ReadValue<Vector2>().normalized;
    }
    #endregion

    #region Ground Slam
    void CheckGroundSlam()
    {
        if (isGrounded)
            isGroundSlam = false;

        if (!CanGroundSlam && isGroundSlam)
            return;
        

        if(!Physics.Raycast(GroundCheck.position, Vector3.down, out RaycastHit hit, SlamMinHeight, WhatIsGround) && pc.GameControls.GroundSlam.triggered)
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
            if (pc.GameControls.Jump.triggered)
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
        if (CanDash && dashesLeft > 0 && !isDashing && (pc.GameControls.DashLeft.triggered || pc.GameControls.DashRight.triggered))
        {
            isDashing = true;
            Vector2 dir;
            dir = pc.GameControls.DashRight.triggered ? Vector2.right : Vector2.left;
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

        if (((groundedRemember > 0 && canJump) || jumpsLeft > 0) && pc.GameControls.Jump.triggered)
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

        if (pc.GameControls.Jump.ReadValue<float>() == 0)
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
        else if (rb.velocity.y > 0 && pc.GameControls.Jump.ReadValue<float>() == 0f)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * LowJumpMultiplier * Time.deltaTime;
        }
    }
    #endregion

    #region Leaping
    void DoLeaping()
    {
        if (isLeaping)
        {
            currentLeapTime += Time.deltaTime;

            currentLeapTime = currentLeapTime % LeapDuration;

            transform.position = Parabola(leapStartPos, leapEndPos, LeapHeight, currentLeapTime / LeapDuration);

            if((LeapDuration - currentLeapTime) <= 0.05f)
            {
                isLeaping = false;
                canLeap = true;
            }
        }
        else
        {
            if (CanLeap && canLeap && pc.GameControls.Leap.triggered)
            {
                GameObject leapTarget = null;
                float leapTargetDistance = Mathf.Infinity;
                // we want to start leaping
                // clear previous targets
                leapTargets.Clear();
                // find possible leap targets
                Collider[] targets = Physics.OverlapSphere(transform.position, MaxLeapDistance, WhatIsEnemy);
                foreach(Collider c in targets)
                {
                    if(c.GetComponent<Enemy>().EnemyState == Enemy.ENEMY_STATE.Floored)
                    {
                        leapTargets.Add(c.gameObject);
                    }
                }

                if(leapTargets.Count > 0)
                {
                    foreach(GameObject g in leapTargets)
                    {
                        if (leapTarget == null || Math.Abs(Vector3.Distance(g.transform.position, leapTarget.transform.position)) > leapTargetDistance)
                        {
                            leapTarget = g;
                            leapTargetDistance = Math.Abs(Vector3.Distance(g.transform.position, leapTarget.transform.position));
                        }
                    }

                    currentLeapTime = 0;
                    isLeaping = true;
                    canLeap = false;

                    leapStartPos = transform.position;
                    leapEndPos = leapTarget.transform.position;

                    leapTarget.GetComponent<Enemy>().ChangeState(Enemy.ENEMY_STATE.Dead);
                }
                else
                {
                    Debug.Log("No leap target");
                }
            }
        }
    }

    public static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }
    #endregion

    #region Movement
    void DoMovement()
    {
        if (!canMove || isDashing || isGroundSlam)
            return;

        //check if sprinting and change current speed
        if (CanSprint && pc.GameControls.Sprint.ReadValue<float>() > 0)
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

        if (CanMeleeAttack && meleeAttackAvailable && pc.GameControls.MeleeAttack.ReadValue<float>() > 0.1f)
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

    #region Debug
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, MaxLeapDistance);
    }

    void PrintList(List<GameObject> l)
    {
        if(l.Count > 0)
        {
            foreach(GameObject g in l)
            {
                Debug.Log(g.transform.name);
            }
        }
        else
        {
            Debug.Log("Empty list");
        }
    }
    #endregion
}