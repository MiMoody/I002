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
    public partial class FormPurchase : Form
    {
        int Action;
        public FormPurchase(int action)
        {
            InitializeComponent();
            Action = action;
            if (Action == 2) this.Text = "Отчёт о продажах";
            else this.Text = "Отчёт о покупках";
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            if(Action==1)
            {
                EntityReport entityReport = new EntityReport();
                entityReport.MadeReportComing(tableForReport);
            }
            else
            {
                EntityReport entityRep = new EntityReport();
                entityRep.MadeReportPurchase(tableForReport);
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
