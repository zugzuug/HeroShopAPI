using HeroShopAPI.Common.Interfaces;

/// <summary>
/// Represents an item in the inventory/shop.
/// </summary>
public class Item : IItem
{
    // A unique identifier name used in code, e.g., "healthPotion"
    public string MemberName { get; set; }

    // Unique numeric ID for the item
    public int ItemId { get; set; }

    // ID corresponding to the category (e.g., All = 1, Fighter = 2, Mage = 3)
    public int CategoryId { get; set; }

    // Human-readable category name
    public string Category { get; set; }

    // Display title of the item
    public string Title { get; set; }

    // Description of what the item does
    public string Description { get; set; }

    // Optional note about the item (e.g., "*Does not increase your strength.")
    public string Disclaimer { get; set; }

    // URL to the item's image/icon
    public string IconUrl { get; set; }

    // Item price in game currency
    public decimal Price { get; set; }

    // Weight of the item for inventory systems
    public double Weight { get; set; }

    /// <summary>
    /// Optional constructor for easy initialization.
    /// </summary>
    public Item(
        string memberName = "",
        int itemId = 0,
        int categoryId = 0,
        string category = "",
        string title = "",
        string description = "",
        string disclaimer = "",
        string iconUrl = "",
        decimal price = 0,
        double weight = 0)
    {
        MemberName = memberName;
        ItemId = itemId;
        CategoryId = categoryId;
        Category = category;
        Title = title;
        Description = description;
        Disclaimer = disclaimer;
        IconUrl = iconUrl;
        Price = price;
        Weight = weight;
    }

    /// <summary>
    /// Parameterless constructor required for JSON deserialization.
    /// </summary>
    public Item() { }
}
