using UnityEngine;

public class BarrierCollider : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();

        _boxCollider.size = _sprite.size;
    }
}
