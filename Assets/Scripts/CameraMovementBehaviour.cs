using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehaviour : MonoBehaviour
{
    public Transform target;

    [Range(0.01f, 0.2f)]
    public float smoothing = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x != target.position.x || transform.position.y != target.position.y)
        {
            Vector3 targetPos = new(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
}
