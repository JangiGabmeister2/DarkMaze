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
            DoorCollide.Invoke();
        }

        if (collision.gameObject.name == "Spikes")
        {
            SpikesCollide.Invoke();
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerCollide.Invoke();
        }
    }
}
