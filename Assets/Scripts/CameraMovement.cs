using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    [Range(0.1f, 1f)]
    public float smoothing = 0.6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x != target.position.x || transform.position.y != target.position.y)
        { 
            Vector3 targetPos = new(target.position.x, target.position.y, transform.position.z);
            Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
}
