using System.Collections;
using UnityEngine;

public class ExpandMask : MonoBehaviour
{
    [SerializeField] private Transform _spriteMask;
    [SerializeField] private float _minScale = 5f, _maxScale = 100f;

    [SerializeField] private bool _enableStart = true;

    private Vector3 _speed = new Vector3(50, 50, 50);

    private void Start()
    {
        if (_enableStart)
        {
            _spriteMask.localScale = new Vector3(_minScale, _minScale); 
        }
    }

    public void BegoneTilemap()
    {
        StartCoroutine(nameof(Expand));
    }

    public void ComeBackTilemap()
    {
        StartCoroutine(nameof(Shrink));
    }

    public void IncreaseMaskSize(float increment)
    {
        _spriteMask.localScale += new Vector3(increment, increment);
    }

    private IEnumerator Expand()
    {
        while (_spriteMask.localScale.y < _maxScale)
        {
            _spriteMask.localScale += _speed * Time.deltaTime;

            yield return null;
        }
    }

    private IEnumerator Shrink()
    {
        while (_spriteMask.localScale.y > _minScale)
        {
            _spriteMask.localScale -= _speed * Time.deltaTime;

            yield return null;
        }
    }
}
