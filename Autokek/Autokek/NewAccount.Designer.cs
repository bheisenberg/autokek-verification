namespace Autokek
{
    partial class NewAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmField = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.mismatchError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // usernameField
            // 
            this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(36, 62);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(250, 28);
            this.usernameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(36, 198);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(250, 28);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // emailField
            // 
            this.emailField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(36, 130);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(250, 28);
            this.emailField.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // confirmField
            // 
            this.confirmField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmField.Location = new System.Drawing.Point(36, 267);
            this.confirmField.Name = "confirmField";
            this.confirmField.Size = new System.Drawing.Size(250, 28);
            this.confirmField.TabIndex = 3;
            this.confirmField.UseSystemPasswordChar = true;
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(195, 313);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(91, 36);
            this.create.TabIndex = 4;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // mismatchError
            // 
            this.mismatchError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mismatchError.AutoSize = true;
            this.mismatchError.ForeColor = System.Drawing.Color.Crimson;
            this.mismatchError.Location = new System.Drawing.Point(33, 297);
            this.mismatchError.Name = "mismatchError";
            this.mismatchError.Size = new System.Drawing.Size(40, 17);
            this.mismatchError.TabIndex = 9;
            this.mismatchError.Text = "Error";
            this.mismatchError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Crimson;
            this.passwordError.Location = new System.Drawing.Point(35, 229);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(40, 17);
            this.passwordError.TabIndex = 10;
            this.passwordError.Text = "Error";
            this.passwordError.Visible = false;
            // 
            // emailError
            // 
            this.emailError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailError.AutoSize = true;
            this.emailError.ForeColor = System.Drawing.Color.Crimson;
            this.emailError.Location = new System.Drawing.Point(35, 161);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(40, 17);
            this.emailError.TabIndex = 11;
            this.emailError.Text = "Error";
            this.emailError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameError.AutoSize = true;
            this.usernameError.ForeColor = System.Drawing.Color.Crimson;
            this.usernameError.Location = new System.Drawing.Point(33, 93);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(40, 17);
            this.usernameError.TabIndex = 12;
            this.usernameError.Text = "Error";
            this.usernameError.Visible = false;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.confirmField);
            this.Controls.Add(this.create);
            this.Controls.Add(this.mismatchError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordError);
            this.Name = "NewAccount";
            this.Size = new System.Drawing.Size(316, 360);
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmField;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label mismatchError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label usernameError;
    }
}
