using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float distanceToTarget = 10.0f;
    [SerializeField]
    private float smoothTime = 0.1f;
    private Vector3 followVelocity;


    void Start()
    {
        transform.position = target.position - transform.forward * distanceToTarget;
    }


    void LateUpdate()
    {
        Vector3 targetPosition = target.position - transform.forward * distanceToTarget;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref followVelocity, smoothTime);
    }
}
