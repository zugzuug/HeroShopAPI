using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using HeroShopAPI.Data.Interfaces;
using HeroShopAPI.Data.Mappers;
using Microsoft.Data.SqlClient; // Ensure this is installed via NuGet

namespace HeroShopAPI.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly string? _jsonFilePath;
        private readonly string? _connectionString;
        private readonly bool _useJsonSource;

        /// <summary>
        /// Default constructor for database access.
        /// </summary>
        public DataAccess(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));

            _connectionString = connectionString;
            _useJsonSource = false;
        }

        /// <summary>
        /// Alternate constructor for JSON source.
        /// </summary>
        public DataAccess(string jsonFilePath, bool useJsonSource)
        {
            if (!useJsonSource)
                throw new ArgumentException("The 'useJsonSource' flag must be true to use the JSON constructor.");

            if (string.IsNullOrWhiteSpace(jsonFilePath))
                throw new ArgumentException("JSON file path cannot be null or empty.", nameof(jsonFilePath));

            _jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), jsonFilePath);
            _useJsonSource = true;
        }

        /// <summary>
        /// Returns the list of items based on the configured data source.
        /// </summary>
        public List<Item> GetItems()
        {
            return _useJsonSource ? GetItemsFromJson() : GetItemsFromDatabase();
        }

        /// <summary>
        /// Reads items from a JSON file.
        /// </summary>
        private List<Item> GetItemsFromJson()
        {
            try
            {
                if (!File.Exists(_jsonFilePath!))
                {
                    Console.Error.WriteLine($"JSON file not found: {_jsonFilePath}");
                    return new List<Item>();
                }

                string json = File.ReadAllText(_jsonFilePath!);
                return ItemMapper.LoadItemsFromJsonString(json);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error reading JSON data: {ex.Message}");
                return new List<Item>();
            }
        }

        /// <summary>
        /// Reads items from the database. Replace this with EF/Dapper for production.
        /// </summary>
        private List<Item> GetItemsFromDatabase()
        {
            try
            {
                var items = new List<Item>();

                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                var command = new SqlCommand("SELECT * FROM Items", conn);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new Item
                    {
                        ItemId = reader.GetInt32(reader.GetOrdinal("ItemId")),
                        CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                        Category = reader.GetString(reader.GetOrdinal("Category")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        Description = reader.GetString(reader.GetOrdinal("Description")),
                        Disclaimer = reader.IsDBNull(reader.GetOrdinal("Disclaimer")) ? null : reader.GetString(reader.GetOrdinal("Disclaimer")),
                        IconUrl = reader.GetString(reader.GetOrdinal("IconUrl")),
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        Weight = reader.GetDouble(reader.GetOrdinal("Weight"))
                    });
                }

                return items;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error accessing database: {ex.Message}");
                return new List<Item>();
            }
        }
    }
}