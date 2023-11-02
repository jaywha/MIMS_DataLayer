namespace TodoApi.Models;

public class Chest : Inventory
{
    /// <summary>
    /// Holds information realted to a Vanilla Minecraft Chest
    /// </summary>
    public ChestInfo? Info { get; set; }
}