using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputLeap : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    [Header("Leaping")]
    private bool canLeap = true;
    private bool isLeaping = false;
    public float LeapHeight = 5f;
    public float LeapDuration = 2f;
    public float MaxLeapDistance = 10f;
    private float currentLeapTime = 0f;
    private Vector3 leapStartPos = Vector3.zero;
    private Vector3 leapEndPos = Vector3.zero;
    private List<GameObject> leapTargets;

    void Start()
    {
        leapTargets = new List<GameObject>();
    }

    private void Update()
    {
        CheckLeaping();
    }

    public void Leap()
    {
        
        if (!isLeaping && raptorController.CanLeap && canLeap)
        {
            GameObject leapTarget = null;
            float leapTargetDistance = Mathf.Infinity;
            // we want to start leaping
            // clear previous targets
            leapTargets.Clear();
            // find possible leap targets
            Collider[] targets = Physics.OverlapSphere(transform.position, MaxLeapDistance, raptorController.playerInputAttack.WhatIsEnemy);
            foreach (Collider c in targets)
            {
                if (c.GetComponent<Enemy>().EnemyState == Enemy.ENEMY_STATE.Floored)
                {
                    leapTargets.Add(c.gameObject);
                }
            }

            if (leapTargets.Count > 0)
            {
                foreach (GameObject g in leapTargets)
                {
                    if (leapTarget == null || Mathf.Abs(Vector3.Distance(g.transform.position, leapTarget.transform.position)) > leapTargetDistance)
                    {
                        leapTarget = g;
                        leapTargetDistance = Mathf.Abs(Vector3.Distance(g.transform.position, leapTarget.transform.position));
                    }
                }

                currentLeapTime = 0;
                isLeaping = true;
                canLeap = false;

                leapStartPos = transform.position;
                leapEndPos = leapTarget.transform.position;

                if (transform.position.x - leapTarget.transform.position.x < 0 && !raptorController.playerInputMove.isFacingRight)
                {
                    raptorController.Flip();
                }
                else if (transform.position.x - leapTarget.transform.position.x > 0 && raptorController.playerInputMove.isFacingRight)
                {
                    raptorController.Flip();
                }
                leapTarget.GetComponent<Enemy>().ChangeState(Enemy.ENEMY_STATE.Dead);
            }
            /*else
            {
                Debug.Log("No leap target");
            }*/
        }
        
    }

    void CheckLeaping()
    {
        if (!isLeaping)
            return;

        currentLeapTime += Time.deltaTime;

        currentLeapTime = currentLeapTime % LeapDuration;

        if (currentLeapTime >= LeapDuration / 2)
            raptorController.ChangeAnimationState(raptorController.PLAYER_LAND);
        else
            raptorController.ChangeAnimationState(raptorController.PLAYER_JUMP);

        transform.position = LeapParabola(leapStartPos, leapEndPos, LeapHeight, currentLeapTime / LeapDuration);

        if ((LeapDuration - currentLeapTime) <= 0.05f)
        {
            isLeaping = false;
            canLeap = true;
        }        
    }

    public static Vector3 LeapParabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }
}
