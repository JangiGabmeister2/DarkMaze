using System.Collections;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FadingTiles : MonoBehaviour
{
    [SerializeField] private Tilemap[] _tilemaps;

    private Color[] _tilemapColors;

    private void Start()
    {
        _tilemapColors = new Color[_tilemaps.Length];

        for (int i = 0; i < _tilemaps.Length; i++)
        {
            _tilemapColors[i] = _tilemaps[i].color;
        }
    }

    private void Update()
    {
        for (int i = 0; i < _tilemaps.Length; i++)
        {
            _tilemaps[i].color = _tilemapColors[i];
        }
    }

    public void Begone()
    {
        StartCoroutine(nameof(TilemapBegone));
    }

    public void ComeBack()
    {
        StartCoroutine(nameof(TilemapComeBack));
    }

    private IEnumerator TilemapBegone()
    {
        for (int i = 0; i < _tilemapColors.Length; i++)
        {
            while (_tilemapColors[i].a > 0)
            {
                _tilemapColors[i].a -= Time.deltaTime;

            }

            yield return null;
        }
    }

    private IEnumerator TilemapComeBack()
    {
        for (int i = 0; i < _tilemapColors.Length; i++)
        {
            while (_tilemapColors[i].a < 255)
            {
                _tilemapColors[i].a += Time.deltaTime;

            }

            yield return null;
        }
    }
}
