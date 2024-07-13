using UnityEngine;
using UnityEngine.Events;

public class PlayerCollides : MonoBehaviour
{
    public string objectTag = "";

    public UnityEvent OnCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(objectTag))
        {
            OnCollision.Invoke();
        }

        if (CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Key"))
            {
                SoundMaster.Instance.PlaySFX("Key");
            }

            if (collision.gameObject.CompareTag("Door"))
            {
                SoundMaster.Instance.PlaySFX("Door");
            }

            if (collision.gameObject.CompareTag("Spikes"))
            {
                SoundMaster.Instance.PlaySFX("Spike");
            }

            if (collision.gameObject.CompareTag("Plate"))
            {
                SoundMaster.Instance.PlaySFX("Plate");
            }
        }
    }
}
