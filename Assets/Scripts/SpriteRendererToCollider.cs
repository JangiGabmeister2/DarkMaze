using UnityEngine;
using NaughtyAttributes;

public class SpriteRendererToCollider : MonoBehaviour
{
    [SerializeField] private bool _hasLock = true;
    [SerializeField][ShowIf("_hasLock")] private bool _isLocked = true;

    private SpriteRenderer _sprite;
    private SpriteRenderer _lock;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();

        _boxCollider.size = _sprite.size;

        if (_hasLock)
        {
            _lock = GetComponentInChildren<SpriteRenderer>();
            _lock.enabled = _isLocked;
        }
    }
}
