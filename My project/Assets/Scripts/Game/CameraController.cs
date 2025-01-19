using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The object the camera follows
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            offset = transform.position - target.position;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }

    // Method to set a new target for the camera
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;

        // Recalculate the offset based on the new target's position
        if (target != null)
        {
            offset = transform.position - target.position;
        }
    }
}
