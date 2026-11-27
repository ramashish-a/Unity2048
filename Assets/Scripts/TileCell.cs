using UnityEngine;

public class TileCell : MonoBehaviour
{
    // for determing the coordinates of each cell
    public Vector2Int coordinates { get; set; }
    public Tile tile { get; set;}

    // for determining if the cell is empty or occupied
    public bool empty => tile == null;
    public bool occupied => tile != null;
}
