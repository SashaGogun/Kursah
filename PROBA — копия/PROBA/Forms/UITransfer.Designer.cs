namespace PROBA.Forms
{
    partial class UITransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UITransfer));
            this.BTransfer = new System.Windows.Forms.Button();
            this.TSum = new System.Windows.Forms.TextBox();
            this.TAnotherCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BStepBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTransfer
            // 
            this.BTransfer.BackColor = System.Drawing.Color.White;
            this.BTransfer.FlatAppearance.BorderSize = 0;
            this.BTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTransfer.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTransfer.Location = new System.Drawing.Point(105, 270);
            this.BTransfer.Name = "BTransfer";
            this.BTransfer.Size = new System.Drawing.Size(167, 55);
            this.BTransfer.TabIndex = 2;
            this.BTransfer.Text = "Переказати";
            this.BTransfer.UseVisualStyleBackColor = false;
            this.BTransfer.Click += new System.EventHandler(this.BTransfer_Click);
            // 
            // TSum
            // 
            this.TSum.BackColor = System.Drawing.Color.White;
            this.TSum.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TSum.Location = new System.Drawing.Point(46, 181);
            this.TSum.Multiline = true;
            this.TSum.Name = "TSum";
            this.TSum.Size = new System.Drawing.Size(292, 32);
            this.TSum.TabIndex = 4;
            // 
            // TAnotherCard
            // 
            this.TAnotherCard.BackColor = System.Drawing.Color.White;
            this.TAnotherCard.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TAnotherCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TAnotherCard.Location = new System.Drawing.Point(46, 101);
            this.TAnotherCard.Multiline = true;
            this.TAnotherCard.Name = "TAnotherCard";
            this.TAnotherCard.Size = new System.Drawing.Size(292, 32);
            this.TAnotherCard.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть номер іншої карти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введіть суму";
            // 
            // BStepBack
            // 
            this.BStepBack.BackColor = System.Drawing.Color.Transparent;
            this.BStepBack.FlatAppearance.BorderSize = 0;
            this.BStepBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BStepBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BStepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BStepBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BStepBack.ForeColor = System.Drawing.Color.White;
            this.BStepBack.Location = new System.Drawing.Point(-1, -1);
            this.BStepBack.Name = "BStepBack";
            this.BStepBack.Size = new System.Drawing.Size(94, 29);
            this.BStepBack.TabIndex = 7;
            this.BStepBack.Text = "🠔";
            this.BStepBack.UseVisualStyleBackColor = false;
            this.BStepBack.Click += new System.EventHandler(this.BStepBack_Click);
            // 
            // UITransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 362);
            this.Controls.Add(this.BStepBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSum);
            this.Controls.Add(this.TAnotherCard);
            this.Controls.Add(this.BTransfer);
            this.Name = "UITransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UITransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BTransfer;

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

        private TextBox TSum;
        private TextBox TAnotherCard;
        private Label label1;
        private Label label2;
        private Button BStepBack;
    }
}