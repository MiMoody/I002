
namespace I002
{
    partial class Counteragent
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.labShow = new System.Windows.Forms.Label();
            this.checkBuyer = new System.Windows.Forms.CheckBox();
            this.checkProvider = new System.Windows.Forms.CheckBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LabFind = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.tableForCounteragents = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.labShow);
            this.MainPanel.Controls.Add(this.checkBuyer);
            this.MainPanel.Controls.Add(this.checkProvider);
            this.MainPanel.Controls.Add(this.BtnChange);
            this.MainPanel.Controls.Add(this.BtnDelete);
            this.MainPanel.Controls.Add(this.LabFind);
            this.MainPanel.Controls.Add(this.TxtFind);
            this.MainPanel.Controls.Add(this.tableForCounteragents);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1050, 553);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Location = new System.Drawing.Point(29, 417);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(99, 25);
            this.labShow.TabIndex = 11;
            this.labShow.Text = "Показать:";
            // 
            // checkBuyer
            // 
            this.checkBuyer.AutoCheck = false;
            this.checkBuyer.AutoSize = true;
            this.checkBuyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBuyer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBuyer.Location = new System.Drawing.Point(304, 417);
            this.checkBuyer.Name = "checkBuyer";
            this.checkBuyer.Size = new System.Drawing.Size(153, 30);
            this.checkBuyer.TabIndex = 10;
            this.checkBuyer.Text = "Покупателей";
            this.checkBuyer.UseVisualStyleBackColor = true;
            this.checkBuyer.Click += new System.EventHandler(this.checkBuyer_Click);
            // 
            // checkProvider
            // 
            this.checkProvider.AutoCheck = false;
            this.checkProvider.AutoSize = true;
            this.checkProvider.Checked = true;
            this.checkProvider.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkProvider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkProvider.Location = new System.Drawing.Point(145, 417);
            this.checkProvider.Name = "checkProvider";
            this.checkProvider.Size = new System.Drawing.Size(159, 30);
            this.checkProvider.TabIndex = 9;
            this.checkProvider.Text = "Поставщиков";
            this.checkProvider.UseVisualStyleBackColor = true;
            this.checkProvider.Click += new System.EventHandler(this.checkProvider_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.ForeColor = System.Drawing.Color.Black;
            this.BtnChange.Location = new System.Drawing.Point(736, 468);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(200, 60);
            this.BtnChange.TabIndex = 8;
            this.BtnChange.Text = "Изменить контрагента";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(425, 468);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 60);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Удалить контрагента";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LabFind
            // 
            this.LabFind.AutoSize = true;
            this.LabFind.Location = new System.Drawing.Point(406, 46);
            this.LabFind.Name = "LabFind";
            this.LabFind.Size = new System.Drawing.Size(265, 25);
            this.LabFind.TabIndex = 6;
            this.LabFind.Text = "Введите данные для поиска:";
            // 
            // TxtFind
            // 
            this.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFind.Location = new System.Drawing.Point(118, 85);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(818, 33);
            this.TxtFind.TabIndex = 5;
            this.TxtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFind.TextChanged += new System.EventHandler(this.TxtFind_TextChanged);
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
            this.tableForCounteragents.Location = new System.Drawing.Point(28, 130);
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
            this.tableForCounteragents.Size = new System.Drawing.Size(988, 272);
            this.tableForCounteragents.TabIndex = 4;
            this.tableForCounteragents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForCounteragents_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(118, 468);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 60);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Добавить контрагента";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(12, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(57, 49);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Counteragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 553);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Counteragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.Counteragent_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LabFind;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.DataGridView tableForCounteragents;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.CheckBox checkBuyer;
        private System.Windows.Forms.CheckBox checkProvider;
    }
}