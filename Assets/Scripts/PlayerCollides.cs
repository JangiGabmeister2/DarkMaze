using UnityEngine;
using UnityEngine.Events;

public class PlayerCollides : MonoBehaviour
{
    public UnityEvent DoorCollide;
    public UnityEvent SpikesCollide;    
    public UnityEvent PlayerCollide;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            SoundMaster.Instance.PlaySFX("Door");

            DoorCollide.Invoke();
        }

        if (collision.gameObject.CompareTag("Spikes"))
        {
            SoundMaster.Instance.PlaySFX("Spike");

            SpikesCollide.Invoke();
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SoundMaster.Instance.PlaySFX("Key");

            PlayerCollide.Invoke();
        }
    }
}
