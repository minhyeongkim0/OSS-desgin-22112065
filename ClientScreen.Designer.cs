namespace WindowsFormsApp19
{
    partial class ClientScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.ViewTopMenu = new System.Windows.Forms.Button();
            this.SelectTopMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "주문하기 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OrderButton);
            // 
            // ViewTopMenu
            // 
            this.ViewTopMenu.Location = new System.Drawing.Point(388, 140);
            this.ViewTopMenu.Name = "ViewTopMenu";
            this.ViewTopMenu.Size = new System.Drawing.Size(142, 121);
            this.ViewTopMenu.TabIndex = 1;
            this.ViewTopMenu.Text = "최고메뉴 조회";
            this.ViewTopMenu.UseVisualStyleBackColor = true;
            this.ViewTopMenu.Click += new System.EventHandler(this.ViewTopMenuButton);
            // 
            // SelectTopMenu
            // 
            this.SelectTopMenu.Location = new System.Drawing.Point(609, 142);
            this.SelectTopMenu.Name = "SelectTopMenu";
            this.SelectTopMenu.Size = new System.Drawing.Size(126, 119);
            this.SelectTopMenu.TabIndex = 2;
            this.SelectTopMenu.Text = "최고메뉴 등록";
            this.SelectTopMenu.UseVisualStyleBackColor = true;
            this.SelectTopMenu.Click += new System.EventHandler(this.SelectTopMenuButton);
            // 
            // ClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 526);
            this.Controls.Add(this.SelectTopMenu);
            this.Controls.Add(this.ViewTopMenu);
            this.Controls.Add(this.button1);
            this.Name = "ClientScreen";
            this.Text = "ClientScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewTopMenu;
        private System.Windows.Forms.Button SelectTopMenu;
    }
}