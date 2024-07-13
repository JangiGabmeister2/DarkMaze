using UnityEngine;

public class PlateControl : MonoBehaviour
{
    [SerializeField] private Sprite _off, _on;
    [SerializeField] private PlateControl[] _op;

    public bool isOn = false;
    public float volumeValue;

    [HideInInspector]
    public SpriteRenderer render => GetComponent<SpriteRenderer>();

    public void Toggle()
    {
        isOn = true;

        render.sprite = isOn ? _on : _off;

        for (int i = 0; i < _op.Length; i++)
        {
            if (_op[i] != this)
            {
                _op[i].isOn = false;
                _op[i].render.sprite = _off;
            }
        }
    }
}
