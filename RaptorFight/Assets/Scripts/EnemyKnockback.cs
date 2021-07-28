using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockback : MonoBehaviour
{
    [SerializeField] internal Enemy enemy;

    public float KnockbackMultiplier = 1.0f;
    public float KnockbackSpeed = 50f;
    public float KnockbackDuration = 0.1f;

    public void Knockback(Vector3 dir)
    {
        enemy.rb.velocity = dir * KnockbackSpeed;

        Invoke("StopKnockback", KnockbackDuration);
    }

    void StopKnockback()
    {
        //stops the enemy, set to movement speed when enemies are able to move
        enemy.rb.velocity = Vector3.zero;
    }
}
