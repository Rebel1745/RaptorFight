using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputMove : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Movement")]
    private bool canMove = true;
    public float WalkSpeed = 3f;
    internal float currentSpeed;
    Vector2 moveInput;
    internal bool isFacingRight = true;

    private void Start()
    {
        currentSpeed = WalkSpeed;
    }

    private void Update()
    {
        DoMovement();
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void DoMovement()
    {
        if (!canMove)
            return;

        raptorController.rb.velocity = new Vector3(moveInput.x * currentSpeed, raptorController.rb.velocity.y, moveInput.y * currentSpeed);
        if (raptorController.isGrounded && !raptorController.playerInputJump.isJumping && !raptorController.playerInputAttack.isAttacking)
        {
            if (Mathf.Abs(moveInput.x) + Mathf.Abs(moveInput.y) > 0)
                raptorController.ChangeAnimationState(raptorController.PLAYER_WALK);
            else
                raptorController.ChangeAnimationState(raptorController.PLAYER_IDLE);
        }

        // If the input is moving the player right and the player is facing left...
        if (raptorController.rb.velocity.x > 0 && !isFacingRight)
        {
            // ... flip the player.
            raptorController.Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (raptorController.rb.velocity.x < 0 && isFacingRight)
        {
            // ... flip the player.
            raptorController.Flip();
        }
    }

    public IEnumerator DisableMovementForTime(float time)
    {
        DisableMovement();
        yield return new WaitForSeconds(time);
        EnableMovement();
    }

    public void DisableMovement()
    {
        canMove = false;
    }

    public void EnableMovement()
    {
        canMove = true;
    }
}
