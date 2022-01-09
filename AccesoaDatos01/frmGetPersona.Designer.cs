
namespace AccesoaDatos01
{
    partial class frmGetPersona1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkSeleccionar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE PERSONAS";
            // 
            // dgPersonas
            // 
            this.dgPersonas.AllowUserToAddRows = false;
            this.dgPersonas.AllowUserToDeleteRows = false;
            this.dgPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkEliminar,
            this.linkSeleccionar});
            this.dgPersonas.Location = new System.Drawing.Point(88, 110);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.ReadOnly = true;
            this.dgPersonas.Size = new System.Drawing.Size(639, 312);
            this.dgPersonas.TabIndex = 1;
            this.dgPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellContentClick);
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Sección";
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.ReadOnly = true;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            // 
            // linkSeleccionar
            // 
            this.linkSeleccionar.HeaderText = "Sección";
            this.linkSeleccionar.Name = "linkSeleccionar";
            this.linkSeleccionar.ReadOnly = true;
            this.linkSeleccionar.Text = "Seleccionar";
            this.linkSeleccionar.UseColumnTextForLinkValue = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(333, 68);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(137, 22);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmGetPersona1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgPersonas);
            this.Controls.Add(this.label1);
            this.Name = "frmGetPersona1";
            this.Text = "Listado de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
        private System.Windows.Forms.DataGridViewLinkColumn linkSeleccionar;
    }
}