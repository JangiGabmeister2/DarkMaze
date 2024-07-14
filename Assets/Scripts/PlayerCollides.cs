using System.Security.Cryptography.X509Certificates;
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
            string[] tagName = new string[] {"Key", "Door", "Plate", "Spikes", "Torch"};

            for (int i = 0; i < tagName.Length; i++)
            {
                if (collision.gameObject.CompareTag(tagName[i]))
                {
                    SoundMaster.Instance.PlaySFX(tagName[i]);
                }
            }
        }
    }
}
