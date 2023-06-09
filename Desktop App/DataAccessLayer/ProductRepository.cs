﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class ProductRepository : DatabaseHandler, IProductRepository
    {
        public DataTable DisplayProducts()
        {
            Connect();

            string sql = "SELECT `id`, `name`, `brand`, `description`, `price`, `type` FROM indiv_products";
            Cmd = new MySqlCommand(sql, Con);

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);

            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                Disconnect();
            }

            return dt;
        }

        public void AddProduct(Product product)
        {
            Connect();

            string sql = "INSERT INTO indiv_products (`name`, `brand`, `description`, `price`, `type`, `image`) VALUES (@name, @brand, @description, @price, @type, @image)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", product.Name);
            Cmd.Parameters.AddWithValue("@brand", product.Brand);
            Cmd.Parameters.AddWithValue("@description", product.Description);
            Cmd.Parameters.AddWithValue("@price", product.Price);
            Cmd.Parameters.AddWithValue("@type", product.Type.ToString());
            Cmd.Parameters.AddWithValue("@image", product.Image);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }

            int id = GetProductId(product.Name, product.Brand, product.Description);

            if (id != -1)
            {
                switch (product)
                {
                    case Vitamins:
                        AddVitamins(id, ((Vitamins)product).Flavour, ((Vitamins)product).Goal);
                        break;
                    case Protein:
                        AddProtein(id, ((Protein)product).Flavour, ((Protein)product).Occurance, ((Protein)product).Goal);
                        break;
                    case Clothing:
                        AddClothing(id, ((Clothing)product).ClothType, ((Clothing)product).ClothSize);
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddVitamins(int id, VitaminFlavour flavour, Goal goal)
        {
            Connect();

            string sql = "INSERT INTO indiv_vitamins (`id`, `flavour`, `goal`) VALUES (@id, @flavour, @goal)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);
            Cmd.Parameters.AddWithValue("@flavour", flavour.ToString());
            Cmd.Parameters.AddWithValue("@goal", goal.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        private void AddProtein(int id, ProteinFlavour flavour, string occurance, Goal goal)
        {
            Connect();

            string sql = "INSERT INTO indiv_protein (`id`, `flavour`, `occurance`, `goal`) VALUES (@id, @flavour, @occurance, @goal)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);
            Cmd.Parameters.AddWithValue("@flavour", flavour.ToString());
            Cmd.Parameters.AddWithValue("@occurance", occurance);
            Cmd.Parameters.AddWithValue("@goal", goal.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        private void AddClothing(int id, ClothType type, ClothSize size)
        {
            Connect();

            string sql = "INSERT INTO indiv_clothes (`id`, `cloth_type`, `cloth_size`) VALUES (@id, @type, @size)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);
            Cmd.Parameters.AddWithValue("@type", type.ToString());
            Cmd.Parameters.AddWithValue("@size", size.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        private int GetProductId(string name, string brand, string description)
        {
            int id = -1;

            Connect();

            string sql = "SELECT `id` FROM indiv_products WHERE `name` LIKE @name AND `brand` LIKE @brand AND `description` LIKE @description";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", name);
            Cmd.Parameters.AddWithValue("@brand", brand);
            Cmd.Parameters.AddWithValue("@description", description);

            try
            {
                Reader = Cmd.ExecuteReader();

                if (Reader.Read())
                {
                    id = Reader.GetInt32(0);
                }
            }
            finally
            {
                Disconnect();
            }

            return id;
        }

        public DataTable ShowProductsByFilters(string brand, string type, string price)
        {
            Connect();
            bool firstFilterFound = false;
            string sql = "SELECT `id`, `name`, `brand`, `description`, `price`, `type` FROM indiv_products";

            if (brand != "")
            {
                sql = sql + " WHERE brand = @brand";
                firstFilterFound = true;
            }
            if (type != "")
            {
                if (firstFilterFound == true)
                {
                    sql = sql + " AND type = @type";
                }
                else
                {
                    sql = sql + " WHERE type = @type";
                    firstFilterFound = true;
                }
            }
            if (price != "")
            {
                if (firstFilterFound == true)
                {
                    switch (price)
                    {
                        case "0 - 100":
                            sql = sql + " AND price >= 0 AND price <= 100";
                            break;
                        case "101 - 500":
                            sql = sql + " AND price >= 101 AND price <= 500";
                            break;
                        case "501 - 1000":
                            sql = sql + " AND price >= 501 AND price <= 1000";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (price)
                    {
                        case "0 - 100":
                            sql = sql + " WHERE price >= 0 AND price <= 100";
                            break;
                        case "101 - 500":
                            sql = sql + " WHERE price >= 101 AND price <= 500";
                            break;
                        case "501 - 1000":
                            sql = sql + " WHERE price >= 501 AND price <= 1000";
                            break;
                        default:
                            break;
                    }
                }
            }

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@type", type);
            Cmd.Parameters.AddWithValue("@brand", brand);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                Disconnect();
            }

            return dt;
        }

        public List<string> PopulateFilterBoxByType(string type)
        {
            List<string> filterBox = new List<string>();
            Connect();

            string sql = "SELECT DISTINCT ";

            if (type == "brand")
            {
                sql = sql + "`brand` FROM indiv_products";
            }
            else if (type == "type")
            {
                sql = sql + "`type` FROM indiv_products";
            }
            else if (type == "price")
            {
                filterBox.Add("0 - 100");
                filterBox.Add("101 - 500");
                filterBox.Add("501 - 1000");
                return filterBox;
            }

            Cmd = new MySqlCommand(sql, Con);

            try
            {
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    filterBox.Add(Reader.GetString(0));
                }
            }
            finally
            {
                Disconnect();
            }

            return filterBox;
        }

        public void DeleteProduct(int productId)
        {
            Connect();

            string sql = "DELETE FROM `indiv_products` WHERE `indiv_products`.`id` = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", productId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            Connect();

            string sql = "SELECT * FROM indiv_products AS p INNER JOIN indiv_clothes AS c ON c.id = p.id WHERE p.id = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                int productId = Reader.GetInt32(0);
                string productName = Reader.GetString(1);
                string productBrand = Reader.GetString(2);
                string description = Reader.GetString(3);
                decimal price = Reader.GetDecimal(4);
                string type = Reader.GetString(5);
                byte[] vs = (byte[])(Reader["image"]);
                string clothType = Reader.GetString(8);
                string clothSize = Reader.GetString(9);
                product = new Clothing(productId, productName, productBrand, description, price, (ProductType)Enum.Parse(typeof(ProductType), type), vs, (ClothType)Enum.Parse(typeof(ClothType), clothType), (ClothSize)Enum.Parse(typeof(ClothSize), clothSize));
            }

            Reader.Close();

            string sql2 = "SELECT * FROM indiv_products AS p INNER JOIN indiv_vitamins AS v ON v.id = p.id WHERE p.id = @id";
            Cmd = new MySqlCommand(sql2, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                int productId = Reader.GetInt32(0);
                string productName = Reader.GetString(1);
                string productBrand = Reader.GetString(2);
                string description = Reader.GetString(3);
                decimal price = Reader.GetDecimal(4);
                string type = Reader.GetString(5);
                byte[] vs = (byte[])(Reader["image"]);
                string flavour = Reader.GetString(8);
                string goal = Reader.GetString(9);
                product = new Vitamins(productId, productName, productBrand, description, (ProductType)Enum.Parse(typeof(ProductType), type), price, vs, (VitaminFlavour)Enum.Parse(typeof(VitaminFlavour), flavour), (Goal)Enum.Parse(typeof(Goal), goal));
            }

            Reader.Close();

            string sql3 = "SELECT * FROM indiv_products AS p INNER JOIN indiv_protein AS pro ON pro.id = p.id WHERE p.id = @id";
            Cmd = new MySqlCommand(sql3, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                int productId = Reader.GetInt32(0);
                string productName = Reader.GetString(1);
                string productBrand = Reader.GetString(2);
                string description = Reader.GetString(3);
                decimal price = Reader.GetDecimal(4);
                string type = Reader.GetString(5);
                byte[] vs = (byte[])(Reader["image"]);
                string flavour = Reader.GetString(8);
                string occurance = Reader.GetString(9);
                string goal = Reader.GetString(10);
                product = new Protein(productId, productName, productBrand, description, (ProductType)Enum.Parse(typeof(ProductType), type), price, vs, (Goal)Enum.Parse(typeof(Goal), goal), occurance, (ProteinFlavour)Enum.Parse(typeof(ProteinFlavour), flavour));
            }

            Disconnect();

            return product;
        }

        public List<Product> GetListOfProducts()
        {
            List<Product> products = new List<Product>();

            Connect();

            string sql = "SELECT * from indiv_products";
            Cmd = new MySqlCommand(sql, Con);

            try
            {
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string name = Reader.GetString(1);
                    string brand = Reader.GetString(2);
                    string description = Reader.GetString(3);
                    decimal price = Reader.GetDecimal(4);
                    string type = Reader.GetString(5);
                    byte[] image = (byte[])(Reader["image"]);

                    products.Add(new Product(id, name, brand, description, (ProductType)Enum.Parse(typeof(ProductType), type), price, image));
                }
            }
            finally
            {
                Disconnect();
            }

            return products;
        }

        public void UpdateProtein(Protein protein)
        {
            Connect();

            string sql = "UPDATE indiv_products AS p INNER JOIN indiv_protein AS pro ON p.id = pro.id SET p.`name` = @name, p.`brand` = @brand, p.`description` = @description, p.`price` = @price, p.`type` = @type, p.`image` = @image, pro.`flavour` = @flavour, pro.`occurance` = @occurance, pro.`goal` = @goal WHERE p.`id` = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", protein.Name);
            Cmd.Parameters.AddWithValue("@id", protein.ID);
            Cmd.Parameters.AddWithValue("@brand", protein.Brand);
            Cmd.Parameters.AddWithValue("@description", protein.Description);
            Cmd.Parameters.AddWithValue("@price", protein.Price);
            Cmd.Parameters.AddWithValue("@type", protein.Type.ToString());
            Cmd.Parameters.AddWithValue("@image", protein.Image);
            Cmd.Parameters.AddWithValue("@flavour", protein.Flavour.ToString());
            Cmd.Parameters.AddWithValue("@occurance", protein.Occurance);
            Cmd.Parameters.AddWithValue("@goal", protein.Goal.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        public void UpdateClothing(Clothing clothing)
        {
            Connect();

            string sql = "UPDATE indiv_products AS p INNER JOIN indiv_clothes AS pro ON p.id = pro.id SET p.`name` = @name, p.`brand` = @brand, p.`description` = @description, p.`price` = @price, p.`type` = @type, p.`image` = @image, pro.`cloth_type` = @clothType, pro.`cloth_size` = @size WHERE p.`id` = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", clothing.Name);
            Cmd.Parameters.AddWithValue("@id", clothing.ID);
            Cmd.Parameters.AddWithValue("@brand", clothing.Brand);
            Cmd.Parameters.AddWithValue("@description", clothing.Description);
            Cmd.Parameters.AddWithValue("@price", clothing.Price);
            Cmd.Parameters.AddWithValue("@type", clothing.Type.ToString());
            Cmd.Parameters.AddWithValue("@image", clothing.Image);
            Cmd.Parameters.AddWithValue("@clothType", clothing.ClothType.ToString());
            Cmd.Parameters.AddWithValue("@size", clothing.ClothSize.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        public void UpdateVitamins(Vitamins vitamins)
        {
            Connect();

            string sql = "UPDATE indiv_products AS p INNER JOIN indiv_vitamins AS pro ON p.id = pro.id SET p.`name` = @name, p.`brand` = @brand, p.`description` = @description, p.`price` = @price, p.`type` = @type, p.`image` = @image, pro.`flavour` = @flavour, pro.`goal` = @goal WHERE p.`id` = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", vitamins.Name);
            Cmd.Parameters.AddWithValue("@id", vitamins.ID);
            Cmd.Parameters.AddWithValue("@brand", vitamins.Brand);
            Cmd.Parameters.AddWithValue("@description", vitamins.Description);
            Cmd.Parameters.AddWithValue("@price", vitamins.Price);
            Cmd.Parameters.AddWithValue("@type", vitamins.Type.ToString());
            Cmd.Parameters.AddWithValue("@image", vitamins.Image);
            Cmd.Parameters.AddWithValue("@flavour", vitamins.Flavour.ToString());
            Cmd.Parameters.AddWithValue("@goal", vitamins.Goal.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        public bool CheckIfProductExists(Product product)
        {
            Connect();

            string sql = "SELECT * FROM indiv_products WHERE `name` = @name, `brand` = @brand, `description` = @description, `price` = @price, `type` = @type, `image` = @image";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", product.Name);
            Cmd.Parameters.AddWithValue("@brand", product.Brand);
            Cmd.Parameters.AddWithValue("@description", product.Description);
            Cmd.Parameters.AddWithValue("@price", product.Price);
            Cmd.Parameters.AddWithValue("@type", product.Type.ToString());
            Cmd.Parameters.AddWithValue("@image", product.Image);

            try
            {
                Reader = Cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    return true;
                }

                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
