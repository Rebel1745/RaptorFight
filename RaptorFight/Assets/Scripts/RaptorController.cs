using System;
using System.Collections.Generic;
using UnityEngine;

public class RaptorController : MonoBehaviour
{
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

    private void OnEnable()
    {
        pc.Enable();
    }

    private void OnDisable()
    {
        pc.Disable();
    }
    
    internal Rigidbody rb;
    internal PlayerControls pc;
    Animator anim;

    [SerializeField] internal PlayerInputAttack playerInputAttack;
    [SerializeField] internal PlayerInputGroundSlam playerInputGroundSlam;
    [SerializeField] internal PlayerInputDash playerInputDash;
    [SerializeField] internal PlayerInputJump playerInputJump;
    [SerializeField] internal PlayerInputLeap playerInputLeap;
    [SerializeField] internal PlayerInputMove playerInputMove;
    [SerializeField] internal PlayerInputSprint playerInputSprint;
    //[SerializeField] internal PlayerInputFly playerInputFly;

    private string animState;
    internal string PLAYER_IDLE = "Player_Idle";
    internal string PLAYER_WALK = "Player_Walk";
    internal string PLAYER_SPRINT = "Player_Sprint";
    internal string PLAYER_JUMP = "Player_Jump";
    internal string PLAYER_LAND = "Player_Land";
    internal string PLAYER_SLASH_RIGHT = "Player_Slash_Right";
    internal string PLAYER_SLASH_LEFT = "Player_Slash_Left";
    internal string PLAYER_BITE_DOWN = "Player_Bite_Down";
    internal string PLAYER_BITE_FORWARD = "Player_Bite_Forward";
    internal string PLAYER_KICK = "Player_Kick";
    internal string PLAYER_TAIL_WHIP = "Player_Tail_Whip";

    [Header("Abilities")]
    public bool CanGroundSlam = false;
    public bool CanDash = true;
    public bool CanSprint = true;
    public bool CanFly = false;
    public bool CanJump = false;
    public bool CanAttackRight = true;
    public bool CanAttackLeft = true;
    public bool CanAttackTailWhip = true;
    public bool CanAttackKick = true;
    public bool CanAttackBiteForward = true;
    public bool CanAttackBiteDown = true;
    public bool CanLeap = true;
        
    [Space]
    [Header("Grounded")]
    internal bool isGrounded;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask WhatIsGround;
    public float GroundedRememberTime = 0.1f;
    internal float groundedRemember = 0;
    
    private void Update()
    {
        CheckGrounded();
    }

    void CheckGrounded()
    {
        // if we are on the ground, we can jump
        isGrounded = Physics.Raycast(GroundCheck.position, Vector3.down, CheckRadius, WhatIsGround);
        groundedRemember -= Time.deltaTime;
    }    
    
    public void ChangeAnimationState(string newState)
    {
        if (animState == newState)
            return;

        anim.Play(newState);

        animState = newState;
    }    

    public void Flip()
    {
        // Switch the way the player is labelled as facing.
        playerInputMove.isFacingRight = !playerInputMove.isFacingRight;

        transform.Rotate(0f, 180f, 0f);
    }

    // TODO: Move to utilities class so its available everywhere
    public Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }

    #region Debug
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, playerInputLeap.MaxLeapDistance);


        // duplicated code
        Vector3 dir = playerInputMove.isFacingRight ? Vector3.right : Vector3.left;

        Debug.DrawRay(GroundCheck.position, Vector3.down * CheckRadius, Color.green);
        Debug.DrawRay(playerInputAttack.AttackKickPoint.position, dir * playerInputAttack.AttackKickCheckLength, Color.red);
        Debug.DrawRay(playerInputAttack.AttackTailWhipPoint.position, dir * playerInputAttack.AttackTailWhipCheckLength, Color.red);
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