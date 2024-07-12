using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private Animator _animator;

    private float Vert => Input.GetAxis("Vertical");
    private float Hori => Input.GetAxis("Horizontal");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Vert > 0)
        {
            transform.position += transform.up * _moveSpeed * Time.deltaTime;
        }
        else if (Vert < 0)
        {
            transform.position += transform.up * -_moveSpeed * Time.deltaTime;
        }

        if (Hori > 0)
        {
            transform.position += transform.right * _moveSpeed * Time.deltaTime;
        }
        else if (Hori < 0)
        {
            transform.position += transform.right * -_moveSpeed * Time.deltaTime;
        }

        if (Vert != 0 || Hori != 0)
        {
            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }
}
