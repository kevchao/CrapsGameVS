
namespace CrapsGameVS
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Roll = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.placeBet = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.bet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(487, 73);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 20);
            this.lblBalance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Round: ";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(487, 166);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 20);
            this.lblRound.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Point: ";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(487, 254);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(0, 20);
            this.lblPoint.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bet: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 8;
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(111, 378);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(219, 72);
            this.Roll.TabIndex = 9;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(357, 312);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // placeBet
            // 
            this.placeBet.Location = new System.Drawing.Point(487, 386);
            this.placeBet.Name = "placeBet";
            this.placeBet.Size = new System.Drawing.Size(151, 64);
            this.placeBet.TabIndex = 11;
            this.placeBet.Text = "Place Bet";
            this.placeBet.UseVisualStyleBackColor = true;
            this.placeBet.Click += new System.EventHandler(this.placeBet_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(14, 512);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(122, 33);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(520, 309);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(0, 20);
            this.bet.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 558);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.placeBet);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button placeBet;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label bet;
    }
}

