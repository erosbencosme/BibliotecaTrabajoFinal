namespace BibliotecaTrabajoFinal
{
    partial class ControlCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeCliente = new System.Windows.Forms.DateTimePicker();
            this.txtcedulacliente = new System.Windows.Forms.TextBox();
            this.txtapellidocliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 397);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(504, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(293, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.dateTimeCliente);
            this.panel1.Controls.Add(this.txtcedulacliente);
            this.panel1.Controls.Add(this.txtapellidocliente);
            this.panel1.Controls.Add(this.txtnombrecliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 391);
            this.panel1.TabIndex = 1;
            // 
            // dateTimeCliente
            // 
            this.dateTimeCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCliente.Location = new System.Drawing.Point(51, 213);
            this.dateTimeCliente.Name = "dateTimeCliente";
            this.dateTimeCliente.Size = new System.Drawing.Size(87, 23);
            this.dateTimeCliente.TabIndex = 8;
            // 
            // txtcedulacliente
            // 
            this.txtcedulacliente.Location = new System.Drawing.Point(53, 160);
            this.txtcedulacliente.Name = "txtcedulacliente";
            this.txtcedulacliente.Size = new System.Drawing.Size(100, 23);
            this.txtcedulacliente.TabIndex = 7;
            // 
            // txtapellidocliente
            // 
            this.txtapellidocliente.Location = new System.Drawing.Point(51, 106);
            this.txtapellidocliente.Name = "txtapellidocliente";
            this.txtapellidocliente.Size = new System.Drawing.Size(161, 23);
            this.txtapellidocliente.TabIndex = 6;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(51, 57);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(161, 23);
            this.txtnombrecliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizarCliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBorrarCliente, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 349);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnAgregarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(159, 36);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnActualizarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCliente.Location = new System.Drawing.Point(168, 3);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(159, 36);
            this.btnActualizarCliente.TabIndex = 1;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnBorrarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBorrarCliente.Location = new System.Drawing.Point(333, 3);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(159, 36);
            this.btnBorrarCliente.TabIndex = 2;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            // 
            // ControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlCliente";
            this.Size = new System.Drawing.Size(800, 397);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarCliente;
        private Button btnActualizarCliente;
        private Button btnBorrarCliente;
        private Label label1;
        private TextBox txtcedulacliente;
        private TextBox txtapellidocliente;
        private TextBox txtnombrecliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimeCliente;
    }
}
