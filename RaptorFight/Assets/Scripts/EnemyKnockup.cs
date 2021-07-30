using System;
using UnityEngine;

public class EnemyKnockup : MonoBehaviour
{
    [SerializeField] internal Enemy enemy;

    private bool isKnockedUp = false;
    public float KnockupHeight = 1f;
    public float KnockupDuration = 1f;
    private float currentKnockupTime = 0f;
    private Vector3 knockupStartPos = Vector3.zero;
    private Vector3 knockupEndPos = Vector3.zero;

    private void Update()
    {
        CheckKnockup();
    }

    public void Knockup(Vector3 dir)
    {
        currentKnockupTime = 0;
        isKnockedUp = true;

        knockupStartPos = transform.position;
        knockupEndPos = new Vector3(dir.x * enemy.KnockMultiplier, dir.y, dir.z) + transform.position;
    }

    void CheckKnockup()
    {
        if (!isKnockedUp)
            return;

        currentKnockupTime += Time.deltaTime;

        currentKnockupTime = currentKnockupTime % KnockupDuration;

        transform.position = Parabola(knockupStartPos, knockupEndPos, KnockupHeight, currentKnockupTime / KnockupDuration);

        if ((KnockupDuration - currentKnockupTime) <= 0.05f)
        {
            isKnockedUp = false;
        }
    }

    public Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }
}
