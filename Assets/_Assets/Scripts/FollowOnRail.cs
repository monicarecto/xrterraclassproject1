using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOnRail : MonoBehaviour
{
    public Transform followTransform;
    public Transform targetTransform;
    public float size = 0.5f;
    public float valueOutMin, valueOutMax, valueOut;

    // Start is called before the first frame update
    void Start()
    {
        followTransform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        DoFollow();
        CalcValue();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.TransformPoint(new Vector3(size, 0, 0)));
    }

    public void SnapTargetToFollow ()
    {
        targetTransform.position = followTransform.position;
        targetTransform.rotation = followTransform.rotation;
    }

    void CalcValue()
    {
        float between0and1 = Mathf.InverseLerp(0, size, followTransform.localPosition.x);
        valueOut = Mathf.Lerp(valueOutMin, valueOutMax, between0and1);
    }

    void DoFollow()
    {
        followTransform.position = targetTransform.position;

        float xPos = Mathf.Clamp(followTransform.localPosition.x, 0, size);
        followTransform.localPosition = new Vector3(xPos, 0, 0);
    }
}