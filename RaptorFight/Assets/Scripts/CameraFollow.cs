using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTarget;

    public Vector3 TargetOffset;
    public Vector3 ConstantOffset;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        pos = new Vector3(FollowTarget.position.x, TargetOffset.y, TargetOffset.z);
        transform.position = pos;
        transform.LookAt(FollowTarget);
    }
}
