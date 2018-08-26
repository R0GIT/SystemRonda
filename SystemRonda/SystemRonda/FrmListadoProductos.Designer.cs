namespace SystemRonda
{
    partial class FrmListadoProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCompletaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.idTipoProducto,
            this.descripcionCompletaProducto,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(144, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "codigoProducto";
            this.codigoProducto.Name = "codigoProducto";
            // 
            // idTipoProducto
            // 
            this.idTipoProducto.HeaderText = "idTipoProducto";
            this.idTipoProducto.Name = "idTipoProducto";
            // 
            // descripcionCompletaProducto
            // 
            this.descripcionCompletaProducto.HeaderText = "descripcionCompletaProducto";
            this.descripcionCompletaProducto.Name = "descripcionCompletaProducto";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SystemRonda.Properties.Resources.magnifying_glass;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(299, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 527);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListadoProductos";
            this.Text = "ListadoProductos";
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCompletaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}