﻿namespace Test_20211109
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
            this.SuspendLayout();
            // 
            // textbox_castka
            // 
            this.textbox_castka.Location = new System.Drawing.Point(93, 93);
            this.textbox_castka.Name = "textbox_castka";
            this.textbox_castka.Size = new System.Drawing.Size(150, 23);
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
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Částka";
            // 
            // button_vklad
            // 
            this.button_vklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vklad.Location = new System.Drawing.Point(34, 193);
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
            this.label_jmeno.Location = new System.Drawing.Point(38, 266);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(38, 15);
            this.label_jmeno.TabIndex = 4;
            this.label_jmeno.Text = "label3";
            this.label_jmeno.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // button_vyber
            // 
            this.button_vyber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vyber.Location = new System.Drawing.Point(115, 193);
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
            this.button_platba.Location = new System.Drawing.Point(196, 193);
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
            this.label_limit_vklad.Location = new System.Drawing.Point(38, 293);
            this.label_limit_vklad.Name = "label_limit_vklad";
            this.label_limit_vklad.Size = new System.Drawing.Size(38, 15);
            this.label_limit_vklad.TabIndex = 4;
            this.label_limit_vklad.Text = "label3";
            this.label_limit_vklad.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // label_limit_platba
            // 
            this.label_limit_platba.AutoSize = true;
            this.label_limit_platba.Location = new System.Drawing.Point(38, 323);
            this.label_limit_platba.Name = "label_limit_platba";
            this.label_limit_platba.Size = new System.Drawing.Size(38, 15);
            this.label_limit_platba.TabIndex = 4;
            this.label_limit_platba.Text = "label4";
            this.label_limit_platba.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // label_stav
            // 
            this.label_stav.AutoSize = true;
            this.label_stav.Location = new System.Drawing.Point(38, 355);
            this.label_stav.Name = "label_stav";
            this.label_stav.Size = new System.Drawing.Size(62, 15);
            this.label_stav.TabIndex = 4;
            this.label_stav.Text = "Stav konta";
            this.label_stav.Click += new System.EventHandler(this.label_stav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

