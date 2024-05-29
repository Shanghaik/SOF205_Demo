namespace C_PRL.Forms
{
    partial class Form_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_Show = new System.Windows.Forms.Panel();
            this.pn_Controls = new System.Windows.Forms.Panel();
            this.btn_Rules = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pn_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 647);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pn_Show
            // 
            this.pn_Show.BackColor = System.Drawing.Color.Plum;
            this.pn_Show.Location = new System.Drawing.Point(261, 14);
            this.pn_Show.Name = "pn_Show";
            this.pn_Show.Size = new System.Drawing.Size(849, 645);
            this.pn_Show.TabIndex = 1;
            // 
            // pn_Controls
            // 
            this.pn_Controls.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pn_Controls.Controls.Add(this.btn_Rules);
            this.pn_Controls.Controls.Add(this.btn_Product);
            this.pn_Controls.Controls.Add(this.btn_Home);
            this.pn_Controls.Location = new System.Drawing.Point(12, 15);
            this.pn_Controls.Name = "pn_Controls";
            this.pn_Controls.Size = new System.Drawing.Size(236, 647);
            this.pn_Controls.TabIndex = 0;
            // 
            // btn_Rules
            // 
            this.btn_Rules.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Rules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rules.Location = new System.Drawing.Point(7, 163);
            this.btn_Rules.Name = "btn_Rules";
            this.btn_Rules.Size = new System.Drawing.Size(221, 51);
            this.btn_Rules.TabIndex = 2;
            this.btn_Rules.Text = "Chính sách";
            this.btn_Rules.UseVisualStyleBackColor = false;
            this.btn_Rules.Click += new System.EventHandler(this.btn_Rules_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.Lime;
            this.btn_Product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Product.Location = new System.Drawing.Point(7, 91);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(221, 54);
            this.btn_Product.TabIndex = 1;
            this.btn_Product.Text = "Quản lý Sản phẩm";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Orange;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.Location = new System.Drawing.Point(7, 19);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(221, 57);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            this.btn_Home.MouseLeave += new System.EventHandler(this.btn_Home_MouseLeave);
            this.btn_Home.MouseHover += new System.EventHandler(this.btn_Home_MouseHover);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 671);
            this.Controls.Add(this.pn_Show);
            this.Controls.Add(this.pn_Controls);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.panel1.ResumeLayout(false);
            this.pn_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel pn_Show;
        private Panel pn_Controls;
        private Button btn_Rules;
        private Button btn_Product;
        private Button btn_Home;
    }
}