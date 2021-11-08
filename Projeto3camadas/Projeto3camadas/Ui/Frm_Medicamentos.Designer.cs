
namespace Projeto3camadas.Ui
{
    partial class Frm_Medicamentos
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
            this.lblComposicao = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtComposicao = new System.Windows.Forms.TextBox();
            this.dvgMedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComposicao
            // 
            this.lblComposicao.AutoSize = true;
            this.lblComposicao.Location = new System.Drawing.Point(295, 134);
            this.lblComposicao.Name = "lblComposicao";
            this.lblComposicao.Size = new System.Drawing.Size(77, 15);
            this.lblComposicao.TabIndex = 0;
            this.lblComposicao.Text = "Composição:";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(135, 134);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(84, 15);
            this.lblMedicamento.TabIndex = 1;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 134);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(347, 181);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(173, 181);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(168, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 181);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 152);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 23);
            this.txtId.TabIndex = 6;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(135, 152);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(154, 23);
            this.txtMedicamento.TabIndex = 7;
            // 
            // txtComposicao
            // 
            this.txtComposicao.Location = new System.Drawing.Point(295, 152);
            this.txtComposicao.Name = "txtComposicao";
            this.txtComposicao.Size = new System.Drawing.Size(207, 23);
            this.txtComposicao.TabIndex = 8;
            // 
            // dvgMedicamentos
            // 
            this.dvgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMedicamentos.Location = new System.Drawing.Point(12, 210);
            this.dvgMedicamentos.Name = "dvgMedicamentos";
            this.dvgMedicamentos.RowTemplate.Height = 25;
            this.dvgMedicamentos.Size = new System.Drawing.Size(490, 228);
            this.dvgMedicamentos.TabIndex = 9;
            this.dvgMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Frm_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgMedicamentos);
            this.Controls.Add(this.txtComposicao);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblComposicao);
            this.Name = "Frm_Medicamentos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComposicao;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.TextBox txtComposicao;
        private System.Windows.Forms.DataGridView dvgMedicamentos;
    }
}

