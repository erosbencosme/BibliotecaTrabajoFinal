namespace BibliotecaTrabajoFinal
{
    partial class ControlPrestamo
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearPrestamo = new System.Windows.Forms.Button();
            this.btnActualizarPrestamo = new System.Windows.Forms.Button();
            this.btnDevolucionPrestamo = new System.Windows.Forms.Button();
            this.comboBoxLibro = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPrestamo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.comboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.125F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(530, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(267, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxMetodoPago);
            this.panel1.Controls.Add(this.comboBoxClientes);
            this.panel1.Controls.Add(this.dateTimePickerPrestamo);
            this.panel1.Controls.Add(this.comboBoxLibro);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 391);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnDevolucionPrestamo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizarPrestamo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCrearPrestamo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 351);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCrearPrestamo
            // 
            this.btnCrearPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnCrearPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnCrearPrestamo.Location = new System.Drawing.Point(3, 3);
            this.btnCrearPrestamo.Name = "btnCrearPrestamo";
            this.btnCrearPrestamo.Size = new System.Drawing.Size(167, 34);
            this.btnCrearPrestamo.TabIndex = 0;
            this.btnCrearPrestamo.Text = "Crear";
            this.btnCrearPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarPrestamo
            // 
            this.btnActualizarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnActualizarPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPrestamo.Location = new System.Drawing.Point(176, 3);
            this.btnActualizarPrestamo.Name = "btnActualizarPrestamo";
            this.btnActualizarPrestamo.Size = new System.Drawing.Size(167, 34);
            this.btnActualizarPrestamo.TabIndex = 1;
            this.btnActualizarPrestamo.Text = "Actualizar";
            this.btnActualizarPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnDevolucionPrestamo
            // 
            this.btnDevolucionPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnDevolucionPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevolucionPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnDevolucionPrestamo.Location = new System.Drawing.Point(349, 3);
            this.btnDevolucionPrestamo.Name = "btnDevolucionPrestamo";
            this.btnDevolucionPrestamo.Size = new System.Drawing.Size(169, 34);
            this.btnDevolucionPrestamo.TabIndex = 2;
            this.btnDevolucionPrestamo.Text = "Devolucion";
            this.btnDevolucionPrestamo.UseVisualStyleBackColor = false;
            // 
            // comboBoxLibro
            // 
            this.comboBoxLibro.FormattingEnabled = true;
            this.comboBoxLibro.Location = new System.Drawing.Point(49, 62);
            this.comboBoxLibro.Name = "comboBoxLibro";
            this.comboBoxLibro.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLibro.TabIndex = 1;
            // 
            // dateTimePickerPrestamo
            // 
            this.dateTimePickerPrestamo.Location = new System.Drawing.Point(49, 122);
            this.dateTimePickerPrestamo.Name = "dateTimePickerPrestamo";
            this.dateTimePickerPrestamo.Size = new System.Drawing.Size(190, 23);
            this.dateTimePickerPrestamo.TabIndex = 2;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(49, 187);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClientes.TabIndex = 3;
            // 
            // comboBoxMetodoPago
            // 
            this.comboBoxMetodoPago.FormattingEnabled = true;
            this.comboBoxMetodoPago.Location = new System.Drawing.Point(52, 245);
            this.comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            this.comboBoxMetodoPago.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMetodoPago.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Limite de Prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metodo de pago:";
            // 
            // ControlPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlPrestamo";
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
        private Button btnDevolucionPrestamo;
        private Button btnActualizarPrestamo;
        private Button btnCrearPrestamo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxMetodoPago;
        private ComboBox comboBoxClientes;
        private DateTimePicker dateTimePickerPrestamo;
        private ComboBox comboBoxLibro;
    }
}
