using GymGenZ.PModels;
using GymGenZ.PViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GymGenZ.PControls
{
    internal class CProduct
    {
        private SQLiteConnection _conn;

        public CProduct(string connectionString)
        {
            _conn = new SQLiteConnection(connectionString);
            _conn.Open();
        }

        public bool addProduct(MProduct newProduct)
        {
            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {
                string insertQuery = "INSERT INTO Product (nameProduct, count, price, idCateProduct, image) " +
                                     "VALUES (@nameProduct, @count, @price, @idCateProduct, @image)";
                using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@nameProduct", newProduct.nameProduct);
                    insertCmd.Parameters.AddWithValue("@count", newProduct.count);
                    insertCmd.Parameters.AddWithValue("@price", newProduct.price);
                    insertCmd.Parameters.AddWithValue("@idCateProduct", newProduct.idCateProduct);
                    insertCmd.Parameters.AddWithValue("@image", newProduct.image);
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool updateProduct( MProduct product)
        {
            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {
                string updateQuery = "UPDATE Product SET id = @id, nameProduct = @nameProduct, " +
                                     "count = @count, price = @price, idCateProduct = @idCateProduct, " +
                                     "image = @image WHERE id = @id";
                using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@id", product.id);
                    updateCmd.Parameters.AddWithValue("@nameProduct", product.nameProduct);
                    updateCmd.Parameters.AddWithValue("@count", product.count);
                    updateCmd.Parameters.AddWithValue("@price", product.price);
                    updateCmd.Parameters.AddWithValue("@idCateProduct", product.idCateProduct);
                    updateCmd.Parameters.AddWithValue("@image", product.image);
                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
              
            }
        }

        public void UpdateCount(int productId, int newCount)
        {
            try
            {
                _conn.Open();

                // Thực hiện truy vấn cập nhật
                string updateQuery = "UPDATE Product SET count = @count WHERE id = @id";
                using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, _conn))
                {
                    updateCmd.Parameters.AddWithValue("@count", newCount);
                    updateCmd.Parameters.AddWithValue("@id", productId);
                    updateCmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }



        public List<MCateProduct> getAllCateProduct()
        {
            List<MCateProduct> cateProduct = new List<MCateProduct>();
            
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CategoryProduct", _conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        cateProduct.Add(new MCateProduct(id, name));
                    }
                }
            }
            return cateProduct;
        }
        public bool deleteProduct(string idProduct)
        {
            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {
                string deleteQuery = $"DELETE FROM Product WHERE ID = {idProduct}";
                using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, con))
                {;
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }



        public List<MProduct> getAllProduct(string searchText)
        {
            List<MProduct> productList = new List<MProduct>();
            string query = @"SELECT DISTINCT
                        p.id as IDProduct,
                        p.nameProduct as NameProduct,
                        p.count as Count,
                        p.price as Price,
                        p.image as ImageProduct
                        FROM Product p
                        LEFT JOIN CategoryProduct ct ON p.idCateProduct = ct.id
                        WHERE p.nameProduct LIKE @searchText OR
                              ct.name LIKE @searchText";
            using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MProduct product = new MProduct
                        {
                            id = int.Parse(reader["IDProduct"].ToString()),
                            nameProduct = reader["NameProduct"].ToString(),
                            count = int.Parse(reader["Count"].ToString()),
                            price = int.Parse(reader["Price"].ToString()),
                            image = reader["ImageProduct"].ToString(),
                        };

                        productList.Add(product);
                    }
                }
            }

            return productList;
        }


        public List<MProduct> SearchCustomers(string searchText)
        {
            List<MProduct> products = new List<MProduct>();

            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {
         

                string query = @"SELECT DISTINCT
                            c.id AS ID,
                            c.nameProduct AS NameProduct,
                            c.count AS Count,
                            c.price AS Price,
                            c.image as ImageProduct,
                            p.id AS CateProduct
                          
                        FROM Product c
                        LEFT JOIN CategoryProduct p ON c.idCateProduct = p.id
                       
                        WHERE c.nameProduct LIKE @searchText";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MProduct product = new MProduct
                            {
                                id = int.Parse(reader["ID"].ToString()),
                                nameProduct = reader["NameProduct"].ToString(),
                                count = int.Parse(reader["Count"].ToString()),
                                price = int.Parse(reader["Price"].ToString()),
                                idCateProduct = int.Parse(reader["CateProduct"].ToString()),
                                image = reader["ImageProduct"].ToString()

                            };
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }


        public Tuple<int, string, int> GetProductInfo(int idProduct)
        {
            Tuple<int, string, int> productInfo = null;

            using (SQLiteConnection connection = new SQLiteConnection(_conn))
            {

                string query = $"SELECT id, nameProduct, price FROM Product WHERE id = @productId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", idProduct);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productID = reader.GetInt32(0);
                            string nameProduct = reader.GetString(1);
                            int priceProduct = reader.GetInt32(2);

                            productInfo = Tuple.Create(productID, nameProduct, priceProduct);
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                    }
                }
            }
            return productInfo;
        }


        public bool AddOrUpdateProductChoose(MPaymentProduct newProduct)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_conn))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    // Kiểm tra xem sản phẩm đã tồn tại trong cơ sở dữ liệu chưa
                    string checkExistQuery = "SELECT COUNT(*) FROM PaymentProduct WHERE idProduct = @idProduct";
                    using (SQLiteCommand checkExistCmd = new SQLiteCommand(checkExistQuery, con))
                    {
                        checkExistCmd.Parameters.AddWithValue("@idProduct", newProduct.IDProduct);

                        int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Nếu sản phẩm đã tồn tại, thì tăng số lượng
                            string updateQuantityQuery = "UPDATE PaymentProduct SET saleCount = saleCount + @saleCount WHERE idProduct = @idProduct";
                            using (SQLiteCommand updateQuantityCmd = new SQLiteCommand(updateQuantityQuery, con))
                            {
                                updateQuantityCmd.Parameters.AddWithValue("@saleCount", newProduct.CountProduct);
                                updateQuantityCmd.Parameters.AddWithValue("@idProduct", newProduct.IDProduct);

                                int rowsAffected = updateQuantityCmd.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                        else
                        {
                            // Nếu sản phẩm chưa tồn tại, thêm mới
                            string insertQuery = "INSERT INTO PaymentProduct (nameProduct, price, saleCount, idProduct, payDay) " +
                                                "VALUES (@nameProduct, @price, @saleCount, @idProduct, @payDay)";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@nameProduct", newProduct.NameProduct);
                                insertCmd.Parameters.AddWithValue("@price", newProduct.PriceProduct);
                                insertCmd.Parameters.AddWithValue("@saleCount", newProduct.CountProduct);
                                insertCmd.Parameters.AddWithValue("@idProduct", newProduct.IDProduct);
                                insertCmd.Parameters.AddWithValue("@payDay", newProduct.payDay);

                                int rowsAffected = insertCmd.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }






        public List<MPaymentProduct> LoadPaymentProduct()
        {
            List<MPaymentProduct> paymentProducts = new List<MPaymentProduct>();

            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {

                string query = @"SELECT DISTINCT
                    c.id AS ID,
                    c.nameProduct AS NameProduct,
                    c.price AS Price,
                    c.saleCount AS saleCount,
                    p.id AS idProduct,
                    c.payDay as payDay
                FROM PaymentProduct c
                LEFT JOIN Product p ON c.idProduct = p.id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MPaymentProduct paymentProduct = new MPaymentProduct()
                                {
                                    id = int.Parse(reader["ID"].ToString()),
                                    NameProduct = reader["NameProduct"].ToString(),
                                    PriceProduct = int.Parse(reader["Price"].ToString()),
                                    CountProduct = int.Parse(reader["saleCount"].ToString()),
                                    IDProduct = int.Parse(reader["idProduct"].ToString()),
                                    payDay = reader["payDay"].ToString(),
                                };
                                paymentProducts.Add(paymentProduct);
                            }
                        }

                    }

   
                return paymentProducts;


            }
        }

        public bool DeleteProduct(string paymentProductID)
        {
            using (SQLiteConnection con = new SQLiteConnection(_conn))
            {
                string deleteQuery = "DELETE FROM PaymentProduct WHERE ID = @paymentProduct";
                using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@paymentProduct", paymentProductID);


                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteAllProducts()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(_conn))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string deleteQuery = "DELETE FROM PaymentProduct";

                    using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, con))
                    {
                        // Thực hiện xóa tất cả dữ liệu trong bảng
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

    }
}
