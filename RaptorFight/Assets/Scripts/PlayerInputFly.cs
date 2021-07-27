using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputFly : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Flying / gliding")]
    public float FlyUpForce = 0.5f; // low number for glide, high to fly
    public float FlyingCooldownTime = 0.1f;
    float flyingCooldown;

    public void Fly()
    {
        if (flyingCooldown > 0)
            flyingCooldown -= Time.deltaTime;

        // check to see if we are falling
        if (raptorController.CanFly && raptorController.playerInputJump.jumpsLeft == 0 && !raptorController.isGrounded && raptorController.rb.velocity.y < 0 && flyingCooldown <= 0)
        {
            raptorController.rb.velocity = new Vector2(raptorController.rb.velocity.x, FlyUpForce);
            flyingCooldown = FlyingCooldownTime;
        }
    }
}
