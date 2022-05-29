using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [Range(0f, 10f)]
    public float Speed = 4f;

    private Animator _animator;
    private Rigidbody2D _rigidbody;
    private Vector3 _change = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _change = Vector3.zero;
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");

        bool isMoving = _change != Vector3.zero;

        UpdateAnimationAndMove(isMoving);
    }

    void UpdateAnimationAndMove(bool isMoving)
    {
        _animator.SetBool("IsMoving", isMoving);
        if (isMoving)
        {
            MoveChar();
            _animator.SetFloat("MoveX", _change.x);
            _animator.SetFloat("MoveY", _change.y);
        }
    }

    void MoveChar()
    {
        _rigidbody.MovePosition(transform.position + _change * Speed * Time.fixedDeltaTime);
    }
}
