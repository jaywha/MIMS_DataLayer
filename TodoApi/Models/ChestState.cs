namespace TodoApi.Models;

public class ChestState : IInventoryState
{
    public ChestFacing Facing { get; set; }

    public ChestType Type { get; set; }

    public bool Waterlogged { get; set; }
}

// Direction the front of the chest is facing towards (where the latch opens)
public enum ChestFacing
{
    East,
    North,
    South,
    West
}

// Connection direction for double chests, otherwise single chest type.
public enum ChestType
{
    Left,
    Right,
    Single
}