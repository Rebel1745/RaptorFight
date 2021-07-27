using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputDash : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Dashing")]
    internal bool isDashing = false;
    public float DashSpeed = 50f;
    public int NumberOfDashes = 1;
    int dashesLeft;
    public float DashDuration = 0.1f;

    private void Start()
    {
        dashesLeft = NumberOfDashes;
    }

    private void Update()
    {
        // TODO: Get this in some grounded check function
        CheckDashing();
    }

    public void Dash()
    {
        if (raptorController.CanDash && dashesLeft > 0 && !isDashing)
        {
            isDashing = true;
            Vector2 dir;
            dir = raptorController.playerInputMove.isFacingRight ? Vector2.right : Vector2.left;
            raptorController.rb.velocity = dir * DashSpeed;
            dashesLeft--;

            Invoke("StopDash", DashDuration);
        }
    }

    void StopDash()
    {
        isDashing = false;
        raptorController.playerInputMove.currentSpeed = raptorController.playerInputMove.WalkSpeed;
    }

    void CheckDashing()
    {
        if(raptorController.isGrounded)
            dashesLeft = NumberOfDashes;
    }
}
