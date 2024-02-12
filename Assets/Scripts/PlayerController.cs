using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _barrelAnimator;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
        Vector3 directionVector = new Vector3(_joystick.Vertical, 0, _joystick.Horizontal);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetFloat("speed",Vector3.ClampMagnitude(directionVector, 1).magnitude);
            _barrelAnimator.SetFloat("speed",Vector3.ClampMagnitude(directionVector, 1).magnitude);
        }
        else
        {
            _animator.SetFloat("speed", 0f);
            _barrelAnimator.SetFloat("speed", 0f);
        }
    }
}
