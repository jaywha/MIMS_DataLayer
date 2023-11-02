using System.Text;

namespace TodoApi.Models;

public class InventorySlot
{
    /// <summary>
    /// Main Id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Foreign Key for <see cref="Models.Inventory"/> relationship
    /// </summary>
    public long InventorySlotId { get; set; }

    /// <summary>
    /// Reference Navigation back to <see cref="Models.Inventory"/>
    /// </summary>
    public Inventory Inventory { get; set; } = null!;

    /// <summary>
    /// The in-game id of this item.
    /// </summary>
    /// <example>"minecraft:chest"</example>
    public string? Name { get; set; }

    /// <summary>
    /// The raw number of the item this slot holds.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Common stack formula formatting
    /// </summary>
    /// <returns>(# of stacks of 64)w+(# not in a full stack)</returns>
    /// <example>1w+6=70</example>
    public string GetStackFormula() => $"{Count / 64}w+{Count % 64}";
}