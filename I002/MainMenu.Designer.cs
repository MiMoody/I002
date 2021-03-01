
namespace I002
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.BtnProcurement = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnProvider = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnProductOnStorage = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnPurchase);
            this.MainPanel.Controls.Add(this.BtnProcurement);
            this.MainPanel.Controls.Add(this.BtnProduct);
            this.MainPanel.Controls.Add(this.BtnProvider);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.BtnProductOnStorage);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(681, 350);
            this.MainPanel.TabIndex = 0;
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.ForeColor = System.Drawing.Color.Black;
            this.BtnPurchase.Location = new System.Drawing.Point(360, 141);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(248, 63);
            this.BtnPurchase.TabIndex = 6;
            this.BtnPurchase.Text = "Продажи";
            this.BtnPurchase.UseVisualStyleBackColor = true;
            this.BtnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // BtnProcurement
            // 
            this.BtnProcurement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProcurement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProcurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurement.ForeColor = System.Drawing.Color.Black;
            this.BtnProcurement.Location = new System.Drawing.Point(360, 54);
            this.BtnProcurement.Name = "BtnProcurement";
            this.BtnProcurement.Size = new System.Drawing.Size(248, 63);
            this.BtnProcurement.TabIndex = 5;
            this.BtnProcurement.Text = "Закупки";
            this.BtnProcurement.UseVisualStyleBackColor = true;
            this.BtnProcurement.Click += new System.EventHandler(this.BtnProcurement_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnProduct.Location = new System.Drawing.Point(220, 226);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(248, 63);
            this.BtnProduct.TabIndex = 3;
            this.BtnProduct.Text = "Товары";
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // BtnProvider
            // 
            this.BtnProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProvider.ForeColor = System.Drawing.Color.Black;
            this.BtnProvider.Location = new System.Drawing.Point(80, 141);
            this.BtnProvider.Name = "BtnProvider";
            this.BtnProvider.Size = new System.Drawing.Size(248, 63);
            this.BtnProvider.TabIndex = 2;
            this.BtnProvider.Text = "Контрагенты";
            this.BtnProvider.UseVisualStyleBackColor = true;
            this.BtnProvider.Click += new System.EventHandler(this.BtnProvider_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::I002.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(628, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 38);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnProductOnStorage
            // 
            this.BtnProductOnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductOnStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProductOnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductOnStorage.ForeColor = System.Drawing.Color.Black;
            this.BtnProductOnStorage.Location = new System.Drawing.Point(79, 54);
            this.BtnProductOnStorage.Name = "BtnProductOnStorage";
            this.BtnProductOnStorage.Size = new System.Drawing.Size(248, 63);
            this.BtnProductOnStorage.TabIndex = 0;
            this.BtnProductOnStorage.Text = "Товары на складе";
            this.BtnProductOnStorage.UseVisualStyleBackColor = true;
            this.BtnProductOnStorage.Click += new System.EventHandler(this.BtnProductOnStorage_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 350);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnProductOnStorage;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnProvider;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Button BtnProcurement;
        private System.Windows.Forms.Button BtnProduct;
    }
}

