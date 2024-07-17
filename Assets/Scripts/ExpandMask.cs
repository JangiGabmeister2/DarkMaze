using System.Collections;
using UnityEngine;

public class ExpandMask : MonoBehaviour
{
    [SerializeField] private Transform _spriteMask;

    private Vector3 _speed = new Vector3(100, 100, 100);

    public void BegoneTilemap()
    {
        StartCoroutine(nameof(Expand));
    }

    public void ComeBackTilemap()
    {
        StartCoroutine(nameof(Shrink));
    }

    private IEnumerator Expand()
    {
        while (_spriteMask.localScale.y < 100)
        {
            _spriteMask.localScale += _speed * Time.deltaTime;

            yield return null;
        }
    }

    private IEnumerator Shrink()
    {
        while (_spriteMask.localScale.y > 0f)
        {
            _spriteMask.localScale -= _speed * Time.deltaTime;

            yield return null;
        }
    }
}
