using System.Text.Json.Nodes;

namespace TodoApi.Models;

public class ChestInfo : IInventoryInfo
{
    public string? Name { get; set; }
    public IInventoryState? State { get; set; }
    public Dictionary<string, bool>? Tags { get; set; }
}