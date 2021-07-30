using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public enum ENEMY_STATE { Alive, Floored, Dead }
    public ENEMY_STATE EnemyState = ENEMY_STATE.Alive;

    public Material FlooredMat;
    public Material DeadMat;

    private Renderer enemyMat;

    [SerializeField] internal Rigidbody rb;
    [SerializeField] internal EnemyKnockback enemyKnockback;
    [SerializeField] internal EnemyKnockup enemyKnockup;

    public float KnockMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // just for testing purposes
        EnemyState = ENEMY_STATE.Floored;
        enemyMat = GetComponent<Renderer>();
        enemyMat.sharedMaterial = FlooredMat;
    }

    public void ChangeState(ENEMY_STATE e)
    {
        EnemyState = e;

        switch (e)
        {
            case ENEMY_STATE.Floored:
                enemyMat.sharedMaterial = FlooredMat;
                break;
            case ENEMY_STATE.Dead:
                enemyMat.sharedMaterial = DeadMat;
                break;
        }

        if(e == ENEMY_STATE.Dead)
            StartCoroutine(ChangeStateAfterTime(7.0f));
    }

    IEnumerator ChangeStateAfterTime(float t)
    {
        yield return new WaitForSeconds(t);

        ChangeState(ENEMY_STATE.Floored);
    }
}
