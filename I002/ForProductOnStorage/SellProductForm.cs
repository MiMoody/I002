using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I002
{
    public partial class SellProductForm : Form
    {
        string IDProduct, IDCounteragent = null;
        public SellProductForm(string Id,string name,string Quantity,string Price)
        {
            InitializeComponent();
            IDProduct = Id;
            LabForProduct.Text = "Наименование товара: "+name;
            TxtQuantity.Maximum = Convert.ToInt32(Quantity);
            TxtPrice.Text = Price;

        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {
            EntityCounteragent entityCounteragent = new EntityCounteragent();
            entityCounteragent.ReadCounteragent(tableForCounteragents, 2);
        }

        private void TxtFindCounteragent_TextChanged(object sender, EventArgs e)
        {
            EntityCounteragent entityCounteragent = new EntityCounteragent();
            entityCounteragent.FindCounteragent(tableForCounteragents, 2, TxtFindCounteragent.Text);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(IDCounteragent!=null)
            {
                EntityProductOnStorage entityProductOnStorage = new EntityProductOnStorage();
                entityProductOnStorage.SellProduct(IDCounteragent, IDProduct, Convert.ToDouble(TxtPrice.Text), Convert.ToInt32(TxtQuantity.Value));
            }
            else MessageBox.Show("Вы не выбрали контрагента!\n\nНажмите на нужную запись в талице!");
        }

        private void tableForCounteragents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDCounteragent = tableForCounteragents[0, e.RowIndex].Value.ToString();
            }
            catch { IDCounteragent = null; }
        }
    }
}
