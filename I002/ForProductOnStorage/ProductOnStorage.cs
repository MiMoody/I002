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
    public partial class ProductOnStorage : Form
    {
        string IDProduct = null,NameProduct = null, Quantity= null, Price = null;
        public ProductOnStorage()
        {
            InitializeComponent();
        }

        private void ProductOnStorage_Load(object sender, EventArgs e)
        {
            EntityProductOnStorage product = new EntityProductOnStorage();
            product.ReadProduct(tableForProducts);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BuyProduct product = new BuyProduct();
            product.ShowDialog();
            EntityProductOnStorage entityProduct = new EntityProductOnStorage();
            entityProduct.ReadProduct(tableForProducts);

        }

        private void tableForProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDProduct = tableForProducts[1, e.RowIndex].Value.ToString();
                NameProduct = tableForProducts[2, e.RowIndex].Value.ToString();
                Quantity = tableForProducts[3, e.RowIndex].Value.ToString();
                Price = tableForProducts[4, e.RowIndex].Value.ToString();
            }
            catch
            {
                IDProduct = null;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (IDProduct != null)
            {
                SellProductForm sellProductForm = new SellProductForm(IDProduct,NameProduct, Quantity, Price);
                sellProductForm.ShowDialog();
                EntityProductOnStorage entityProduct = new EntityProductOnStorage();
                entityProduct.ReadProduct(tableForProducts);
            }
            else { MessageBox.Show("Вы не выбрали товар!\n\nНажмите на нужную запись в талице!"); }
        }
    }
}
