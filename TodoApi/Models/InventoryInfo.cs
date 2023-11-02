namespace TodoApi.Models;

public interface IInventoryInfo
{
    public string? Name { get; set; }

    public Dictionary<string, bool>? Tags { get; set; }

    public abstract IInventoryState? State { get; set; }
}