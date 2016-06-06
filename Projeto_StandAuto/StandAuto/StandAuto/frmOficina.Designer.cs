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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOficina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCliente = new System.Windows.Forms.ListBox();
            this.clienteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblNrTele = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbServiços = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbParcelas = new System.Windows.Forms.ListBox();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParcelas = new System.Windows.Forms.Button();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.clienteSetTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.ClienteSetTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.carroSet_CarroOficinaTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter();
            this.carroSet_CarroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).BeginInit();
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
            // lbCliente
            // 
            this.lbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteSetBindingSource, "IdCliente", true));
            this.lbCliente.FormattingEnabled = true;
            this.lbCliente.Location = new System.Drawing.Point(7, 19);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(193, 420);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCliente_MouseClick);
            this.lbCliente.SelectedIndexChanged += new System.EventHandler(this.lbCliente_SelectedIndexChanged);
            // 
            // clienteSetBindingSource
            // 
            this.clienteSetBindingSource.DataMember = "ClienteSet";
            this.clienteSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblNrTele);
            this.panel1.Controls.Add(this.lblNif);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Location = new System.Drawing.Point(236, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 95);
            this.panel1.TabIndex = 1;
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
            // lblNrTele
            // 
            this.lblNrTele.AutoSize = true;
            this.lblNrTele.Location = new System.Drawing.Point(16, 66);
            this.lblNrTele.Name = "lblNrTele";
            this.lblNrTele.Size = new System.Drawing.Size(37, 13);
            this.lblNrTele.TabIndex = 3;
            this.lblNrTele.Text = "nrTele";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Total:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(3, 11);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(234, 22);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Sem Cliente Selecionado";
            this.lblNomeCliente.Click += new System.EventHandler(this.lvlNomeCliente_Click);
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
            // lbCarros
            // 
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.Location = new System.Drawing.Point(6, 19);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(166, 290);
            this.lbCarros.TabIndex = 0;
            this.lbCarros.SelectedIndexChanged += new System.EventHandler(this.lbCarros_SelectedIndexChanged);
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
            // lbServiços
            // 
            this.lbServiços.FormattingEnabled = true;
            this.lbServiços.Location = new System.Drawing.Point(6, 19);
            this.lbServiços.Name = "lbServiços";
            this.lbServiços.Size = new System.Drawing.Size(166, 290);
            this.lbServiços.TabIndex = 1;
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
            // lbParcelas
            // 
            this.lbParcelas.FormattingEnabled = true;
            this.lbParcelas.Location = new System.Drawing.Point(6, 19);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(254, 238);
            this.lbParcelas.TabIndex = 2;
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(236, 439);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(178, 23);
            this.btnCarros.TabIndex = 4;
            this.btnCarros.Text = "Adicionar Carro";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
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
            // clienteSetTableAdapter
            // 
            this.clienteSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguerSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroSet_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroOficinaTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarroSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = this.clienteSetTableAdapter;
            this.tableAdapterManager.ParcelaSetTableAdapter = null;
            this.tableAdapterManager.ServiçoSetTableAdapter = null;
            //this.tableAdapterManager.UpdateOrder = StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // carroSet_CarroOficinaTableAdapter
            // 
            this.carroSet_CarroOficinaTableAdapter.ClearBeforeFill = true;
            // 
            // carroSet_CarroOficinaBindingSource
            // 
            this.carroSet_CarroOficinaBindingSource.DataMember = "CarroSet_CarroOficina";
            this.carroSet_CarroOficinaBindingSource.DataSource = this.standAutoDataSet;
            // 
            // frmOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 482);
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
            this.Activated += new System.EventHandler(this.frmOficina_Activated);
            this.Load += new System.EventHandler(this.frmOficina_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblNomeCliente;
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
        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource clienteSetBindingSource;
        private StandAutoDataSetTableAdapters.ClienteSetTableAdapter clienteSetTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter carroSet_CarroOficinaTableAdapter;
        private System.Windows.Forms.BindingSource carroSet_CarroOficinaBindingSource;
    }
}