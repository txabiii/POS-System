using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using POS1.Sales_Forms;
using System.Collections;
using System.IO;
using System.Drawing;
using POS1.Exchange;
using POS1.Refund_Forms;

namespace POS1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            GetItems();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }

        // connection string declared in the class-level
        public static string connString = "server=127.0.0.1;port=3306;database=database;uid=uid;pwd=pwd;";

        // item table and item spec table to store data
        public static DataTable item = new DataTable();
        public static DataTable itemSpec = new DataTable();

        // method that accepts a query with no result, and executes it
        public static void ExecuteQuery(string query)
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //method that returns a datatable result from a string query that does not require parameterized query
        public static DataTable DataTableQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public static Image GetImage(string id, string ext)
        {
            Image result;
            DirectoryInfo baseDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            try
            {
                using (var bmpTemp = new Bitmap(baseDir + @"ItemImages\" + id + "." + ext))
                {
                    result = new Bitmap(bmpTemp);
                }
                //result = Image.FromFile(baseDir + @"ItemImages\" + id + "." + ext);
            }
            catch (Exception)
            {
                using (var bmpTemp = new Bitmap(baseDir + @"ItemImages\no_image.jpg"))
                {
                    result = new Bitmap(bmpTemp);
                }
                //result = Image.FromFile(baseDir + @"ItemImages\no_image.jpg");
            }

            return result;
        }

        #region sales

        // method that gets the item and item details from the database and puts it in the item datatable
        public static void GetItems(int current = 0, int recordsPerPage = 0, bool? orderName = null, bool? orderPrice = null, bool? orderDate = null, int filterCategory = 0, int filterSearch = 0)
        {
            //clear datatable to prevent retaining old data
            item.Clear();
            itemSpec.Clear();

            //where
            ArrayList whereFilter = new ArrayList();

            if (filterCategory != 0) whereFilter.Add("`item`.`category_id` = @category_id");
            if (filterSearch != 0) whereFilter.Add("`item`.`item_id` = @search ");

            string whereFilterString = string.Join(" and ", (string[])whereFilter.ToArray(typeof(string)));
            if (!String.IsNullOrEmpty(whereFilterString)) whereFilterString = "where " + whereFilterString;

            //order by

            ArrayList orderFilter = new ArrayList();

            if (orderName == true) orderFilter.Add("`item_name` asc");
            else if (orderName == false) orderFilter.Add("`item_name` desc");

            if (orderPrice == true) orderFilter.Add("`selling_price` asc");
            else if (orderPrice == false) orderFilter.Add("`selling_price` desc");

            if (orderDate == true) orderFilter.Add("`date_added` desc");
            else if (orderDate == false) orderFilter.Add("`date_added` asc");

            string orderFilterString = string.Join(", ", (string[])orderFilter.ToArray(typeof(string)));
            if (!string.IsNullOrEmpty(orderFilterString)) orderFilterString = " order by " + orderFilterString;
            
            string item_query = @"select * from item_details " + whereFilterString + orderFilterString;

            if (current != 0 && recordsPerPage != 0) { item_query += " limit @offset, @limit"; }

            string item_spec_query = @"select * from item_spec_details";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                {
                    connect.Open();
                    //executes the query for item table
                    using (MySqlCommand command = new MySqlCommand(item_query, connect))
                    {
                        command.Parameters.AddWithValue("@offset", (current - 1) * recordsPerPage);
                        command.Parameters.AddWithValue("@limit", recordsPerPage);
                        command.Parameters.AddWithValue("@category_id", filterCategory);
                        command.Parameters.AddWithValue("@search", filterSearch);
                        //MessageBox.Show(command.CommandText);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) adapter.Fill(item);
                    }

                    //executes the query for item spec table
                    using (MySqlCommand command = new MySqlCommand(item_spec_query, connect))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) adapter.Fill(itemSpec);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Pay(decimal total, string method, float amount, List<SalesBills> bills)
        {
            string saleQuery = @"insert into `transaction`(`type`,`total`) values ('sale',@total);";

            //store transaction id
            int transactionId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(saleQuery, connect))
                {
                    connect.Open();
                    //new sale transaction
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from last_transaction_id"; // application of view
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //insert sales details
                    cmd.CommandText = @"insert into `sale`(`transaction_id`,`payment_method`,`payment_amount`) 
                                      values (@transaction_id, @method, @amount);";
                    cmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();

                    //declare parameters
                    cmd.Parameters.AddWithValue("@item_id", 0);
                    cmd.Parameters.AddWithValue("@transaction_item_id", 0);
                    cmd.Parameters.AddWithValue("@color_id", 0);
                    cmd.Parameters.AddWithValue("@size_id", 0);
                    cmd.Parameters.AddWithValue("@quantity", 0);

                    //iterate through the transaction items
                    foreach (SalesBills transactionItem in bills)
                    {
                        //check first if transaction item has already been added to database
                        if (transactionItem.CheckedBill == false)
                        {
                            //insert into transaction item table
                            cmd.CommandText = @"insert into `transaction_item`(`transaction_id`, `item_id`) values(@transaction_id, @item_id)";
                            cmd.Parameters["@item_id"].Value = transactionItem.BillsClothesCode;
                            cmd.ExecuteNonQuery();

                            //get last transaction item id
                            int transactionItemId = 0;

                            cmd.CommandText = "select `transaction_item_id` from `transaction_item` order by `transaction_item_id` desc limit 1";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    transactionItemId = reader.GetInt32(0);
                                reader.Close();
                            }
                            cmd.Parameters["@transaction_item_id"].Value = transactionItemId;

                            //find all transaction items with similar item id
                            foreach (SalesBills item in bills)
                            {
                                //store each item spec seperately
                                if (item.BillsClothesCode == transactionItem.BillsClothesCode && item.CheckedBill == false)
                                {
                                    cmd.CommandText = @"insert into `transaction_item_spec`(`transaction_item_id`,`color_id`, `size_id`, `quantity`) 
                                                 values(@transaction_item_id, @color_id, @size_id, @quantity);";
                                    cmd.Parameters["@color_id"].Value = item.BillsClothesColorId;
                                    cmd.Parameters["@size_id"].Value = item.BillsClothesSizeId;
                                    cmd.Parameters["@quantity"].Value = item.Quantity;
                                    cmd.ExecuteNonQuery();

                                    //when a new transaction item is inserted a mysql trigger will be called to check if it is a sale and deduct the quantity bought

                                    item.CheckedBill = true;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Transaction Succesful");
                POS1.Forms.SalesForm.TrsansactionItemId = transactionId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #endregion

        #region transactions 

        public static DataTable GetItemMovementContent(int current, int recordsPerPage, string date1, string date2, string type, string search, int itemId)
        {
            DataTable result = new DataTable();

            string query = @"select `transaction`.`transaction_id`, `transaction`.`type`, `transaction`.`date_time`, `transaction_item_spec`.*, `item`.*, `color`.`color_name`, `size`.`size_name` from `transaction`
					inner join `transaction_item` on  `transaction`.`transaction_id` = `transaction_item`.`transaction_id`
					inner join `transaction_item_spec` on `transaction_item`.`transaction_item_id` = `transaction_item_spec`.`transaction_item_id`
                    inner join `item` on `transaction_item`.`item_id` = `item`.`item_id`
                    inner join `color` on `color`.`color_id` = `transaction_item_spec`.`color_id`
                    inner join `size` on `size`.`size_id` = `transaction_item_spec`.`size_id`
                    left join `supply` on `supply`.`transaction_id` = `transaction`.`transaction_id`";

            string filter = GenerateTransactionFilter(date1, date2, type, search, itemId);

            if (!String.IsNullOrWhiteSpace(filter)) query += " where " + filter;
            
            query += " ORDER BY `date_time` desc limit @offset, @limit;";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    //MessageBox.Show(cmd.CommandText);
                    cmd.Parameters.AddWithValue("@offset", (current - 1) * recordsPerPage);
                    cmd.Parameters.AddWithValue("@limit", recordsPerPage);
                    cmd.Parameters.AddWithValue("@date1", date1);
                    cmd.Parameters.AddWithValue("@date2", date2);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);

                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return result;
        }

        public static DataTable GetTransactionsHistory(int current, int recordsPerPage, string date1, string date2, string type, string search)
        {
            DataTable result = new DataTable();

            string query = @"select `transaction`.*, `sale`.*, `supply`.*, `item`.`item_id`, `file_ext`, `quantity` from `transaction`
							inner join (select `transaction_id`, `item_id`, sum(`quantity`) as `quantity` 
										from `transaction_item` 
										inner join `transaction_item_spec` on `transaction_item`.`transaction_item_id` = `transaction_item_spec`.`transaction_item_id`
										group by `transaction_id`) as `transaction_item` 
								on `transaction`.`transaction_id` = `transaction_item` .`transaction_id`
							inner join `item` on `transaction_item`.`item_id` = `item`.`item_id`
                            left join `sale` on `transaction`.`transaction_id` = `sale`.`transaction_id`
                            left join `supply` on `transaction`.`transaction_id` = `supply`.`transaction_id`
                            left join `refund` on `transaction`.`transaction_id` = `refund`.`transaction_id`
                            left join `exchange` on `transaction`.`transaction_id` = `exchange`.`transaction_id`";

            string filter = GenerateTransactionFilter(date1, date2, type, search);

            if (!String.IsNullOrWhiteSpace(filter)) query += " where " + filter;
            
            query += " order by `date_time` desc limit @offset, @limit;";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("@offset", (current - 1) * recordsPerPage);
                    cmd.Parameters.AddWithValue("@limit", recordsPerPage);
                    cmd.Parameters.AddWithValue("@date1", date1);
                    cmd.Parameters.AddWithValue("@date2", date2);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@search", search);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public static string GenerateTransactionFilter(string date1, string date2, string type, string search, int itemId = 0)
        {
            ArrayList filterList = new ArrayList();
            string filter = "";

            //check if at least one filter option is not null
            if (!String.IsNullOrWhiteSpace(date1) || !String.IsNullOrWhiteSpace(date2) || !String.IsNullOrWhiteSpace(type) || !String.IsNullOrWhiteSpace(search) || itemId != 0)
            {
                //both dates has to have values
                if (!String.IsNullOrWhiteSpace(date1) && !String.IsNullOrWhiteSpace(date2))
                {
                    filterList.Add("date(`date_time`) between @date1 and @date2");
                }

                //type has to a have a value
                if (!String.IsNullOrWhiteSpace(type))
                {
                    filterList.Add("`type` = @type");
                }

                if (search != null)
                {
                    filterList.Add("`transaction`.`transaction_id` = @search");
                }

                if (itemId != 0)
                {
                    filterList.Add("`item`.`item_id` = @itemId");
                }

                filter = string.Join(" and ", (string[])filterList.ToArray(typeof(string)));
            }   // for example { type = sale and item.item_id = 1 }
            return filter;
        }

public static DataTable GetTransactionContent(int transaction_id)
{
    DataTable result = new DataTable();

    string query = @"select `transaction`.* , `transaction_item_spec`.*, `size_name`, `color_name`, `item`.*, (quantity * selling_price) as `sale_subtotal`, (quantity * supplier_price) as `supplier_subtotal` from `transaction`
			inner join `transaction_item` on  `transaction`.`transaction_id` = `transaction_item`.`transaction_id`
			inner join `transaction_item_spec` on `transaction_item`.`transaction_item_id` = `transaction_item_spec`.`transaction_item_id`
            inner join `item` on `transaction_item`.`item_id` = `item`.`item_id`
            inner join `color` on `color`.`color_id` = `transaction_item_spec`.`color_id`
            inner join `size` on `size`.`size_id` = `transaction_item_spec`.`size_id`
            WHERE `transaction`.`transaction_id` = " + transaction_id +
            " ORDER BY `transaction`.`transaction_id`;";

    try
    {
        using (MySqlConnection connect = new MySqlConnection(connString))
        using (MySqlCommand cmd = new MySqlCommand(query, connect))
        {
            connect.Open();
            //MessageBox.Show(cmd.CommandText);
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);

        }
    }
    catch (MySqlException e)
    {
        MessageBox.Show(e.Message);
    }

    return result;
}

        public static int TotalRecords(string date1, string date2, string type, string search, string table)
        {
            int result = 0;
            DataTable resultTable = new DataTable();
            string query = "select count(*) as `total` from";
            if (string.Equals(table, "history"))
            {
                query += "`transaction`";
            }
            else query += "`transaction_item` inner join `transaction` on `transaction_item`.`transaction_id` = `transaction`.`transaction_id`";

            string filter = GenerateTransactionFilter(date1, date2, type, search);

            if (!String.IsNullOrWhiteSpace(filter)) query += " where " + filter;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("@date1", date1);
                    cmd.Parameters.AddWithValue("@date2", date2);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@search", search);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(resultTable);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }

            if (resultTable.Rows.Count > 0)
            {
                result = (int)(long)resultTable.Rows[0]["total"];
            }
            else result = 0;

            return result;
        }

        #endregion

        #region inventory

        public static void UpdateItem(int itemId, int categoryId, string itemName, float sellingPrice, float supplierPrice, string supplierName, string description, string fileExt)
        {
            string query = @"UPDATE `item` SET `item_id` = @item_id, `category_id` = @category_id, `item_name` = @item_name, `description` = @description, `selling_price` = @selling_price, `supplier_price` = @supplier_price, `supplier_name` = @supplier_name, `file_ext` = @file_ext
				            WHERE (`item_id` = '" + itemId + "')";

            string query2 = @"UPDATE `item` SET `item_name` = @item_name WHERE (`item_id` = '" + itemId + "')";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@item_id", itemId);
                    cmd.Parameters.AddWithValue("@category_id", categoryId);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                    cmd.Parameters.AddWithValue("@supplier_price", supplierPrice);
                    cmd.Parameters.AddWithValue("@supplier_name", supplierName);
                    cmd.Parameters.AddWithValue("@file_ext", fileExt);

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show(cmd.CommandText);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void AddStocks(DataTable transactionItemSpec, int itemId, Boolean add, string remarks = "")
        {
            //MessageBox.Show(add.ToString());
            string supplyQuery = @"insert into `transaction` (`type`) values ('supply');";

            //store transaction id
            int transactionId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(supplyQuery, connect))
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from last_transaction_id";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //add record to supply table
                    if (add) cmd.CommandText = "insert into `supply`(`transaction_id`,`stock_added`) values(@transaction_id, @stock_added)";
                    else
                    {
                        //MessageBox.Show("works" + remarks);
                        cmd.CommandText = "insert into `supply`(`transaction_id`,`stock_added`, `remarks`) values(@transaction_id, @stock_added, @remarks)";
                    }
                    cmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    cmd.Parameters.AddWithValue("@stock_added", Convert.ToInt32(add));
                    cmd.Parameters.AddWithValue("@remarks", remarks);
                    cmd.ExecuteNonQuery();

                    //add transaction item
                    cmd.CommandText = "insert into `transaction_item`(`transaction_id`,`item_id`) values (@transaction_id, @item_id)";
                    cmd.Parameters.AddWithValue("@item_id", itemId);
                    cmd.ExecuteNonQuery();

                    //get last added transaction item id
                    int transactionItemId = 0;
                    cmd.CommandText = "select `transaction_item_id` from `transaction_item` order by `transaction_item_id` desc limit 1;";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionItemId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //declare parameters
                    cmd.Parameters.AddWithValue("@transaction_item_id", transactionItemId);
                    cmd.Parameters.AddWithValue("@color_id", 0);
                    cmd.Parameters.AddWithValue("@size_id", 0);
                    cmd.Parameters.AddWithValue("@quantity", 0);

                    //add transaction item spec
                    foreach (DataRow itemSpec in transactionItemSpec.Rows)
                    {
                        cmd.CommandText = "insert into `transaction_item_spec`(`transaction_item_id`, `color_id`, `size_id`, `quantity`) values (@transaction_item_id, @color_id, @size_id, @quantity)";
                        cmd.Parameters["@color_id"].Value = (int)itemSpec["color_id"];
                        cmd.Parameters["@size_id"].Value = (int)itemSpec["size_id"];
                        cmd.Parameters["@quantity"].Value = (int)itemSpec["quantity"];

                        cmd.ExecuteNonQuery();
                        
                        //update item spec
                        if (add)
                        {
                            //check if item spec already exists, update if yes, add new record if no
                            int? verified = null;
                            cmd.CommandText = "select item_id from item_spec where color_id = @color_id and size_id = @size_id and item_id = @item_id limit 1";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    verified = reader.GetInt32(0);
                                }
                                reader.Close();
                            }
                            if (verified == null)
                            {
                                cmd.CommandText = @"insert into `item_spec`(`item_id`,`color_id`,`size_id`, `stock`)
                                                    values (@item_id, @color_id, @size_id, @quantity)";
                            } 
                            else
                            {
                                cmd.CommandText = @"update `item_spec`
                                                    set `stock` = `stock` + @quantity
                                                    where `color_id` = @color_id and `size_id` = @size_id and item_id = @item_id;";
                            }
                        } 
                        else
                        {
                            cmd.CommandText = @"update `item_spec`
                                          set `stock` = `stock` - @quantity
                                          where `color_id` = @color_id and `size_id` = @size_id;";
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void UpdateSpecification(string tableName, string specificationName, int? specificationOrder, int specificationId)
        {
            //MessageBox.Show("update\ntableName = " + tableName + "\nspecificationId = " + specificationId + "\nspecificationOrder = " + specificationOrder);
            string query = "update `" + tableName + "` ";

            string updateString = null;
            if (!String.IsNullOrEmpty(specificationName)) updateString += "`" + tableName + "_name` = @name ";
            
            if (specificationOrder != null)
            {
                if (updateString != null) updateString += ", ";
                updateString += "`" + tableName + "_order` = @order ";
            }

            if (updateString != null) 
            {
                query = query + "set " + updateString + " where `" + tableName + "_id` = '" + specificationId.ToString() + "'";

                try
                {
                    using (MySqlConnection connect = new MySqlConnection(connString))
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();

                        cmd.Parameters.AddWithValue("@name", specificationName);
                        cmd.Parameters.AddWithValue("@order", specificationOrder);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1062)
                    {
                        MessageBox.Show(specificationName + " already exists");
                    }
                }
            }
        }

        public static Boolean DeleteSpecification(string name, int id, string tableName)
        {
            string query = "call delete_spec('@tableName',@id)";
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@tableName", tableName);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("1 " + tableName + " succesfully deleted");
                    return true;
                }
            }
            catch (MySqlException e)
            {
                if (e.Number == 1451)
                {
                    string errorMessage;
                    errorMessage = "Failed to delete the " + tableName + " \"" + name + "\"\n";

                    if (tableName == "Category")
                    {
                        int numItem = Convert.ToInt32(DataTableQuery("select count(*) from `item` where `category_id` = " + id).Rows[0]["count(*)"]);
                        if (numItem > 1) errorMessage += numItem.ToString() + " items are under this category";
                        else errorMessage += numItem.ToString() + " item is under this category";
                    } else if (tableName == "Size" || tableName == "Color")
                    {
                        int numItem = Convert.ToInt32(DataTableQuery("select count(distinct item_id) from item_spec where " + tableName + "_id = " + id).Rows[0]["count(distinct item_id)"]);
                        if (numItem > 1) errorMessage += numItem.ToString() + " items have this " + tableName + " specification";
                        else errorMessage += numItem.ToString() + " item has this " + tableName + " specification";
                    }
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }

        public static void AddSpecification(string tableName, string specificationName, int? specificationOrder)
        {
            string query = "insert into `" + tableName + "`(`" + tableName + "_name`,`" + tableName +"_order`) values (@name, @order)";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@name", specificationName);
                    cmd.Parameters.AddWithValue("@order", specificationOrder);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show(specificationName + " already exists");
                }
            }
        }

        public static int CreateItem(int categoryId, string itemName, float sellingPrice, float supplierPrice, string supplierName, string description, string fileExt)
        {
            string query = @"insert into `item` (`category_id`, `item_name`, `selling_price`, `supplier_price`, `supplier_name`, `description`,`file_ext`)
                            values (@category_id, @item_name, @selling_price, @supplier_price, @supplier_name, @description, @file_ext)";
            int itemId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@category_id", categoryId);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                    cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                    cmd.Parameters.AddWithValue("@supplier_price", supplierPrice);
                    cmd.Parameters.AddWithValue("@supplier_name", supplierName);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@file_ext", fileExt);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select `item_id` from `item` order by `item_id` desc limit 1;";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itemId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //return the new item id
                    return itemId;
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return itemId;
            }
        }
        
        public static Boolean DeleteItem(int id)
        {
            string query = "delete from `item` where (`item_id` = '" + id + "')";
            
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("1 item succesfully deleted");

                    return true;
                }
            }
            catch (MySqlException e)
            {
                if (e.Number == 1451)
                {
                    string errorString;
                    errorString = "Failed to delete item no." + id + "\n";

                    int numTransactions = Convert.ToInt32(DataTableQuery("select count(distinct transaction_id) from transaction_item where item_id = " + id.ToString()).Rows[0]["count(distinct transaction_id)"]);
                    if(numTransactions > 1) errorString += numTransactions.ToString() + " transactions contain this item";
                    else errorString += numTransactions.ToString() + " transaction contains this item";

                    MessageBox.Show(errorString);
                }
                return false;
            }
        }

        #endregion

        #region refund 

        public static DataTable GetRefundHistory(int current, int recordsPerPage, string date1, string date2, string type, string search)
        {
            DataTable result = new DataTable();

            string query = @"select `transaction`.*, `sale`.*, `supply`.*, `item`.`item_id`, `file_ext`, `quantity` from `transaction`
							inner join (select `transaction_id`, `item_id`, sum(`quantity`) as `quantity` 
										from `transaction_item` 
										inner join `transaction_item_spec` on `transaction_item`.`transaction_item_id` = `transaction_item_spec`.`transaction_item_id`
										group by `transaction_id`) as `transaction_item` 
								on `transaction`.`transaction_id` = `transaction_item` .`transaction_id`
							inner join `item` on `transaction_item`.`item_id` = `item`.`item_id`
                            left join `sale` on `transaction`.`transaction_id` = `sale`.`transaction_id`
                            left join `supply` on `transaction`.`transaction_id` = `supply`.`transaction_id`";

            string filter = GenerateTransactionFilter(date1, date2, type, search);

            if (!String.IsNullOrWhiteSpace(filter))
            {
                query += " where " + filter;
            }
           // else
           // {
             //   query += " where " + filter + ;
            //}

            query += " order by `date_time` desc limit @offset, @limit;";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("@offset", (current - 1) * recordsPerPage);
                    cmd.Parameters.AddWithValue("@limit", recordsPerPage);
                    cmd.Parameters.AddWithValue("@date1", date1);
                    cmd.Parameters.AddWithValue("@date2", date2);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@search", search);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public static DataTable GetSaleID(int transaction_id)
        {
            DataTable result = new DataTable();

            string query = @"SELECT `transaction`.`transaction_id`, `sale_id` FROM `transaction`
                            LEFT JOIN `sale` ON `transaction`.`transaction_id` = `sale`.`transaction_id`
                            WHERE `transaction`.`transaction_id` = @transid;";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("@transid", transaction_id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd)) adapter.Fill(result);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public static void InsertRefundData(int sale_id, int transaction_id, string refund_type)
        {

            string query = @"INSERT INTO `refund` (`original_sale_id`, `transaction_id`, `refund_type`)
                            VALUES (@saleid, @transid, @refundtype);";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@saleid", sale_id);
                    cmd.Parameters.AddWithValue("@transid", transaction_id);
                    cmd.Parameters.AddWithValue("@refundtype", refund_type);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Items have been refunded successfully.");
        }

        public static void InsertRefundExchangeData(int sale_id, int transaction_id, string refund_type, float totalAmount)
        {

            string refundType = "refund";

            string query = @"INSERT INTO `transaction` (`type`, `total`, `date_time`)
                            VALUES ('refund', @total, @date_time);";

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@total", totalAmount);
                    cmd.Parameters.AddWithValue("@date_time", DateTime.Now);
                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static int InsertRefundItem(decimal total, string method, float amount, List<RefundDetailsContentRight> bills)
        {
            string saleQuery = @"insert into `transaction`(`type`,`total`) values ('refund',@total);";

            //store transaction id
            int transactionId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(saleQuery, connect))
                {
                    connect.Open();
                    //new sale transaction
                    cmd.Parameters.AddWithValue("@total", total);
                    MessageBox.Show(cmd.ToString());
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from last_transaction_id"; // application of view
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //insert sales details
                    cmd.CommandText = @"insert into `sale`(`transaction_id`,`payment_method`,`payment_amount`) 
                                      values (@transaction_id, @method, @amount);";
                    cmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();

                    //declare parameters
                    cmd.Parameters.AddWithValue("@item_id", 0);
                    cmd.Parameters.AddWithValue("@transaction_item_id", 0);
                    cmd.Parameters.AddWithValue("@color_id", 0);
                    cmd.Parameters.AddWithValue("@size_id", 0);
                    cmd.Parameters.AddWithValue("@quantity", 0);

                    //iterate through the transaction items
                    foreach (RefundDetailsContentRight transactionItem in bills)
                    {
                        //check first if transaction item has already been added to database
                        if (transactionItem.CheckedBill == false)
                        {
                            //insert into transaction item table
                            cmd.CommandText = @"insert into `transaction_item`(`transaction_id`, `item_id`) values(@transaction_id, @item_id)";
                            cmd.Parameters["@item_id"].Value = transactionItem.ItemId;
                            cmd.ExecuteNonQuery();

                            //get last transaction item id
                            int transactionItemId = 0;

                            cmd.CommandText = "select `transaction_item_id` from `transaction_item` order by `transaction_item_id` desc limit 1";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    transactionItemId = reader.GetInt32(0);
                                reader.Close();
                            }
                            cmd.Parameters["@transaction_item_id"].Value = transactionItemId;

                            //find all transaction items with similar item id
                            foreach (RefundDetailsContentRight item in bills)
                            {
                                //store each item spec seperately
                                if (item.ItemId == transactionItem.ItemId && item.CheckedBill == false)
                                {
                                    cmd.CommandText = @"insert into `transaction_item_spec`(`transaction_item_id`,`color_id`, `size_id`, `quantity`) 
                                                 values(@transaction_item_id, @color_id, @size_id, @quantity);";
                                    cmd.Parameters["@color_id"].Value = 1;
                                    cmd.Parameters["@size_id"].Value = 1;
                                    cmd.Parameters["@quantity"].Value = item.ItemQty;
                                    cmd.ExecuteNonQuery();

                                    //when a new transaction item is inserted a mysql trigger will be called to check if it is a sale and deduct the quantity bought

                                    item.CheckedBill = true;
                                }
                            }

                        }
                    }

                }
                //MessageBox.Show("Exchange Successful");

                POS1.Forms.SalesForm.TrsansactionItemId = transactionId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return transactionId;
        }

        public static int InsertTransactionItem(decimal total, string method, float amount, List<ExchangeDetailsContent2> bills)
        {
            string saleQuery = @"insert into `transaction`(`type`,`total`) values ('ref (ex)',@total);";

            //store transaction id
            int transactionId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(saleQuery, connect))
                {
                    connect.Open();
                    //new sale transaction
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from last_transaction_id"; // application of view
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //insert sales details
                    cmd.CommandText = @"insert into `sale`(`transaction_id`,`payment_method`,`payment_amount`) 
                                      values (@transaction_id, @method, @amount);";
                    cmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();

                    //declare parameters
                    cmd.Parameters.AddWithValue("@item_id", 0);
                    cmd.Parameters.AddWithValue("@transaction_item_id", 0);
                    cmd.Parameters.AddWithValue("@color_id", 0);
                    cmd.Parameters.AddWithValue("@size_id", 0);
                    cmd.Parameters.AddWithValue("@quantity", 0);

                    //iterate through the transaction items
                    foreach (ExchangeDetailsContent2 transactionItem in bills)
                    {
                        //check first if transaction item has already been added to database
                        if (transactionItem.CheckedBill == false)
                        {
                            //insert into transaction item table
                            cmd.CommandText = @"insert into `transaction_item`(`transaction_id`, `item_id`) values(@transaction_id, @item_id)";
                            cmd.Parameters["@item_id"].Value = transactionItem.ContentCode;
                            cmd.ExecuteNonQuery();

                            //get last transaction item id
                            int transactionItemId = 0;

                            cmd.CommandText = "select `transaction_item_id` from `transaction_item` order by `transaction_item_id` desc limit 1";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    transactionItemId = reader.GetInt32(0);
                                reader.Close();
                            }
                            cmd.Parameters["@transaction_item_id"].Value = transactionItemId;

                            //find all transaction items with similar item id
                            foreach (ExchangeDetailsContent2 item in bills)
                            {
                                //store each item spec seperately
                                if (item.ContentCode == transactionItem.ContentCode && item.CheckedBill == false)
                                {
                                    cmd.CommandText = @"insert into `transaction_item_spec`(`transaction_item_id`,`color_id`, `size_id`, `quantity`) 
                                                 values(@transaction_item_id, @color_id, @size_id, @quantity);";
                                    cmd.Parameters["@color_id"].Value = 1;
                                    cmd.Parameters["@size_id"].Value = 1;
                                    cmd.Parameters["@quantity"].Value = item.ContentQuantity;
                                    cmd.ExecuteNonQuery();

                                    //when a new transaction item is inserted a mysql trigger will be called to check if it is a sale and deduct the quantity bought

                                    item.CheckedBill = true;
                                }
                            }

                        }
                    }

                }
                //MessageBox.Show("Exchange Successful");

                POS1.Forms.SalesForm.TrsansactionItemId = transactionId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return transactionId;
        }

        #endregion

        #region exchange

        public static int PayExchange(decimal total, string method, float amount, List<ExchangeDetailsContentConfirm> bills)
        {
            string saleQuery = @"insert into `transaction`(`type`,`total`) values ('sale(ex)',@total);";

            //store transaction id
            int transactionId = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(connString))
                using (MySqlCommand cmd = new MySqlCommand(saleQuery, connect))
                {
                    connect.Open();
                    //new sale transaction
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select * from last_transaction_id"; // application of view
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    //insert sales details
                    cmd.CommandText = @"insert into `sale`(`transaction_id`,`payment_method`,`payment_amount`) 
                                      values (@transaction_id, @method, @amount);";
                    cmd.Parameters.AddWithValue("@transaction_id", transactionId);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();

                    //declare parameters
                    cmd.Parameters.AddWithValue("@item_id", 0);
                    cmd.Parameters.AddWithValue("@transaction_item_id", 0);
                    cmd.Parameters.AddWithValue("@color_id", 0);
                    cmd.Parameters.AddWithValue("@size_id", 0);
                    cmd.Parameters.AddWithValue("@quantity", 0);

                    //iterate through the transaction items
                    foreach (ExchangeDetailsContentConfirm transactionItem in bills)
                    {
                        //check first if transaction item has already been added to database
                        if (transactionItem.CheckedBill == false)
                        {
                            //insert into transaction item table
                            cmd.CommandText = @"insert into `transaction_item`(`transaction_id`, `item_id`) values(@transaction_id, @item_id)";
                            cmd.Parameters["@item_id"].Value = transactionItem.BillsClothesCode;
                            cmd.ExecuteNonQuery();

                            //get last transaction item id
                            int transactionItemId = 0;

                            cmd.CommandText = "select `transaction_item_id` from `transaction_item` order by `transaction_item_id` desc limit 1";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    transactionItemId = reader.GetInt32(0);
                                reader.Close();
                            }
                            cmd.Parameters["@transaction_item_id"].Value = transactionItemId;

                            //find all transaction items with similar item id
                            foreach (ExchangeDetailsContentConfirm item in bills)
                            {
                                //store each item spec seperately
                                if (item.BillsClothesCode == transactionItem.BillsClothesCode && item.CheckedBill == false)
                                {
                                    cmd.CommandText = @"insert into `transaction_item_spec`(`transaction_item_id`,`color_id`, `size_id`, `quantity`) 
                                                 values(@transaction_item_id, @color_id, @size_id, @quantity);";
                                    cmd.Parameters["@color_id"].Value = item.BillsClothesColorId;
                                    cmd.Parameters["@size_id"].Value = item.BillsClothesSizeId;
                                    cmd.Parameters["@quantity"].Value = item.Quantity;
                                    cmd.ExecuteNonQuery();

                                    //when a new transaction item is inserted a mysql trigger will be called to check if it is a sale and deduct the quantity bought

                                    item.CheckedBill = true;
                                }
                            }

                        }
                    }
                    
                }
                //MessageBox.Show("Exchange Successful");
            
                POS1.Forms.SalesForm.TrsansactionItemId = transactionId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return transactionId;
        }



        #endregion
    }
}
