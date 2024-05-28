namespace PROBA.Forms
{
    partial class UIWithDrawCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIWithDrawCheck));
            this.button2 = new System.Windows.Forms.Button();
            this.TEnterSum = new System.Windows.Forms.Label();
            this.TSum = new System.Windows.Forms.TextBox();
            this.BWithDrawMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-11, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "🠔";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TEnterSum
            // 
            this.TEnterSum.AutoSize = true;
            this.TEnterSum.BackColor = System.Drawing.Color.Transparent;
            this.TEnterSum.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TEnterSum.Location = new System.Drawing.Point(29, 133);
            this.TEnterSum.Name = "TEnterSum";
            this.TEnterSum.Size = new System.Drawing.Size(300, 22);
            this.TEnterSum.TabIndex = 6;
            this.TEnterSum.Text = "Введіть суму яку хочете зняти";
            // 
            // TSum
            // 
            this.TSum.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TSum.Location = new System.Drawing.Point(67, 172);
            this.TSum.Multiline = true;
            this.TSum.Name = "TSum";
            this.TSum.Size = new System.Drawing.Size(236, 35);
            this.TSum.TabIndex = 5;
            // 
            // BWithDrawMoney
            // 
            this.BWithDrawMoney.Font = new System.Drawing.Font("Cascadia Mono Light", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BWithDrawMoney.Location = new System.Drawing.Point(67, 287);
            this.BWithDrawMoney.Name = "BWithDrawMoney";
            this.BWithDrawMoney.Size = new System.Drawing.Size(236, 63);
            this.BWithDrawMoney.TabIndex = 4;
            this.BWithDrawMoney.Text = "Зняти";
            this.BWithDrawMoney.UseVisualStyleBackColor = true;
            this.BWithDrawMoney.Click += new System.EventHandler(this.BWithDrawMoney_Click);
            // 
            // UIWithDrawCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TEnterSum);
            this.Controls.Add(this.TSum);
            this.Controls.Add(this.BWithDrawMoney);
            this.Name = "UIWithDrawCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIWithDrawCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Label TEnterSum;
        private TextBox TSum;
        private Button BWithDrawMoney;
    }
}