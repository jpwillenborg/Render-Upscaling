using UnityEngine;


public class GroundPlayerTarget : MonoBehaviour
{
    private float targetHeight;
    private Vector3 targetPosition;


    void Start()
    {
        targetHeight = transform.position.y;
    }


    void Update()
    {
        targetPosition = transform.parent.position;
        targetPosition.y = targetHeight;
        transform.position = targetPosition;
    }
}