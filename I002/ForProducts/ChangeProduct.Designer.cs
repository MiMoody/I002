
namespace I002
{
    partial class ChangeProduct
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtAddProduct = new System.Windows.Forms.TextBox();
            this.LabNameProduct = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnChangeProduct = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TxtAddProduct);
            this.MainPanel.Controls.Add(this.LabNameProduct);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.BtnChangeProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(480, 263);
            this.MainPanel.TabIndex = 2;
            // 
            // TxtAddProduct
            // 
            this.TxtAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddProduct.Location = new System.Drawing.Point(76, 97);
            this.TxtAddProduct.Name = "TxtAddProduct";
            this.TxtAddProduct.Size = new System.Drawing.Size(319, 33);
            this.TxtAddProduct.TabIndex = 8;
            this.TxtAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Location = new System.Drawing.Point(90, 46);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(302, 25);
            this.LabNameProduct.TabIndex = 7;
            this.LabNameProduct.Text = "Введите новое название товара:";
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
            this.BtnClose.Location = new System.Drawing.Point(430, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 38);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnChangeProduct
            // 
            this.BtnChangeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChangeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnChangeProduct.Location = new System.Drawing.Point(156, 166);
            this.BtnChangeProduct.Name = "BtnChangeProduct";
            this.BtnChangeProduct.Size = new System.Drawing.Size(157, 39);
            this.BtnChangeProduct.TabIndex = 0;
            this.BtnChangeProduct.Text = "Изменить";
            this.BtnChangeProduct.UseVisualStyleBackColor = true;
            this.BtnChangeProduct.Click += new System.EventHandler(this.BtnChangeProduct_Click);
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 263);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование продукта";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtAddProduct;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnChangeProduct;
    }
}