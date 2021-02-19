using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleGrid", menuName = "Grid/Simple Grid", order = 10)]
public class SimpleGridDataSO : GridDataSO
{
    [Tooltip("Dimensions of this grid")]
    [SerializeField]
    Vector2Int dimensions;

    [Tooltip("Tile that will populate every square")]
    [SerializeField]
    TileTypeSO tile;

    bool hasGenerated = false;

    List<List<TileTypeSO>> tiles = new List<List<TileTypeSO>>();

    private void OnEnable()
    {
        if (!hasGenerated)
        {
            GenerateTiles();
        }
    }

    void GenerateTiles()
    {
        for (int y = 0; y < dimensions.y; y++)
        {
            List<TileTypeSO> row = new List<TileTypeSO>();
            for (int x = 0; x < dimensions.x; x++)
            {
                row.Add(tile);
            }
            tiles.Add(row);
        }
        hasGenerated = true;
    }

    //TODO: Potential code smell...this might need to be a method
    public override List<List<TileTypeSO>> Tiles
    {
        get
        {
            if (!hasGenerated)
            {
                GenerateTiles();
            }

            return tiles;
        }
        set
        {
            hasGenerated = true;
            tiles = value;
        }
    }
}
