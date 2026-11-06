namespace TTT
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblBegruessung = new System.Windows.Forms.Label();
            this.BtnStarten = new System.Windows.Forms.Button();
            this.TxtSpieler1 = new System.Windows.Forms.TextBox();
            this.TxtSpieler2 = new System.Windows.Forms.TextBox();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBegruessung
            // 
            this.LblBegruessung.AutoSize = true;
            this.LblBegruessung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBegruessung.Location = new System.Drawing.Point(47, 9);
            this.LblBegruessung.Name = "LblBegruessung";
            this.LblBegruessung.Size = new System.Drawing.Size(484, 60);
            this.LblBegruessung.TabIndex = 0;
            this.LblBegruessung.Text = "Willkommen bei Tic-Tac-Toe!\r\nBitte Starte das spiel und gib die Namen der Spieler" +
    " ein.\r\n\r\n";
            // 
            // BtnStarten
            // 
            this.BtnStarten.Location = new System.Drawing.Point(185, 387);
            this.BtnStarten.Name = "BtnStarten";
            this.BtnStarten.Size = new System.Drawing.Size(163, 51);
            this.BtnStarten.TabIndex = 1;
            this.BtnStarten.Text = "Starten";
            this.BtnStarten.UseVisualStyleBackColor = true;
            this.BtnStarten.Click += new System.EventHandler(this.BtnStarten_Click);
            // 
            // TxtSpieler1
            // 
            this.TxtSpieler1.Location = new System.Drawing.Point(12, 401);
            this.TxtSpieler1.Name = "TxtSpieler1";
            this.TxtSpieler1.Size = new System.Drawing.Size(141, 22);
            this.TxtSpieler1.TabIndex = 2;
            this.TxtSpieler1.Text = "Spieler 1";
            this.TxtSpieler1.Visible = false;
            // 
            // TxtSpieler2
            // 
            this.TxtSpieler2.Location = new System.Drawing.Point(377, 401);
            this.TxtSpieler2.Name = "TxtSpieler2";
            this.TxtSpieler2.Size = new System.Drawing.Size(168, 22);
            this.TxtSpieler2.TabIndex = 3;
            this.TxtSpieler2.Text = "Spieler 2";
            this.TxtSpieler2.Visible = false;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(147, 118);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(63, 63);
            this.Btn0.TabIndex = 4;
            this.Btn0.Text = "X";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Visible = false;
            this.Btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(311, 210);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(63, 63);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "X";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Visible = false;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(311, 307);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(63, 63);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "X";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Visible = false;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(226, 307);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(63, 63);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = "X";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Visible = false;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(147, 307);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(63, 63);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "X";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Visible = false;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(226, 210);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(63, 63);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "X";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Visible = false;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(147, 210);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(63, 63);
            this.Btn3.TabIndex = 10;
            this.Btn3.Text = "X";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Visible = false;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(311, 117);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(63, 63);
            this.Btn2.TabIndex = 11;
            this.Btn2.Text = "X";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Visible = false;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(226, 117);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(63, 63);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "X";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Visible = false;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(182, 81);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(134, 20);
            this.LblStatus.TabIndex = 13;
            this.LblStatus.Text = "Spieler X ist dran";
            this.LblStatus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 466);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.TxtSpieler2);
            this.Controls.Add(this.TxtSpieler1);
            this.Controls.Add(this.BtnStarten);
            this.Controls.Add(this.LblBegruessung);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBegruessung;
        private System.Windows.Forms.Button BtnStarten;
        private System.Windows.Forms.TextBox TxtSpieler1;
        private System.Windows.Forms.TextBox TxtSpieler2;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label LblStatus;
    }
}

