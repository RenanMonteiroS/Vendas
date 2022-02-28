namespace testemenubd2
{
    partial class funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(funcionario));
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combofuncaofunc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcelularfunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemailfunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtenderecofunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomefunc = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(89, 72);
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(632, 150);
            this.grdDados.TabIndex = 5;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            this.grdDados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Location = new System.Drawing.Point(15, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(468, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 50);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(294, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(54, 54);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.White;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(203, 15);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(58, 50);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(373, 20);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(71, 45);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combofuncaofunc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtcelularfunc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtemailfunc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtenderecofunc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnomefunc);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // combofuncaofunc
            // 
            this.combofuncaofunc.FormattingEnabled = true;
            this.combofuncaofunc.Location = new System.Drawing.Point(600, 45);
            this.combofuncaofunc.Name = "combofuncaofunc";
            this.combofuncaofunc.Size = new System.Drawing.Size(121, 21);
            this.combofuncaofunc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Função:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Celular:";
            // 
            // txtcelularfunc
            // 
            this.txtcelularfunc.Location = new System.Drawing.Point(337, 95);
            this.txtcelularfunc.Name = "txtcelularfunc";
            this.txtcelularfunc.Size = new System.Drawing.Size(100, 20);
            this.txtcelularfunc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail:";
            // 
            // txtemailfunc
            // 
            this.txtemailfunc.Location = new System.Drawing.Point(337, 46);
            this.txtemailfunc.Name = "txtemailfunc";
            this.txtemailfunc.Size = new System.Drawing.Size(100, 20);
            this.txtemailfunc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço:";
            // 
            // txtenderecofunc
            // 
            this.txtenderecofunc.Location = new System.Drawing.Point(110, 95);
            this.txtenderecofunc.Name = "txtenderecofunc";
            this.txtenderecofunc.Size = new System.Drawing.Size(100, 20);
            this.txtenderecofunc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtnomefunc
            // 
            this.txtnomefunc.Location = new System.Drawing.Point(110, 46);
            this.txtnomefunc.Name = "txtnomefunc";
            this.txtnomefunc.Size = new System.Drawing.Size(100, 20);
            this.txtnomefunc.TabIndex = 2;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(201, 37);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(360, 20);
            this.txtBusca.TabIndex = 6;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busca:";
            // 
            // funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "funcionario";
            this.Text = "funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combofuncaofunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcelularfunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemailfunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtenderecofunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomefunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
    }
}