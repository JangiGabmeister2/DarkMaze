using UnityEngine;

public class BarrierCollider : MonoBehaviour
{
    [SerializeField] private bool _isLocked = true;

    private SpriteRenderer _sprite;
    private SpriteRenderer _lock;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _lock = GetComponentInChildren<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();

        _boxCollider.size = _sprite.size;
        _lock.enabled = _isLocked;
    }
}
