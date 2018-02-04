namespace ERP_Learning
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.登录用户 = new System.Windows.Forms.Label();
            this.登录密码 = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.AcceptsTab = true;
            this.textUser.Location = new System.Drawing.Point(147, 148);
            this.textUser.MaxLength = 40;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(155, 20);
            this.textUser.TabIndex = 0;
            this.textUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyDown);
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(147, 196);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '*';
            this.textPwd.Size = new System.Drawing.Size(155, 20);
            this.textPwd.TabIndex = 1;
            this.textPwd.TextChanged += new System.EventHandler(this.textPwd_TextChanged);
            this.textPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPwd_KeyDown);
            // 
            // 登录用户
            // 
            this.登录用户.AutoSize = true;
            this.登录用户.Location = new System.Drawing.Point(47, 148);
            this.登录用户.Name = "登录用户";
            this.登录用户.Size = new System.Drawing.Size(67, 13);
            this.登录用户.TabIndex = 2;
            this.登录用户.Text = "登录用户：";
            this.登录用户.Click += new System.EventHandler(this.label1_Click);
            // 
            // 登录密码
            // 
            this.登录密码.AutoSize = true;
            this.登录密码.Location = new System.Drawing.Point(47, 196);
            this.登录密码.Name = "登录密码";
            this.登录密码.Size = new System.Drawing.Size(67, 13);
            this.登录密码.TabIndex = 3;
            this.登录密码.Text = "登录密码：";
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(147, 277);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(228, 277);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(75, 23);
            this.butReset.TabIndex = 5;
            this.butReset.Text = "重置";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // errInfo
            // 
            this.errInfo.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 342);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.登录密码);
            this.Controls.Add(this.登录用户);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textUser);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label 登录用户;
        private System.Windows.Forms.Label 登录密码;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.ErrorProvider errInfo;
    }
}