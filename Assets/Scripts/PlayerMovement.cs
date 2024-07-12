using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private AudioSource _walking;

    private Animator _animator;
    private float Vert => Input.GetAxisRaw("Vertical");
    private float Hori => Input.GetAxisRaw("Horizontal");

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _walking.mute = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * _moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.up * -_moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -_moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _moveSpeed * Time.deltaTime;
        }

        if (Vert != 0 || Hori != 0)
        {
            _walking.mute = false;

            _animator.SetBool("isWalking", true);
        }
        else
        {
            _walking.mute = true;

            _animator.SetBool("isWalking", false);
        }
    }
}
