using UnityEngine;

// adds a menu option to create custom ScriptableObjects
[CreateAssetMenu(menuName = "Tile State")]

public class TileState : ScriptableObject
{
    // defing background and text color for our tile
    public Color backgroundColor;
    public Color textColor;
}
