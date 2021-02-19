using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridDataSO : ScriptableObject
{
    /// <summary>
    /// Name of the grid in UI
    /// </summary>
    [SerializeField]
    string gridName;

    /// <summary>
    /// Name of the grid in UI
    /// </summary>
    /// <value></value>
    public string GridName { get { return gridName; } }

    /// <summary>
    /// Tiles making up the Grid
    /// </summary>
    /// <value></value>
    public abstract List<List<TileTypeSO>> Tiles { get; set; }
}
