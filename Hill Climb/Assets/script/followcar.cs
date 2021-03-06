using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcar : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
    private void FixedUpdate()
    {
        Follow();

    }
    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
