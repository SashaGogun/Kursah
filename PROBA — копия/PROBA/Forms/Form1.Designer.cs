namespace PROBA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BNextFrom = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.BAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNextFrom
            // 
            this.BNextFrom.BackColor = System.Drawing.Color.White;
            this.BNextFrom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BNextFrom.FlatAppearance.BorderSize = 0;
            this.BNextFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BNextFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BNextFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNextFrom.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BNextFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BNextFrom.Location = new System.Drawing.Point(68, 246);
            this.BNextFrom.Name = "BNextFrom";
            this.BNextFrom.Size = new System.Drawing.Size(203, 50);
            this.BNextFrom.TabIndex = 0;
            this.BNextFrom.Text = "Увійти";
            this.BNextFrom.UseVisualStyleBackColor = false;
            this.BNextFrom.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login.Location = new System.Drawing.Point(123, 78);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(292, 32);
            this.login.TabIndex = 1;
            this.login.Text = "Номер аккаунта";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(123, 158);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(292, 32);
            this.password.TabIndex = 2;
            this.password.Text = "Пароль";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // BAuthorization
            // 
            this.BAuthorization.BackColor = System.Drawing.Color.White;
            this.BAuthorization.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BAuthorization.FlatAppearance.BorderSize = 0;
            this.BAuthorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BAuthorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAuthorization.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAuthorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BAuthorization.Location = new System.Drawing.Point(277, 246);
            this.BAuthorization.Name = "BAuthorization";
            this.BAuthorization.Size = new System.Drawing.Size(203, 50);
            this.BAuthorization.TabIndex = 3;
            this.BAuthorization.Text = "Зареєструватись";
            this.BAuthorization.UseVisualStyleBackColor = false;
            this.BAuthorization.Click += new System.EventHandler(this.BAuthorization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.BAuthorization);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.BNextFrom);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BNextFrom;
        private TextBox login;
        private TextBox password;
        private Button BAuthorization;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void changeDesineTextBox()
        {
            var textBoxes = GetAllControlsOfType<TextBox>(this);
            foreach (var textBox in textBoxes)
            {
                textBox.BorderStyle = BorderStyle.None;
                textBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox.Width, textBox.Height, 10, 10));
            }

        }
        private void changeDesineButton()
        {
            var buttons = GetAllControlsOfType<Button>(this);
            foreach (var button in buttons)
            {
                button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 20, 20));
            }

        }
        private static T[] GetAllControlsOfType<T>(Control control) where T : Control
        {
            var controls = control.Controls.Cast<Control>();
            var ofType = controls.SelectMany(ctrl => GetAllControlsOfType<T>(ctrl));

            return controls.OfType<T>().Concat(ofType).ToArray();
        }
    }
}