using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputGroundSlam : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Ground Slam")]
    public float GroundSlamSpeed = 20f;
    public float PreSlamHoverTime = 1f;
    public float SlamMinHeight = 2f;
    public bool isGroundSlam = false;
    
    void Update()
    {
        // TODO: make Grounded chack a function in the raptor controller which will change the isGroundSlam flag to false
        CheckGroundSlam();
    }

    public void AttackGroundSlam(InputAction.CallbackContext context)
    {
        if(context.performed && raptorController.CanGroundSlam && !isGroundSlam)
        {
            if(!Physics.Raycast(raptorController.GroundCheck.position, Vector3.down, out RaycastHit hit, SlamMinHeight, raptorController.WhatIsGround))
        {
                isGroundSlam = true;
                raptorController.ChangeAnimationState(raptorController.PLAYER_JUMP);
                // stay static 
                raptorController.rb.useGravity = false;
                raptorController.rb.velocity = Vector3.zero;

                // disable movement
                raptorController.playerInputMove.DisableMovement();
                Invoke("DoGroundSlam", PreSlamHoverTime);
            }
        }
    }

    void CheckGroundSlam()
    {
        if (raptorController.isGrounded) {
            isGroundSlam = false;
            // re-enable movement now we have finished
            raptorController.playerInputMove.EnableMovement();
        }
    }

    void DoGroundSlam()
    {
        raptorController.ChangeAnimationState(raptorController.PLAYER_LAND);
        raptorController.rb.useGravity = true;
        raptorController.rb.velocity = new Vector2(0f, Mathf.Abs(GroundSlamSpeed) * -1);
    }
}
