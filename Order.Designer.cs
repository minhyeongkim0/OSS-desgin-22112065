using System.Windows.Forms;

namespace WindowsFormsApp19
{
    partial class Order
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
            this.Btn_Drink = new System.Windows.Forms.Button();
            this.Btn_Soup = new System.Windows.Forms.Button();
            this.Btn_Meal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Drink
            // 
            this.Btn_Drink.Location = new System.Drawing.Point(90, 53);
            this.Btn_Drink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Drink.Name = "Btn_Drink";
            this.Btn_Drink.Size = new System.Drawing.Size(108, 58);
            this.Btn_Drink.TabIndex = 0;
            this.Btn_Drink.Text = "주류";
            this.Btn_Drink.UseVisualStyleBackColor = true;
            this.Btn_Drink.Click += new System.EventHandler(this.DrinkButton);
            // 
            // Btn_Soup
            // 
            this.Btn_Soup.Location = new System.Drawing.Point(90, 207);
            this.Btn_Soup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Soup.Name = "Btn_Soup";
            this.Btn_Soup.Size = new System.Drawing.Size(108, 62);
            this.Btn_Soup.TabIndex = 1;
            this.Btn_Soup.Text = "안주류";
            this.Btn_Soup.UseVisualStyleBackColor = true;
            this.Btn_Soup.Click += new System.EventHandler(this.SnacksButton);
            // 
            // Btn_Meal
            // 
            this.Btn_Meal.Location = new System.Drawing.Point(90, 386);
            this.Btn_Meal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Meal.Name = "Btn_Meal";
            this.Btn_Meal.Size = new System.Drawing.Size(108, 61);
            this.Btn_Meal.TabIndex = 2;
            this.Btn_Meal.Text = "식사메뉴";
            this.Btn_Meal.UseVisualStyleBackColor = true;
            this.Btn_Meal.Click += new System.EventHandler(this.MealButton);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 200;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 421);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1208, 492);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "주문담기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddButton);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 624);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Meal);
            this.Controls.Add(this.Btn_Soup);
            this.Controls.Add(this.Btn_Drink);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Drink;
        private System.Windows.Forms.Button Btn_Soup;
        private System.Windows.Forms.Button Btn_Meal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button4;
    }
}