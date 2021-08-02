using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputAttack : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Attacks")]
    public bool isAttacking = false;
    public LayerMask WhatIsEnemy;
    bool attackRightAvailable = false;
    public float AttackRightCooldown = 1f;
    float attackRightCooldown = 0f;
    float attackRightLength = 0.3f;
    bool attackLeftAvailable = false;
    public float AttackLeftCooldown = 1f;
    float attackLeftCooldown = 0f;
    float attackLeftLength = 0.3f;
    bool attackTailWhipAvailable = false;
    public float AttackTailWhipCooldown = 1f;
    float attackTailWhipCooldown = 0f;
    float attackTailWhipLength = 0.3f;
    public Transform AttackTailWhipPoint;
    public float AttackTailWhipCheckLength = 1f; // length of ray that checks for enemy in front of knockup point
    public float AttackTailWhipDistance = 3f; // default distance knock enemy back and up
    bool attackKickAvailable = false;
    public float AttackKickCooldown = 1f;
    float attackKickCooldown = 0f;
    float attackKickLength = 0.3f;
    public Transform AttackKickPoint;
    public float AttackKickCheckLength = 0.1f; // length of ray that checks for enemy in front of kick point
    public float AttackKickDistance = 5f; // default distance to kick enemy back
    bool attackBiteForwardAvailable = false;
    public float AttackBiteForwardCooldown = 1f;
    float attackBiteForwardCooldown = 0f;
    float attackBiteForwardLength = 0.3f;
    bool attackBiteDownAvailable = false;
    public float AttackBiteDownCooldown = 1f;
    float attackBiteDownCooldown = 0f;
    float attackBiteDownLength = 0.3f;

    void Update()
    {
        UpdateAttackCountdowns();
    }

    #region Attacking
    void UpdateAttackCountdowns()
    {
        if (!attackRightAvailable)
            attackRightCooldown -= Time.deltaTime;

        if (attackRightCooldown <= 0f)
            attackRightAvailable = true;

        if (!attackLeftAvailable)
            attackLeftCooldown -= Time.deltaTime;

        if (attackLeftCooldown <= 0f)
            attackLeftAvailable = true;

        if (!attackTailWhipAvailable)
            attackTailWhipCooldown -= Time.deltaTime;

        if (attackTailWhipCooldown <= 0f)
            attackTailWhipAvailable = true;

        if (!attackKickAvailable)
            attackKickCooldown -= Time.deltaTime;

        if (attackKickCooldown <= 0f)
            attackKickAvailable = true;

        if (!attackBiteForwardAvailable)
            attackBiteForwardCooldown -= Time.deltaTime;

        if (attackBiteForwardCooldown <= 0f)
            attackBiteForwardAvailable = true;

        if (!attackBiteDownAvailable)
            attackBiteDownCooldown -= Time.deltaTime;

        if (attackBiteDownCooldown <= 0f)
            attackBiteDownAvailable = true;
    }

    public void AttackLeft(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackLeft && attackLeftAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_SLASH_LEFT);
            isAttacking = true;
            attackLeftAvailable = false;
            Invoke("StopAttacking", attackLeftLength);
            attackLeftCooldown = AttackLeftCooldown;
        }
    }

    public void AttackRight(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackRight && attackRightAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_SLASH_RIGHT);
            isAttacking = true;
            attackRightAvailable = false;
            Invoke("StopAttacking", attackRightLength);
            attackRightCooldown = AttackRightCooldown;
        }
    }

    public void AttackTailWhip(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackTailWhip && attackTailWhipAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_TAIL_WHIP);
            isAttacking = true;
            Invoke("StopAttacking", attackTailWhipLength);
            attackTailWhipAvailable = false;
            attackTailWhipCooldown = AttackTailWhipCooldown;

            // duplicated code
            Vector3 dir = raptorController.playerInputMove.isFacingRight ? Vector3.right : Vector3.left;

            // check for enemy and knock it up
            if (Physics.Raycast(AttackTailWhipPoint.position, dir, out RaycastHit hit, AttackTailWhipCheckLength, WhatIsEnemy))
            {
                hit.transform.GetComponent<EnemyKnockup>().Knockup(dir * AttackTailWhipDistance);
            }
        }
    }

    public void AttackKick(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackKick && attackKickAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_KICK);
            isAttacking = true;
            Invoke("StopAttacking", attackKickLength);
            attackKickAvailable = false;
            attackKickCooldown = AttackKickCooldown;

            // duplicated code
            Vector3 dir = raptorController.playerInputMove.isFacingRight ? Vector3.right : Vector3.left;

            // check for enemy and kick it
            if (Physics.Raycast(AttackKickPoint.position, dir, out RaycastHit hit, AttackKickCheckLength, WhatIsEnemy))
            {
                hit.transform.GetComponent<EnemyKnockback>().Knockback(dir);
            }
        }
    }

    public void AttackBiteForward(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackBiteForward && attackBiteForwardAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_BITE_FORWARD);
            isAttacking = true;
            Invoke("StopAttacking", attackBiteForwardLength);
            attackBiteForwardAvailable = false;
            attackBiteForwardCooldown = AttackBiteForwardCooldown;
        }
    }

    public void AttackBiteDown(InputAction.CallbackContext context)
    {
        if (context.performed && raptorController.isGrounded && raptorController.CanAttackBiteDown && attackBiteDownAvailable)
        {
            raptorController.ChangeAnimationState(raptorController.PLAYER_BITE_DOWN);
            isAttacking = true;
            Invoke("StopAttacking", attackBiteDownLength);
            attackBiteDownAvailable = false;
            attackBiteDownCooldown = AttackBiteDownCooldown;
        }
    }

    void StopAttacking()
    {
        isAttacking = false;
    }

    #endregion
}
