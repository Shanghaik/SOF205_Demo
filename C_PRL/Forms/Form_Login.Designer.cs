namespace C_PRL.Forms
{
    partial class Form_Login
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
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Forget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_Username
            // 
            this.tbt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Username.Location = new System.Drawing.Point(175, 38);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(564, 34);
            this.tbt_Username.TabIndex = 0;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Password.Location = new System.Drawing.Point(175, 97);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.Size = new System.Drawing.Size(564, 34);
            this.tbt_Password.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(175, 168);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(197, 48);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btn_Forget
            // 
            this.btn_Forget.Location = new System.Drawing.Point(422, 168);
            this.btn_Forget.Name = "btn_Forget";
            this.btn_Forget.Size = new System.Drawing.Size(200, 47);
            this.btn_Forget.TabIndex = 5;
            this.btn_Forget.Text = "Quên mật khẩu";
            this.btn_Forget.UseVisualStyleBackColor = true;
            this.btn_Forget.Click += new System.EventHandler(this.btn_Forget_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 257);
            this.Controls.Add(this.btn_Forget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private Button btn_Login;
        private Label label1;
        private Label label2;
        private Button btn_Forget;
    }
}