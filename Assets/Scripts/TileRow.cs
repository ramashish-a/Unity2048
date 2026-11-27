using UnityEngine;

public class TileRow : MonoBehaviour
{
    // defining a public array of cells
    public TileCell[] cells { get; private set; }

    // this function is automatically called when the script is first initialized
    private void Awake()
    {
        // micromanaging each cell by row, in each row
        cells = GetComponentsInChildren<TileCell>();
    }
}
