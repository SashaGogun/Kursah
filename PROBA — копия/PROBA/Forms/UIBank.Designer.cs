using System.Windows.Forms;

namespace PROBA.Forms
{
    partial class UIBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIBank));
            this.TopUpCheck = new System.Windows.Forms.Button();
            this.LFIO = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BInvestment = new System.Windows.Forms.Button();
            this.BAllInfo = new System.Windows.Forms.Button();
            this.BMainScreen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LLasOp = new System.Windows.Forms.Label();
            this.LAccNumber = new System.Windows.Forms.Label();
            this.BWithdrawMoney = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopUpCheck
            // 
            this.TopUpCheck.BackColor = System.Drawing.Color.White;
            this.TopUpCheck.FlatAppearance.BorderSize = 0;
            this.TopUpCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopUpCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TopUpCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopUpCheck.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopUpCheck.Location = new System.Drawing.Point(266, 363);
            this.TopUpCheck.Name = "TopUpCheck";
            this.TopUpCheck.Size = new System.Drawing.Size(151, 52);
            this.TopUpCheck.TabIndex = 0;
            this.TopUpCheck.Text = "Поповнити рахунок";
            this.TopUpCheck.UseVisualStyleBackColor = false;
            this.TopUpCheck.Click += new System.EventHandler(this.TopUpCheck_Click);
            // 
            // LFIO
            // 
            this.LFIO.AutoSize = true;
            this.LFIO.BackColor = System.Drawing.Color.Transparent;
            this.LFIO.Font = new System.Drawing.Font("Cascadia Mono Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LFIO.ForeColor = System.Drawing.Color.White;
            this.LFIO.Location = new System.Drawing.Point(249, 43);
            this.LFIO.Name = "LFIO";
            this.LFIO.Size = new System.Drawing.Size(95, 44);
            this.LFIO.TabIndex = 1;
            this.LFIO.Text = "Name";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.BackColor = System.Drawing.Color.Transparent;
            this.Money.Font = new System.Drawing.Font("Cascadia Mono Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Money.ForeColor = System.Drawing.Color.White;
            this.Money.Location = new System.Drawing.Point(44, 98);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(132, 49);
            this.Money.TabIndex = 2;
            this.Money.Text = "Money";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BLogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BInvestment);
            this.panel1.Controls.Add(this.BAllInfo);
            this.panel1.Controls.Add(this.BMainScreen);
            this.panel1.Location = new System.Drawing.Point(-22, -40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 500);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Оновити дані";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BLogOut
            // 
            this.BLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BLogOut.FlatAppearance.BorderSize = 0;
            this.BLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogOut.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BLogOut.ForeColor = System.Drawing.Color.White;
            this.BLogOut.Location = new System.Drawing.Point(18, 439);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(209, 58);
            this.BLogOut.TabIndex = 6;
            this.BLogOut.Text = "Вийти з облікового запису";
            this.BLogOut.UseVisualStyleBackColor = false;
            this.BLogOut.Click += new System.EventHandler(this.BLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "BankSG";
            // 
            // BInvestment
            // 
            this.BInvestment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BInvestment.FlatAppearance.BorderSize = 0;
            this.BInvestment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInvestment.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BInvestment.ForeColor = System.Drawing.Color.White;
            this.BInvestment.Location = new System.Drawing.Point(18, 220);
            this.BInvestment.Name = "BInvestment";
            this.BInvestment.Size = new System.Drawing.Size(209, 58);
            this.BInvestment.TabIndex = 2;
            this.BInvestment.Text = "Депозит";
            this.BInvestment.UseVisualStyleBackColor = false;
            this.BInvestment.Click += new System.EventHandler(this.BInvestment_Click);
            // 
            // BAllInfo
            // 
            this.BAllInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BAllInfo.FlatAppearance.BorderSize = 0;
            this.BAllInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAllInfo.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAllInfo.ForeColor = System.Drawing.Color.White;
            this.BAllInfo.Location = new System.Drawing.Point(18, 162);
            this.BAllInfo.Name = "BAllInfo";
            this.BAllInfo.Size = new System.Drawing.Size(209, 58);
            this.BAllInfo.TabIndex = 1;
            this.BAllInfo.Text = "Вся інформація";
            this.BAllInfo.UseVisualStyleBackColor = false;
            this.BAllInfo.Click += new System.EventHandler(this.BAllInfo_Click);
            // 
            // BMainScreen
            // 
            this.BMainScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BMainScreen.FlatAppearance.BorderSize = 0;
            this.BMainScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMainScreen.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMainScreen.ForeColor = System.Drawing.Color.White;
            this.BMainScreen.Location = new System.Drawing.Point(18, 104);
            this.BMainScreen.Name = "BMainScreen";
            this.BMainScreen.Size = new System.Drawing.Size(209, 58);
            this.BMainScreen.TabIndex = 0;
            this.BMainScreen.Text = "Головна сторінка";
            this.BMainScreen.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LAccNumber);
            this.panel2.Controls.Add(this.Money);
            this.panel2.Location = new System.Drawing.Point(287, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 216);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LLasOp);
            this.panel3.Location = new System.Drawing.Point(-7, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 35);
            this.panel3.TabIndex = 5;
            // 
            // LLasOp
            // 
            this.LLasOp.BackColor = System.Drawing.Color.Transparent;
            this.LLasOp.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLasOp.ForeColor = System.Drawing.Color.White;
            this.LLasOp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LLasOp.Location = new System.Drawing.Point(7, 3);
            this.LLasOp.Name = "LLasOp";
            this.LLasOp.Size = new System.Drawing.Size(428, 32);
            this.LLasOp.TabIndex = 4;
            this.LLasOp.Text = "Info";
            this.LLasOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLasOp.Click += new System.EventHandler(this.LLasOp_Click);
            // 
            // LAccNumber
            // 
            this.LAccNumber.AutoSize = true;
            this.LAccNumber.BackColor = System.Drawing.Color.Transparent;
            this.LAccNumber.Font = new System.Drawing.Font("Cascadia Mono Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LAccNumber.ForeColor = System.Drawing.Color.White;
            this.LAccNumber.Location = new System.Drawing.Point(44, 36);
            this.LAccNumber.Name = "LAccNumber";
            this.LAccNumber.Size = new System.Drawing.Size(126, 32);
            this.LAccNumber.TabIndex = 3;
            this.LAccNumber.Text = "AcNumber";
            // 
            // BWithdrawMoney
            // 
            this.BWithdrawMoney.BackColor = System.Drawing.Color.White;
            this.BWithdrawMoney.FlatAppearance.BorderSize = 0;
            this.BWithdrawMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BWithdrawMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BWithdrawMoney.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BWithdrawMoney.Location = new System.Drawing.Point(423, 363);
            this.BWithdrawMoney.Name = "BWithdrawMoney";
            this.BWithdrawMoney.Size = new System.Drawing.Size(151, 52);
            this.BWithdrawMoney.TabIndex = 5;
            this.BWithdrawMoney.Text = "Переказати гроші";
            this.BWithdrawMoney.UseVisualStyleBackColor = false;
            this.BWithdrawMoney.Click += new System.EventHandler(this.BWithdrawMoney_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(580, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зняти кошти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BWithdrawMoney);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LFIO);
            this.Controls.Add(this.TopUpCheck);
            this.Name = "UIBank";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UIBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TopUpCheck;
        private Label LFIO;
        private Label Money;
        private Panel panel1;
        private Panel panel2;
        private Button BInvestment;
        private Button BAllInfo;
        private Button BMainScreen;
        private Label LAccNumber;
        private Label label1;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private Button BWithdrawMoney;
        private Button button1;

        private void changeDesignPanel()
        {
            this.panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }

        private void changeDesignButton()
        {
            this.button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            this.BWithdrawMoney.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BWithdrawMoney.Width, BWithdrawMoney.Height, 20, 20));
            this.TopUpCheck.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, TopUpCheck.Width, TopUpCheck.Height, 20, 20));
        }

        private Button BLogOut;
        private Button button2;
        private Label LLasOp;
        private Panel panel3;
    }
}