using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private AudioSource _walking;
    [SerializeField] private ParticleSystem _dust;

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
        if (Vert != 0)
        {
            transform.position += transform.up * _moveSpeed * Time.deltaTime * Vert;
        }

        if (Hori != 0)
        {
            transform.position += transform.right * _moveSpeed * Time.deltaTime * Hori;
        }

        if (Vert != 0 || Hori != 0)
        {
            _walking.mute = false;

            _animator.SetBool("isWalking", true);

            var em = _dust.emission;
            em.enabled = true;
        }
        else
        {
            _walking.mute = true;

            _animator.SetBool("isWalking", false);

            var em = _dust.emission;
            em.enabled = false;
        }
    }
}
