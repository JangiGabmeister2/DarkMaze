using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class TilemapControl : MonoBehaviour
{
    private Tilemap map;

    private void Awake()
    {
        map = GetComponent<Tilemap>();
    }

    [Button]
    public void ResetTileMap()
    {
        map.ClearAllTiles();
    }
}
