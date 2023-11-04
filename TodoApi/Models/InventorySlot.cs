using System.Text;

namespace TodoApi.Models;

public class InventorySlot
{
    /// <summary>
    /// Main Id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// The in-game id of this item.
    /// </summary>
    /// <example>"minecraft:chest"</example>
    public string Name { get; set; } = "";

    /// <summary>
    /// The raw number of the item this slot holds.
    /// </summary>
    public int Count { get; set; }
}