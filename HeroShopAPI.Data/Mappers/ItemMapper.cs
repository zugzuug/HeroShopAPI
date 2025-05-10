using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace HeroShopAPI.Data.Mappers
{

    /// <summary>
    /// Provides functionality to load and parse items from a JSON string.
    /// </summary>
    public static class ItemMapper
    {
        /// <summary>
        /// Parses items from a JSON string into a list of Item objects.
        /// </summary>
        /// <param name="json">The JSON string containing an array of item objects.</param>
        /// <returns>List of Item objects, or an empty list if there's an error.</returns>
        public static List<Item> LoadItemsFromJsonString(string json)
        {
            var items = new List<Item>();

            try
            {
                if (string.IsNullOrWhiteSpace(json))
                {
                    Console.Error.WriteLine("Input JSON string is null or empty.");
                    return items;
                }

                JsonArray jsonArray = JsonNode.Parse(json)?.AsArray();

                if (jsonArray == null)
                {
                    Console.Error.WriteLine("Failed to parse JSON array.");
                    return items;
                }

                foreach (JsonNode node in jsonArray)
                {
                    try
                    {
                        var item = new Item(
                            memberName: node["memberName"]?.GetValue<string>() ?? "",
                            itemId: node["itemId"]?.GetValue<int>() ?? 0,
                            categoryId: node["categoryId"]?.GetValue<int>() ?? 0,
                            category: node["category"]?.GetValue<string>() ?? "",
                            title: node["title"]?.GetValue<string>() ?? "",
                            description: node["description"]?.GetValue<string>() ?? "",
                            disclaimer: node["disclaimer"]?.GetValue<string>() ?? "",
                            iconUrl: node["iconUrl"]?.GetValue<string>() ?? "",
                            price: node["price"]?.GetValue<decimal>() ?? 0,
                            weight: node["weight"]?.GetValue<double>() ?? 0
                        );

                        items.Add(item);
                    }
                    catch (Exception itemEx)
                    {
                        Console.Error.WriteLine($"Error parsing item node: {itemEx.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error parsing JSON string: {ex.Message}");
            }

            return items;
        }
    }
}