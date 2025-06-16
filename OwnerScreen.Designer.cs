namespace WindowsFormsApp19
{
    partial class OwnerScreen
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_PayMent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "메뉴등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "주문접수화면";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_PayMent
            // 
            this.Btn_PayMent.Location = new System.Drawing.Point(604, 137);
            this.Btn_PayMent.Name = "Btn_PayMent";
            this.Btn_PayMent.Size = new System.Drawing.Size(133, 100);
            this.Btn_PayMent.TabIndex = 3;
            this.Btn_PayMent.Text = "결제화면";
            this.Btn_PayMent.UseVisualStyleBackColor = true;
            this.Btn_PayMent.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(813, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 100);
            this.button5.TabIndex = 4;
            this.button5.Text = "주문내역조회";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SalesbyDateButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 100);
            this.button2.TabIndex = 5;
            this.button2.Text = "점주 코드 추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // OwnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Btn_PayMent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "OwnerScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_PayMent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}

