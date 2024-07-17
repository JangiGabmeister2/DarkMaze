using UnityEngine;

public class SpriteRendererToCollider : MonoBehaviour
{
    [SerializeField] SpriteRenderer _lock;
    [SerializeField] private bool _hasLock = true;

    private SpriteRenderer _sprite;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();

        _boxCollider.size = _sprite.size;

        if (!_hasLock)
        {
            _lock.enabled = false;
        }
    }
}
