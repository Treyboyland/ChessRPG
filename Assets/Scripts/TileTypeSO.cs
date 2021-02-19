using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TileType", menuName = "Grid/Tile Type", order = 10)]
public class TileTypeSO : ScriptableObject
{
    [Tooltip("Name of this tile type")]
    [SerializeField]
    string tileName;

    /// <summary>
    /// Name of this tile type
    /// </summary>
    /// <value></value>
    public string TileName { get { return tileName; } }


    [SerializeField]
    [Tooltip("Description of what this tile type does")]
    string description;

    /// <summary>
    /// Description of what this tile type does
    /// </summary>
    /// <value></value>
    public string Description { get { return description; } }
}
