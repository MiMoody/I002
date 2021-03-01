
namespace I002
{
    partial class SellProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tableForCounteragents = new System.Windows.Forms.DataGridView();
            this.TxtFindCounteragent = new System.Windows.Forms.TextBox();
            this.LabFind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabForProduct = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::I002.Properties.Resources.back;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(3, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(57, 49);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tableForCounteragents
            // 
            this.tableForCounteragents.AllowUserToAddRows = false;
            this.tableForCounteragents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableForCounteragents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForCounteragents.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tableForCounteragents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableForCounteragents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForCounteragents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableForCounteragents.Location = new System.Drawing.Point(43, 215);
            this.tableForCounteragents.MultiSelect = false;
            this.tableForCounteragents.Name = "tableForCounteragents";
            this.tableForCounteragents.ReadOnly = true;
            this.tableForCounteragents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableForCounteragents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableForCounteragents.RowTemplate.Height = 35;
            this.tableForCounteragents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForCounteragents.Size = new System.Drawing.Size(988, 206);
            this.tableForCounteragents.TabIndex = 17;
            this.tableForCounteragents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForCounteragents_CellClick);
            // 
            // TxtFindCounteragent
            // 
            this.TxtFindCounteragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFindCounteragent.Location = new System.Drawing.Point(133, 170);
            this.TxtFindCounteragent.Name = "TxtFindCounteragent";
            this.TxtFindCounteragent.Size = new System.Drawing.Size(818, 33);
            this.TxtFindCounteragent.TabIndex = 18;
            this.TxtFindCounteragent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFindCounteragent.TextChanged += new System.EventHandler(this.TxtFindCounteragent_TextChanged);
            // 
            // LabFind
            // 
            this.LabFind.AutoSize = true;
            this.LabFind.Location = new System.Drawing.Point(421, 131);
            this.LabFind.Name = "LabFind";
            this.LabFind.Size = new System.Drawing.Size(265, 25);
            this.LabFind.TabIndex = 19;
            this.LabFind.Text = "Введите данные для поиска:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выберите контрагента, которому хотите продать товар";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Location = new System.Drawing.Point(460, 503);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(226, 33);
            this.TxtPrice.TabIndex = 21;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Цена, руб.партия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Количество партий";
            // 
            // LabForProduct
            // 
            this.LabForProduct.Location = new System.Drawing.Point(-5, 24);
            this.LabForProduct.Name = "LabForProduct";
            this.LabForProduct.Size = new System.Drawing.Size(1060, 49);
            this.LabForProduct.TabIndex = 28;
            this.LabForProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(460, 569);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(226, 39);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "Продать товар";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TxtQuantity);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.TxtPrice);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LabFind);
            this.MainPanel.Controls.Add(this.TxtFindCounteragent);
            this.MainPanel.Controls.Add(this.tableForCounteragents);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.LabForProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1058, 658);
            this.MainPanel.TabIndex = 4;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(460, 448);
            this.TxtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(226, 33);
            this.TxtQuantity.TabIndex = 30;
            this.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 658);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SellProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа товара";
            this.Load += new System.EventHandler(this.SellProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView tableForCounteragents;
        private System.Windows.Forms.TextBox TxtFindCounteragent;
        private System.Windows.Forms.Label LabFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabForProduct;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.NumericUpDown TxtQuantity;
    }
}