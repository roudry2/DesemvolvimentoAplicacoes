namespace StandAuto
{
    partial class frmOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOficina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParcelas = new System.Windows.Forms.Button();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.ListBox();
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.lbServiços = new System.Windows.Forms.ListBox();
            this.lbParcelas = new System.Windows.Forms.ListBox();
            this.lvlNomeCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblNrTele = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblNrTele);
            this.panel1.Controls.Add(this.lblNif);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lvlNomeCliente);
            this.panel1.Location = new System.Drawing.Point(236, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 95);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCarros);
            this.groupBox2.Location = new System.Drawing.Point(236, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbServiços);
            this.groupBox3.Location = new System.Drawing.Point(437, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbParcelas);
            this.groupBox4.Location = new System.Drawing.Point(626, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 265);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parcelas";
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(236, 439);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(178, 23);
            this.btnCarros.TabIndex = 4;
            this.btnCarros.Text = "Adicionar Carro";
            this.btnCarros.UseVisualStyleBackColor = true;
            // 
            // btnServiços
            // 
            this.btnServiços.Location = new System.Drawing.Point(437, 439);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(178, 23);
            this.btnServiços.TabIndex = 5;
            this.btnServiços.Text = "Criar Serviço";
            this.btnServiços.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor:";
            // 
            // btnParcelas
            // 
            this.btnParcelas.Location = new System.Drawing.Point(696, 439);
            this.btnParcelas.Name = "btnParcelas";
            this.btnParcelas.Size = new System.Drawing.Size(185, 23);
            this.btnParcelas.TabIndex = 8;
            this.btnParcelas.Text = "Adicionar Parcela";
            this.btnParcelas.UseVisualStyleBackColor = true;
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(686, 385);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(206, 20);
            this.txtDescrição.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(686, 409);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(206, 20);
            this.txtValor.TabIndex = 10;
            // 
            // lbCliente
            // 
            this.lbCliente.FormattingEnabled = true;
            this.lbCliente.Location = new System.Drawing.Point(7, 20);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(193, 420);
            this.lbCliente.TabIndex = 0;
            // 
            // lbCarros
            // 
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.Location = new System.Drawing.Point(6, 19);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(166, 290);
            this.lbCarros.TabIndex = 0;
            // 
            // lbServiços
            // 
            this.lbServiços.FormattingEnabled = true;
            this.lbServiços.Location = new System.Drawing.Point(6, 19);
            this.lbServiços.Name = "lbServiços";
            this.lbServiços.Size = new System.Drawing.Size(166, 290);
            this.lbServiços.TabIndex = 1;
            // 
            // lbParcelas
            // 
            this.lbParcelas.FormattingEnabled = true;
            this.lbParcelas.Location = new System.Drawing.Point(6, 19);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(254, 238);
            this.lbParcelas.TabIndex = 2;
            // 
            // lvlNomeCliente
            // 
            this.lvlNomeCliente.AutoSize = true;
            this.lvlNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNomeCliente.Location = new System.Drawing.Point(3, 11);
            this.lvlNomeCliente.Name = "lvlNomeCliente";
            this.lvlNomeCliente.Size = new System.Drawing.Size(234, 22);
            this.lvlNomeCliente.TabIndex = 0;
            this.lvlNomeCliente.Text = "Sem Cliente Selecionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Total:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(16, 43);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(18, 13);
            this.lblNif.TabIndex = 2;
            this.lblNif.Text = "nif";
            // 
            // lblNrTele
            // 
            this.lblNrTele.AutoSize = true;
            this.lblNrTele.Location = new System.Drawing.Point(16, 66);
            this.lblNrTele.Name = "lblNrTele";
            this.lblNrTele.Size = new System.Drawing.Size(37, 13);
            this.lblNrTele.TabIndex = 3;
            this.lblNrTele.Text = "nrTele";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(610, 20);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "€";
            // 
            // frmOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 472);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.btnParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServiços);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOficina";
            this.Text = "Oficina";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblNrTele;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lvlNomeCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbCarros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbServiços;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbParcelas;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnServiços;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParcelas;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.TextBox txtValor;
    }
}