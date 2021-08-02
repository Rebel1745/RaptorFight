using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] internal Enemy enemy;

    public int MaxHealth = 5;
    int health = 0;

    void Start()
    {
        ChangeHealth(MaxHealth);
    }

    public void ChangeHealth(int amount)
    {
        health += amount;

        CheckHealth();
    }

    void CheckHealth()
    {
        switch (health)
        {
            case 1:
                enemy.ChangeState(Enemy.ENEMY_STATE.Vulnerable);
                break;
            case 0:
                Die();
                break;
            default:
                enemy.ChangeState(Enemy.ENEMY_STATE.Alive);
                break;
        }
    }

    void Die()
    {
        enemy.ChangeState(Enemy.ENEMY_STATE.Dead);
        enemy.rb.useGravity = false;
        GetComponent<Collider>().enabled = false;
    }
}
