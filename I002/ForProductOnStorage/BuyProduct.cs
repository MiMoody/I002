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
    public partial class BuyProduct : Form
    {
        string IDCounteragent = null, IDProduct = null;
        public BuyProduct()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            EntityCounteragent entityCounteragent = new EntityCounteragent();
            entityCounteragent.ReadCounteragent(tableForCounteragents, 1);
            EntityProduct entityProduct = new EntityProduct();
            entityProduct.ReadProduct(tableForProducts);
        }

        private void TxtFindCounteragent_TextChanged(object sender, EventArgs e)
        {
            EntityCounteragent entityCounteragent = new EntityCounteragent();
            entityCounteragent.FindCounteragent(tableForCounteragents, 1, TxtFindCounteragent.Text);
        }

        private void TxtFindProduct_TextChanged(object sender, EventArgs e)
        {
            EntityProduct entityProduct = new EntityProduct();
            entityProduct.FindProduct(tableForProducts, TxtFindProduct.Text);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int Quantity;
            double Price;
            if (IDCounteragent != null)
            {
                if (IDProduct!=null)
                {
                    try
                    {
                        Quantity = Convert.ToInt32(TxtQuantity.Text);
                        try
                        {
                            Price = Convert.ToDouble(TxtPrice.Text);

                            EntityProductOnStorage productOnStorage = new EntityProductOnStorage();
                            productOnStorage.BuyProduct(IDCounteragent,IDProduct,Price,Quantity);
                        }
                        catch { MessageBox.Show("Введите корректную цену товара!"); }

                    }
                    catch { MessageBox.Show("Введите корректное количество товара!"); }
                }
                else { MessageBox.Show("Вы не выбрали товар!\n\nНажмите на соответствующую запись в таблице"); }
            }
            else { MessageBox.Show("Вы не выбрали контрагента!\n\nНажмите на соответствующую запись в таблице"); }
             
           
        }

        private void tableForCounteragents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDCounteragent = tableForCounteragents[0, e.RowIndex].Value.ToString();
            }
            catch { IDCounteragent = null; }
        }

        private void tableForProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDProduct = tableForProducts[0, e.RowIndex].Value.ToString();
            }
            catch { IDProduct = null; }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckSimbol.CheckInputSimbol(sender, e);
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckSimbol.CheckInputSimbol(sender, e);
        }
    }
}
