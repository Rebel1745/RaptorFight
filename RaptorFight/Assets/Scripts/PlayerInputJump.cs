using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputJump : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Jumping")]
    public float JumpForce = 5f;
    private bool canJump = true;
    internal bool isJumping = false;
    public int NumberOfJumps = 2;
    public int jumpsLeft;
    public float FallMultiplier = 2.5f;
    public float LowJumpMultiplier = 2f;

    void Start()
    {
        jumpsLeft = NumberOfJumps;
    }
    
    void Update()
    {
        CheckJumping();
    }

    public void Jump()
    {
        if (raptorController.CanJump && ((raptorController.groundedRemember > 0 && canJump) || jumpsLeft > 0))
        {
            isJumping = true;
            raptorController.groundedRemember = 0;
            raptorController.rb.velocity = new Vector3(raptorController.rb.velocity.x, JumpForce, raptorController.rb.velocity.z);
            canJump = false;
            jumpsLeft--;
            raptorController.ChangeAnimationState(raptorController.PLAYER_JUMP);
        }        
    }

    void CheckJumping()
    {
        if (raptorController.isGrounded)
        {
            // setting this allows us to be considered 'grounded' for a time after not being grounded. Coyote time!
            raptorController.groundedRemember = raptorController.GroundedRememberTime;
            jumpsLeft = NumberOfJumps;
        }

        if (raptorController.pc.GameControls.Jump.ReadValue<float>() == 0)
        {
            if (!canJump)
                canJump = true;

            if (raptorController.isGrounded)
                isJumping = false;
        }

        // if jumping or falling, alter gravity to allow for medium and large jumps
        if (isJumping && raptorController.rb.velocity.y < 0)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_LAND);
            raptorController.rb.velocity += Vector3.up * Physics.gravity.y * FallMultiplier * Time.deltaTime;
        }
        else if (raptorController.rb.velocity.y > 0 && raptorController.pc.GameControls.Jump.ReadValue<float>() == 0f)
        {
            raptorController.rb.velocity += Vector3.up * Physics.gravity.y * LowJumpMultiplier * Time.deltaTime;
        }
    }
}
