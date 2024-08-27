namespace WindowsFormsEstados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboCentroOeste = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbltodas = new System.Windows.Forms.Label();
            this.lblNorte = new System.Windows.Forms.Label();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.lblCentroOeste = new System.Windows.Forms.Label();
            this.lblSudeste = new System.Windows.Forms.Label();
            this.lblSul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro - Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espirito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso do Sul",
            "Mato Grosso",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.comboBox1.Location = new System.Drawing.Point(215, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(215, 118);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(121, 21);
            this.cboNorte.TabIndex = 7;
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(215, 160);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(121, 21);
            this.cboNordeste.TabIndex = 8;
            // 
            // cboCentroOeste
            // 
            this.cboCentroOeste.FormattingEnabled = true;
            this.cboCentroOeste.Location = new System.Drawing.Point(215, 205);
            this.cboCentroOeste.Name = "cboCentroOeste";
            this.cboCentroOeste.Size = new System.Drawing.Size(121, 21);
            this.cboCentroOeste.TabIndex = 9;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(215, 247);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(121, 21);
            this.cboSudeste.TabIndex = 10;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(215, 292);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(121, 21);
            this.cboSul.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(381, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(381, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lbltodas
            // 
            this.lbltodas.AutoSize = true;
            this.lbltodas.Location = new System.Drawing.Point(491, 75);
            this.lbltodas.Name = "lbltodas";
            this.lbltodas.Size = new System.Drawing.Size(0, 13);
            this.lbltodas.TabIndex = 18;
            this.lbltodas.Click += new System.EventHandler(this.lbltodas_Click);
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.Location = new System.Drawing.Point(491, 118);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(0, 13);
            this.lblNorte.TabIndex = 19;
            this.lblNorte.Click += new System.EventHandler(this.lblNorte_Click);
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.Location = new System.Drawing.Point(494, 159);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(0, 13);
            this.lblNordeste.TabIndex = 20;
            this.lblNordeste.Click += new System.EventHandler(this.lblNordeste_Click);
            // 
            // lblCentroOeste
            // 
            this.lblCentroOeste.AutoSize = true;
            this.lblCentroOeste.Location = new System.Drawing.Point(494, 204);
            this.lblCentroOeste.Name = "lblCentroOeste";
            this.lblCentroOeste.Size = new System.Drawing.Size(0, 13);
            this.lblCentroOeste.TabIndex = 21;
            this.lblCentroOeste.Click += new System.EventHandler(this.lblCentroOeste_Click);
            // 
            // lblSudeste
            // 
            this.lblSudeste.AutoSize = true;
            this.lblSudeste.Location = new System.Drawing.Point(494, 246);
            this.lblSudeste.Name = "lblSudeste";
            this.lblSudeste.Size = new System.Drawing.Size(0, 13);
            this.lblSudeste.TabIndex = 22;
            this.lblSudeste.Click += new System.EventHandler(this.lblSudeste_Click);
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.Location = new System.Drawing.Point(494, 291);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(0, 13);
            this.lblSul.TabIndex = 23;
            this.lblSul.Click += new System.EventHandler(this.lblSul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.lblSudeste);
            this.Controls.Add(this.lblCentroOeste);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.lbltodas);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.cboCentroOeste);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboCentroOeste;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbltodas;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.Label lblCentroOeste;
        private System.Windows.Forms.Label lblSudeste;
        private System.Windows.Forms.Label lblSul;
    }
}

