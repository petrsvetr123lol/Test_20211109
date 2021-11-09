namespace Test_20211109
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
            this.textbox_castka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_vklad = new System.Windows.Forms.Button();
            this.label_jmeno = new System.Windows.Forms.Label();
            this.button_vyber = new System.Windows.Forms.Button();
            this.button_platba = new System.Windows.Forms.Button();
            this.label_limit_vklad = new System.Windows.Forms.Label();
            this.label_limit_platba = new System.Windows.Forms.Label();
            this.label_stav = new System.Windows.Forms.Label();
            this.textbox_jmeno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_limit_vklad = new System.Windows.Forms.TextBox();
            this.textbox_limit_platba = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_castka
            // 
            this.textbox_castka.Location = new System.Drawing.Point(102, 264);
            this.textbox_castka.Name = "textbox_castka";
            this.textbox_castka.Size = new System.Drawing.Size(181, 23);
            this.textbox_castka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banka u Petra Filipa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Částka";
            // 
            // button_vklad
            // 
            this.button_vklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vklad.Location = new System.Drawing.Point(46, 293);
            this.button_vklad.Name = "button_vklad";
            this.button_vklad.Size = new System.Drawing.Size(75, 23);
            this.button_vklad.TabIndex = 3;
            this.button_vklad.Text = "Vklad";
            this.button_vklad.UseVisualStyleBackColor = true;
            this.button_vklad.Click += new System.EventHandler(this.button_vklad_Click);
            // 
            // label_jmeno
            // 
            this.label_jmeno.AutoSize = true;
            this.label_jmeno.Location = new System.Drawing.Point(34, 349);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(42, 15);
            this.label_jmeno.TabIndex = 4;
            this.label_jmeno.Text = "Jméno";
            this.label_jmeno.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // button_vyber
            // 
            this.button_vyber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vyber.Location = new System.Drawing.Point(127, 293);
            this.button_vyber.Name = "button_vyber";
            this.button_vyber.Size = new System.Drawing.Size(75, 23);
            this.button_vyber.TabIndex = 3;
            this.button_vyber.Text = "Výběr";
            this.button_vyber.UseVisualStyleBackColor = true;
            this.button_vyber.Click += new System.EventHandler(this.button_vyber_Click);
            // 
            // button_platba
            // 
            this.button_platba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_platba.Location = new System.Drawing.Point(208, 293);
            this.button_platba.Name = "button_platba";
            this.button_platba.Size = new System.Drawing.Size(75, 23);
            this.button_platba.TabIndex = 3;
            this.button_platba.Text = "Platba";
            this.button_platba.UseVisualStyleBackColor = true;
            this.button_platba.Click += new System.EventHandler(this.button_platba_Click);
            // 
            // label_limit_vklad
            // 
            this.label_limit_vklad.AutoSize = true;
            this.label_limit_vklad.Location = new System.Drawing.Point(34, 375);
            this.label_limit_vklad.Name = "label_limit_vklad";
            this.label_limit_vklad.Size = new System.Drawing.Size(65, 15);
            this.label_limit_vklad.TabIndex = 4;
            this.label_limit_vklad.Text = "Limit vklad";
            this.label_limit_vklad.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // label_limit_platba
            // 
            this.label_limit_platba.AutoSize = true;
            this.label_limit_platba.Location = new System.Drawing.Point(34, 401);
            this.label_limit_platba.Name = "label_limit_platba";
            this.label_limit_platba.Size = new System.Drawing.Size(70, 15);
            this.label_limit_platba.TabIndex = 4;
            this.label_limit_platba.Text = "Limit platba";
            this.label_limit_platba.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // label_stav
            // 
            this.label_stav.AutoSize = true;
            this.label_stav.Location = new System.Drawing.Point(34, 425);
            this.label_stav.Name = "label_stav";
            this.label_stav.Size = new System.Drawing.Size(62, 15);
            this.label_stav.TabIndex = 4;
            this.label_stav.Text = "Stav konta";
            this.label_stav.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // textbox_jmeno
            // 
            this.textbox_jmeno.Location = new System.Drawing.Point(102, 104);
            this.textbox_jmeno.Name = "textbox_jmeno";
            this.textbox_jmeno.Size = new System.Drawing.Size(181, 23);
            this.textbox_jmeno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limit vklad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limit platba";
            // 
            // textbox_limit_vklad
            // 
            this.textbox_limit_vklad.Location = new System.Drawing.Point(102, 140);
            this.textbox_limit_vklad.Name = "textbox_limit_vklad";
            this.textbox_limit_vklad.Size = new System.Drawing.Size(181, 23);
            this.textbox_limit_vklad.TabIndex = 9;
            // 
            // textbox_limit_platba
            // 
            this.textbox_limit_platba.Location = new System.Drawing.Point(102, 176);
            this.textbox_limit_platba.Name = "textbox_limit_platba";
            this.textbox_limit_platba.Size = new System.Drawing.Size(181, 23);
            this.textbox_limit_platba.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 167);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informace o účtu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 461);
            this.Controls.Add(this.textbox_limit_platba);
            this.Controls.Add(this.textbox_limit_vklad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_jmeno);
            this.Controls.Add(this.label_stav);
            this.Controls.Add(this.label_limit_platba);
            this.Controls.Add(this.label_limit_vklad);
            this.Controls.Add(this.button_platba);
            this.Controls.Add(this.button_vyber);
            this.Controls.Add(this.label_jmeno);
            this.Controls.Add(this.button_vklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_castka);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_castka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_vklad;
        private System.Windows.Forms.Label label_jmeno;
        private System.Windows.Forms.Button button_vyber;
        private System.Windows.Forms.Button button_platba;
        private System.Windows.Forms.Label label_limit_vklad;
        private System.Windows.Forms.Label label_limit_platba;
        private System.Windows.Forms.Label label_stav;
        private System.Windows.Forms.TextBox textbox_jmeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_limit_vklad;
        private System.Windows.Forms.TextBox textbox_limit_platba;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

