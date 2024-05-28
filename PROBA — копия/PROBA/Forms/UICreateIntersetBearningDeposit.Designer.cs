namespace PROBA.Forms
{
    partial class UICreateIntersetBearningDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UICreateIntersetBearningDeposit));
            this.R6Percent = new System.Windows.Forms.RadioButton();
            this.R9Percent = new System.Windows.Forms.RadioButton();
            this.R12Percent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.R12Month = new System.Windows.Forms.RadioButton();
            this.R3Month = new System.Windows.Forms.RadioButton();
            this.R6Month = new System.Windows.Forms.RadioButton();
            this.TEnterSum = new System.Windows.Forms.Label();
            this.TSum = new System.Windows.Forms.TextBox();
            this.BPutOnPercent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BStepBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // R6Percent
            // 
            this.R6Percent.AutoSize = true;
            this.R6Percent.Location = new System.Drawing.Point(25, 2);
            this.R6Percent.Name = "R6Percent";
            this.R6Percent.Size = new System.Drawing.Size(50, 24);
            this.R6Percent.TabIndex = 0;
            this.R6Percent.TabStop = true;
            this.R6Percent.Text = "6%";
            this.R6Percent.UseVisualStyleBackColor = true;
            // 
            // R9Percent
            // 
            this.R9Percent.AutoSize = true;
            this.R9Percent.Location = new System.Drawing.Point(116, 2);
            this.R9Percent.Name = "R9Percent";
            this.R9Percent.Size = new System.Drawing.Size(50, 24);
            this.R9Percent.TabIndex = 1;
            this.R9Percent.TabStop = true;
            this.R9Percent.Text = "9%";
            this.R9Percent.UseVisualStyleBackColor = true;
            // 
            // R12Percent
            // 
            this.R12Percent.AutoSize = true;
            this.R12Percent.Location = new System.Drawing.Point(215, 3);
            this.R12Percent.Name = "R12Percent";
            this.R12Percent.Size = new System.Drawing.Size(58, 24);
            this.R12Percent.TabIndex = 2;
            this.R12Percent.TabStop = true;
            this.R12Percent.Text = "12%";
            this.R12Percent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.R12Percent);
            this.panel1.Controls.Add(this.R6Percent);
            this.panel1.Controls.Add(this.R9Percent);
            this.panel1.Location = new System.Drawing.Point(42, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 37);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.R12Month);
            this.panel2.Controls.Add(this.R3Month);
            this.panel2.Controls.Add(this.R6Month);
            this.panel2.Location = new System.Drawing.Point(42, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 37);
            this.panel2.TabIndex = 4;
            // 
            // R12Month
            // 
            this.R12Month.AutoSize = true;
            this.R12Month.Location = new System.Drawing.Point(215, 2);
            this.R12Month.Name = "R12Month";
            this.R12Month.Size = new System.Drawing.Size(101, 24);
            this.R12Month.TabIndex = 2;
            this.R12Month.TabStop = true;
            this.R12Month.Text = "12 місяців";
            this.R12Month.UseVisualStyleBackColor = true;
            // 
            // R3Month
            // 
            this.R3Month.AutoSize = true;
            this.R3Month.Location = new System.Drawing.Point(25, 2);
            this.R3Month.Name = "R3Month";
            this.R3Month.Size = new System.Drawing.Size(85, 24);
            this.R3Month.TabIndex = 0;
            this.R3Month.TabStop = true;
            this.R3Month.Text = "3 місяці";
            this.R3Month.UseVisualStyleBackColor = true;
            // 
            // R6Month
            // 
            this.R6Month.AutoSize = true;
            this.R6Month.Location = new System.Drawing.Point(116, 2);
            this.R6Month.Name = "R6Month";
            this.R6Month.Size = new System.Drawing.Size(93, 24);
            this.R6Month.TabIndex = 1;
            this.R6Month.TabStop = true;
            this.R6Month.Text = "6 місяців";
            this.R6Month.UseVisualStyleBackColor = true;
            // 
            // TEnterSum
            // 
            this.TEnterSum.AutoSize = true;
            this.TEnterSum.BackColor = System.Drawing.Color.Transparent;
            this.TEnterSum.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TEnterSum.Location = new System.Drawing.Point(42, 216);
            this.TEnterSum.Name = "TEnterSum";
            this.TEnterSum.Size = new System.Drawing.Size(310, 22);
            this.TEnterSum.TabIndex = 7;
            this.TEnterSum.Text = "Введіть суму яку хочете внести";
            // 
            // TSum
            // 
            this.TSum.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TSum.Location = new System.Drawing.Point(79, 241);
            this.TSum.Multiline = true;
            this.TSum.Name = "TSum";
            this.TSum.Size = new System.Drawing.Size(236, 35);
            this.TSum.TabIndex = 6;
            // 
            // BPutOnPercent
            // 
            this.BPutOnPercent.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BPutOnPercent.Location = new System.Drawing.Point(79, 298);
            this.BPutOnPercent.Name = "BPutOnPercent";
            this.BPutOnPercent.Size = new System.Drawing.Size(236, 63);
            this.BPutOnPercent.TabIndex = 5;
            this.BPutOnPercent.Text = "Покласти під відсоток";
            this.BPutOnPercent.UseVisualStyleBackColor = true;
            this.BPutOnPercent.Click += new System.EventHandler(this.BPutOnPercent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Виберіть термін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Виберіть відсоток";
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
            this.BStepBack.Location = new System.Drawing.Point(-5, -3);
            this.BStepBack.Name = "BStepBack";
            this.BStepBack.Size = new System.Drawing.Size(94, 29);
            this.BStepBack.TabIndex = 10;
            this.BStepBack.Text = "🠔";
            this.BStepBack.UseVisualStyleBackColor = false;
            this.BStepBack.Click += new System.EventHandler(this.BStepBack_Click);
            // 
            // UICreateIntersetBearningDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(392, 420);
            this.Controls.Add(this.BStepBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEnterSum);
            this.Controls.Add(this.TSum);
            this.Controls.Add(this.BPutOnPercent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UICreateIntersetBearningDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UICreateIntersetBearningDeposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton R6Percent;
        private RadioButton R9Percent;
        private RadioButton R12Percent;
        private Panel panel1;
        private Panel panel2;
        private RadioButton R12Month;
        private RadioButton R3Month;
        private RadioButton R6Month;
        private Label TEnterSum;
        private TextBox TSum;
        private Button BPutOnPercent;
        private Label label1;
        private Label label2;
        private Button BStepBack;
    }
}