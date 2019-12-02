using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormDBProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        string selectTable, cbSelectdata;
        string id, name, publisherAddress, pricePhone;

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3305;database=mydb;uid=root;pwd=taranfu35";
            conn = new MySqlConnection(connStr);

            getTablecomboBox();

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    labelConnectionState.Text = "Select Table";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SetSearchComboBox(string cbSelectdata, string selectTable)
        {
            cbPublisher1.Items.Clear();
            cbAddress2.Items.Clear();
            cbOrderDate3.Items.Clear();

            string sql = $"SELECT distinct {cbSelectdata} FROM {selectTable}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (selectTable == "book" || selectTable == "customer")
                    {
                        cbPublisher1.Items.Add(reader.GetString($"{cbSelectdata}"));
                        cbAddress2.Items.Add(reader.GetString($"{cbSelectdata}"));
                    }
                    if (selectTable == "orders")
                        cbOrderDate3.Items.Add(reader.GetString($"{cbSelectdata}").Substring(0, 10));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSearchComboBox(cbSelectdata, selectTable);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
            if (selectTable == "book")
            {
                tbID1.Text = row.Cells[0].Value.ToString();
                tbName1.Text = row.Cells[1].Value.ToString();
                cbPublisher1.Text = row.Cells[2].Value.ToString();
                tbPrice1.Text = row.Cells[3].Value.ToString();
            }

            if (selectTable == "customer")
            {
                tbID2.Text = row.Cells[0].Value.ToString();
                tbName2.Text = row.Cells[1].Value.ToString();
                cbAddress2.Text = row.Cells[2].Value.ToString();
                tbPhone2.Text = row.Cells[3].Value.ToString();
            }

            if (selectTable == "orders")
            {
                tbOrderID3.Text = row.Cells[0].Value.ToString();
                tbCustID3.Text = row.Cells[1].Value.ToString();
                tbBookID3.Text = row.Cells[2].Value.ToString();
                tbSalePrice3.Text = row.Cells[3].Value.ToString();
                cbOrderDate3.Text = row.Cells[4].Value.ToString().Substring(0, 10);
            }
            SetSearchComboBox(cbSelectdata, selectTable);
        }

        private void getTablecomboBox()
        {
            cbTable.Items.Clear();
            try
            {
                conn.Open();
                string strqry = "select table_name from information_schema.tables where TABLE_SCHEMA='mydb'";

                MySqlCommand cmd = new MySqlCommand(strqry, conn);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader R = cmd.ExecuteReader();

                if (R.HasRows)
                {
                    while (R.Read())
                    {
                        cbTable.Items.Add(R.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("테이블이 하나도 없습니다");
                }
                R.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            string[] conditions = new string[7];
            if (selectTable == "book")
            {
                conditions[0] = (tbID1.Text != "") ? "bookid=@bookid" : null;
                conditions[1] = (tbName1.Text != "") ? "bookname=@bookname" : null;
                conditions[2] = (cbPublisher1.Text != "") ? "publisher=@publisher" : null;
                conditions[3] = (tbPrice1.Text != "") ? "price=@price" : null;

                string bookprice;
                if (tbPriceMin1.Text != "" && tbPriceMax1.Text != "")
                {
                    bookprice = "price>=@pricemin and price<=@pricemax";
                }
                else if (tbPriceMin1.Text != "" || tbPriceMax1.Text != "")
                {
                    if (tbPriceMin1.Text != "")
                        bookprice = "price>=@pricemin";
                    else
                        bookprice = "price <= @pricemax";
                }
                else
                {
                    bookprice = null;
                }
                conditions[4] = bookprice;
            }

            if (selectTable == "customer")
            {
                conditions[0] = (tbID2.Text != "") ? "custid=@custid" : null;
                conditions[1] = (tbName2.Text != "") ? "name=@name" : null;
                conditions[2] = (cbAddress2.Text != "") ? "address=@address" : null;
                conditions[3] = (tbPhone2.Text != "") ? "phone=@phone" : null;
            }

            if (selectTable == "orders")
            {
                conditions[0] = (tbOrderID3.Text != "") ? "orderid=@orderid" : null;
                conditions[1] = (tbCustID3.Text != "") ? "custid=@custid3" : null;
                conditions[2] = (tbBookID3.Text != "") ? "bookid=@bookid3" : null;
                conditions[3] = (tbSalePrice3.Text != "") ? "saleprice=@saleprice" : null;
                conditions[4] = (cbOrderDate3.Text != "") ? "orderdate=@orderdate" : null;

                string saleprice;
                if (tbSalePriceMin3.Text != "" && tbSalePriceMax3.Text != "")
                {
                    saleprice = "saleprice>=@salepricemin and saleprice<=@salepricemax";
                }
                else if (tbSalePriceMin3.Text != "" || tbSalePriceMax3.Text != "")
                {
                    if (tbSalePriceMin3.Text != "")
                        saleprice = "saleprice>=@salepricemin";
                    else
                        saleprice = "saleprice <= @salepricemax";
                }
                else
                {
                    saleprice = null;
                }
                conditions[5] = saleprice;
            }

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null || conditions[5] != null)
            {
                queryStr = $"SELECT * FROM {selectTable} WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = $"SELECT * FROM {selectTable}";
            }

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbID1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookname", tbName1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@publisher", cbPublisher1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@pricemin", tbPriceMin1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@pricemax", tbPriceMax1.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@price", tbPrice1.Text);

            dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbID2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbName2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@address", cbAddress2.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@phone", tbPhone2.Text);

            dataAdapter.SelectCommand.Parameters.AddWithValue("@orderid", tbOrderID3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@custid3", tbCustID3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid3", tbBookID3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@salepricemin", tbSalePriceMin3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@salepricemax", tbSalePriceMax3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@saleprice", tbSalePrice3.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@orderdate", cbOrderDate3.Text);

            SetSearchComboBox(cbSelectdata, selectTable);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, $"{selectTable}") > 0)
                    dataGridView1.DataSource = dataSet.Tables[$"{selectTable}"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectTable == "book" || selectTable == "customer")
            {
                string sql = $"UPDATE {selectTable} SET {id}=@{id}, {name}=@{name}, {publisherAddress}=@{publisherAddress}, {pricePhone}=@{pricePhone} WHERE {id}=@{id}";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbID1.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookname", tbName1.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@publisher", cbPublisher1.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@price", tbPrice1.Text);

                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbID2.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", tbName2.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@address", cbAddress2.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@phone", tbPhone2.Text);
            }

            if (selectTable == "orders")
            {
                string sql = $"UPDATE {selectTable} SET orderid=@orderid, custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderid", tbOrderID3.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbCustID3.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbBookID3.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@saleprice", tbSalePrice3.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderdate", cbOrderDate3.Text);
            }
            SetSearchComboBox(cbSelectdata, selectTable);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, $"{selectTable}");
                dataGridView1.DataSource = dataSet.Tables[$"{selectTable}"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM {selectTable} WHERE {id}=@{id}";

            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@bookid", tbID1.Text);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@custid", tbID2.Text);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@orderid", tbOrderID3.Text);

            SetSearchComboBox(cbSelectdata, selectTable);
            TClear();

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, $"{selectTable}");
                dataGridView1.DataSource = dataSet.Tables[$"{selectTable}"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql;
            if (selectTable == "book" || selectTable == "customer")
            {
                sql = $"INSERT INTO {selectTable} ({id}, {name}, {publisherAddress}, {pricePhone}) " + $"VALUES(@{id}, @{name}, @{publisherAddress}, @{pricePhone})";
                dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@bookid", tbID1.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@bookname", tbName1.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@publisher", cbPublisher1.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@price", tbPrice1.Text);

                dataAdapter.InsertCommand.Parameters.AddWithValue("@custid", tbID2.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@name", tbName2.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@address", cbAddress2.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@phone", tbPhone2.Text);
            }

            if (selectTable == "orders")
            {
                sql = $"INSERT INTO {selectTable} (orderid, custid, bookid, saleprice, orderdate) " + "VALUES(@orderid, @custid, @bookid, @saleprice, @orderdate)";
                dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@orderid", tbOrderID3.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@custid", tbCustID3.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@bookid", tbBookID3.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@saleprice", tbSalePrice3.Text);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@orderdate", cbOrderDate3.Text);
            }
            SetSearchComboBox(cbSelectdata, selectTable);

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, $"{selectTable}");
                dataGridView1.DataSource = dataSet.Tables[$"{selectTable}"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TClear();

            dataAdapter = new MySqlDataAdapter($"SELECT * FROM {selectTable}", conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, $"{selectTable}");
            dataGridView1.DataSource = dataSet.Tables[$"{selectTable}"];

            SetSearchComboBox(cbSelectdata, selectTable);
        }

        private void TClear()
        {
            tbID1.Clear();
            tbName1.Clear();
            cbPublisher1.Text = "";
            tbPriceMin1.Clear();
            tbPriceMax1.Clear();
            tbPrice1.Clear();

            tbID2.Clear();
            tbName2.Clear();
            cbAddress2.Text = "";
            tbPhone2.Clear();

            tbOrderID3.Clear();
            tbCustID3.Clear();
            tbBookID3.Clear();
            tbSalePriceMin3.Clear();
            tbSalePriceMax3.Clear();
            tbSalePrice3.Clear();
            cbOrderDate3.Text = "";
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTable.SelectedIndex >= 0)
            {
                TClear();
                if (cbTable.SelectedItem.ToString() == "book")
                {
                    id = "bookid";
                    name = "bookname";
                    publisherAddress = "publisher";
                    pricePhone = "price";

                    selectTable = cbTable.SelectedItem.ToString();
                    lTitle.Text = "mydb - " + selectTable;
                    cbSelectdata = "publisher";
                    dataAdapter = new MySqlDataAdapter("SELECT * FROM book", conn);
                    dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "book");
                    dataGridView1.DataSource = dataSet.Tables["book"];

                    groupBox1.Text = $"{selectTable}";
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;

                    changeHeaderText(selectTable);
                }

                if (cbTable.SelectedItem.ToString() == "customer")
                {
                    id = "custid";
                    name = "name";
                    publisherAddress = "address";
                    pricePhone = "phone";

                    selectTable = cbTable.SelectedItem.ToString();
                    lTitle.Text = "mydb - " + selectTable;
                    cbSelectdata = "address";
                    dataAdapter = new MySqlDataAdapter("SELECT * FROM customer", conn);
                    dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "customer");
                    dataGridView1.DataSource = dataSet.Tables["customer"];

                    groupBox2.Text = $"{selectTable}";
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;

                    changeHeaderText(selectTable);
                }

                if (cbTable.SelectedItem.ToString() == "orders")
                {
                    dataGridView1.Columns.Clear();

                    id = "orderid";
                    selectTable = cbTable.SelectedItem.ToString();
                    lTitle.Text = "mydb - " + selectTable;
                    cbSelectdata = "orderdate";
                    dataAdapter = new MySqlDataAdapter("SELECT * FROM orders", conn);
                    dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "orders");
                    dataGridView1.DataSource = dataSet.Tables["orders"];

                    groupBox3.Text = $"{selectTable}";
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    groupBox4.Visible = false;

                    changeHeaderText(selectTable);
                }
                SetSearchComboBox(cbSelectdata, selectTable);
            }
        }

        private void changeHeaderText(string selectTable)
        {
            string[] bookColHeader = { "도서번호", "도서이름", "출판사", "가격" };
            string[] customerColHeader = { "회원번호", "회원이름", "주소", "연락처" };
            string[] ordercolHeader = { "주문번호", "회원번호", "도서번호", "판매가", "주문일" };
            string[] colHeader = { };

            if (selectTable == "book")
                colHeader = bookColHeader;
            if (selectTable == "customer")
                colHeader = customerColHeader;
            if (selectTable == "orders")
                colHeader = ordercolHeader;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderText = string.Concat($"{colHeader[column.Index]}");
            }
        }
    }
}