using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WhenPlayerMoves : MonoBehaviour
{
    public UnityEvent PlayerMoved;

    public Transform player;

    private Vector3 _playerPosOnAwake;

    private void Start()
    {
        _playerPosOnAwake = player.position;

        StartCoroutine(nameof(CheckForPlayerMovement));
    }

    private IEnumerator CheckForPlayerMovement()
    {
        while (player.position == _playerPosOnAwake)
        {
            yield return null;
        }

        PlayerMoved?.Invoke();
    }
}
