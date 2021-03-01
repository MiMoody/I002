using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I002
{
    class EntityReport
    {
        public void MadeReportPurchase(DataGridView tableForReport)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I002;User ID=student;Password=Passw0rd"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT pur.DatePurchase,con.Surname,con.Name, con.MiddleName, con.INN, pr.Name, PrPur.Quantity, PrPur.Price FROM Purchase AS pur INNER JOIN Сounteragent AS con" +
                        " ON pur.IDCounteragent = con.IdСounteragent INNER JOIN ProductPurchase AS PrPur ON pur.IDPurchase = PrPur.IDPurchase " +
                        "INNER JOIN Product AS pr ON PrPur.IDProduct = pr.ArticleNumber ";
                    SqlCommand ReadProduct = new SqlCommand(query, conn);
                    SqlDataReader reader = ReadProduct.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        table.Rows[i][7] = Math.Round(Convert.ToDouble(table.Rows[i][7]), 2);
                    }
                    tableForReport.DataSource = table;
                    tableForReport.Update();
                    tableForReport.Columns[0].Width = 120;
                    tableForReport.Columns[1].Width = 140;
                    tableForReport.Columns[2].Width = 140;
                    tableForReport.Columns[3].Width = 140;
                    tableForReport.Columns[4].Width = 170;
                    tableForReport.Columns[5].Width = 240;
                    tableForReport.Columns[6].Width = 170;
                    tableForReport.Columns[7].Width = 130;
                    tableForReport.Columns[0].HeaderText = "Дата продажи";
                    tableForReport.Columns[1].HeaderText = "Фамилия";
                    tableForReport.Columns[2].HeaderText = "Имя";
                    tableForReport.Columns[3].HeaderText = "Отчество";
                    tableForReport.Columns[4].HeaderText = "INN";
                    tableForReport.Columns[5].HeaderText = "Наименование";
                    tableForReport.Columns[6].HeaderText = "Количество";
                    tableForReport.Columns[7].HeaderText = "Цена,руб.шт";
                    tableForReport.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void MadeReportComing(DataGridView tableForReport)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=I002;User ID=student;Password=Passw0rd"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT com.DateComing,con.Surname,con.Name, con.MiddleName, con.INN, pr.Name, PrCom.Quantity, PrCom.Price FROM Coming AS com INNER JOIN Сounteragent AS con" +
                        " ON com.IDСounteragent = con.IdСounteragent INNER JOIN ProductComing AS PrCom ON com.IDComing = PrCom.IDComing " +
                        "INNER JOIN Product AS pr ON PrCom.IDProduct = pr.ArticleNumber  ";
                    SqlCommand ReadProduct = new SqlCommand(query, conn);
                    SqlDataReader reader = ReadProduct.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        table.Rows[i][7] = Math.Round(Convert.ToDouble(table.Rows[i][7]), 2);
                    }
                    tableForReport.DataSource = table;
                    tableForReport.Update();
                    tableForReport.Columns[0].Width = 120;
                    tableForReport.Columns[1].Width = 140;
                    tableForReport.Columns[2].Width = 140;
                    tableForReport.Columns[3].Width = 140;
                    tableForReport.Columns[4].Width = 170;
                    tableForReport.Columns[5].Width = 240;
                    tableForReport.Columns[6].Width = 170;
                    tableForReport.Columns[7].Width = 130;
                    tableForReport.Columns[0].HeaderText = "Дата продажи";
                    tableForReport.Columns[1].HeaderText = "Фамилия";
                    tableForReport.Columns[2].HeaderText = "Имя";
                    tableForReport.Columns[3].HeaderText = "Отчество";
                    tableForReport.Columns[4].HeaderText = "INN";
                    tableForReport.Columns[5].HeaderText = "Наименование";
                    tableForReport.Columns[6].HeaderText = "Количество";
                    tableForReport.Columns[7].HeaderText = "Цена,руб.шт";
                    tableForReport.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


    }
}
