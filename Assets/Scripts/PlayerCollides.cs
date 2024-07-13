using UnityEngine;
using UnityEngine.Events;

public class PlayerCollides : MonoBehaviour
{
    public bool _door = true;
    public UnityEvent DoorCollide;
    public bool _spike = true;
    public UnityEvent SpikesCollide;    
    public bool _player = true;
    public UnityEvent PlayerCollide;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door") && _door)
        {
            SoundMaster.Instance.PlaySFX("Door");

            DoorCollide.Invoke();
        }

        if (collision.gameObject.CompareTag("Spikes") && _spike)
        {
            SoundMaster.Instance.PlaySFX("Spike");

            SpikesCollide.Invoke();
        }

        if (collision.gameObject.CompareTag("Player") && _player)
        {
            SoundMaster.Instance.PlaySFX("Key");

            PlayerCollide.Invoke();
        }
    }
}
