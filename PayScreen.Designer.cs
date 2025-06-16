namespace WindowsFormsApp19
{
    partial class PayScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Pay = new System.Windows.Forms.Button();
            this.Btn_Table_Check = new System.Windows.Forms.Button();
            this.Total_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(911, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Pay
            // 
            this.Btn_Pay.Location = new System.Drawing.Point(1029, 483);
            this.Btn_Pay.Name = "Btn_Pay";
            this.Btn_Pay.Size = new System.Drawing.Size(93, 46);
            this.Btn_Pay.TabIndex = 2;
            this.Btn_Pay.Text = "결제";
            this.Btn_Pay.UseVisualStyleBackColor = true;
            this.Btn_Pay.Click += new System.EventHandler(this.Pay);
            // 
            // Btn_Table_Check
            // 
            this.Btn_Table_Check.Font = new System.Drawing.Font("굴림", 15F);
            this.Btn_Table_Check.Location = new System.Drawing.Point(318, 31);
            this.Btn_Table_Check.Name = "Btn_Table_Check";
            this.Btn_Table_Check.Size = new System.Drawing.Size(154, 44);
            this.Btn_Table_Check.TabIndex = 3;
            this.Btn_Table_Check.Text = "조회";
            this.Btn_Table_Check.UseVisualStyleBackColor = true;
            this.Btn_Table_Check.Click += new System.EventHandler(this.View);
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 
            // Total_Price
            // 
            this.Total_Price.Font = new System.Drawing.Font("굴림", 20F);
            this.Total_Price.Location = new System.Drawing.Point(806, 483);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(206, 46);
            this.Total_Price.TabIndex = 4;
            // 
            // Tb_Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 620);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.Btn_Table_Check);
            this.Controls.Add(this.Btn_Pay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tb_Pay";
            this.Text = "Tb_Pay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Pay;
        private System.Windows.Forms.Button Btn_Table_Check;
        private System.Windows.Forms.TextBox Total_Price;
    }
}