namespace TodoApi.Models;

public class Inventory
{
    /// <summary>
    /// Main Id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Dictionary of items, 1-indexed by slots
    /// </summary>
    public ICollection<InventorySlot> Slots { get; set; } = new List<InventorySlot>();

    /// <summary>
    /// In-game location of the inventory; "y" is the height
    /// </summary>
    public float X { get; set; } = 0.0f;
    public float Y { get; set; } = 0.0f;
    public float Z { get; set; } = 0.0f;
}