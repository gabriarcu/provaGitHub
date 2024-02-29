namespace provaGitHub
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_piu = new System.Windows.Forms.Button();
            this.btn_diviso = new System.Windows.Forms.Button();
            this.btn_per = new System.Windows.Forms.Button();
            this.btn_meno = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_esci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.Location = new System.Drawing.Point(150, 29);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(130, 34);
            this.txt_num1.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.Location = new System.Drawing.Point(150, 87);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(130, 34);
            this.txt_num2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // btn_piu
            // 
            this.btn_piu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_piu.Location = new System.Drawing.Point(32, 187);
            this.btn_piu.Name = "btn_piu";
            this.btn_piu.Size = new System.Drawing.Size(65, 41);
            this.btn_piu.TabIndex = 4;
            this.btn_piu.Text = "+";
            this.btn_piu.UseVisualStyleBackColor = true;
            this.btn_piu.Click += new System.EventHandler(this.btn_piu_Click);
            // 
            // btn_diviso
            // 
            this.btn_diviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diviso.Location = new System.Drawing.Point(119, 234);
            this.btn_diviso.Name = "btn_diviso";
            this.btn_diviso.Size = new System.Drawing.Size(65, 41);
            this.btn_diviso.TabIndex = 5;
            this.btn_diviso.Text = ":";
            this.btn_diviso.UseVisualStyleBackColor = true;
            // 
            // btn_per
            // 
            this.btn_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_per.Location = new System.Drawing.Point(32, 234);
            this.btn_per.Name = "btn_per";
            this.btn_per.Size = new System.Drawing.Size(65, 41);
            this.btn_per.TabIndex = 6;
            this.btn_per.Text = "x";
            this.btn_per.UseVisualStyleBackColor = true;
            // 
            // btn_meno
            // 
            this.btn_meno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meno.Location = new System.Drawing.Point(119, 187);
            this.btn_meno.Name = "btn_meno";
            this.btn_meno.Size = new System.Drawing.Size(65, 41);
            this.btn_meno.TabIndex = 7;
            this.btn_meno.Text = "-";
            this.btn_meno.UseVisualStyleBackColor = true;
            this.btn_meno.Click += new System.EventHandler(this.btn_meno_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(325, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 323);
            this.listBox1.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(32, 294);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(152, 50);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_esci
            // 
            this.btn_esci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esci.Location = new System.Drawing.Point(423, 388);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.Size = new System.Drawing.Size(152, 50);
            this.btn_esci.TabIndex = 10;
            this.btn_esci.Text = "Esci";
            this.btn_esci.UseVisualStyleBackColor = true;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btn_esci);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_meno);
            this.Controls.Add(this.btn_per);
            this.Controls.Add(this.btn_diviso);
            this.Controls.Add(this.btn_piu);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_piu;
        private System.Windows.Forms.Button btn_diviso;
        private System.Windows.Forms.Button btn_per;
        private System.Windows.Forms.Button btn_meno;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_esci;
    }
}

