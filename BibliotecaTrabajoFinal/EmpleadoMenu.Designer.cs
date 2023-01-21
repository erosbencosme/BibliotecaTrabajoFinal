namespace BibliotecaTrabajoFinal
{
    partial class EmpleadoMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.Location = new System.Drawing.Point(203, 3);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(194, 47);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(403, 3);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(194, 47);
            this.btnLibro.TabIndex = 2;
            this.btnLibro.Text = "Libro";
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrestamo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLibro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 53);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(176)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(603, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(194, 47);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(3, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(194, 47);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 397);
            this.panel1.TabIndex = 4;
            // 
            // EmpleadoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "EmpleadoMenu";
            this.Text = "EmpleadoMenu";
            this.Load += new System.EventHandler(this.EmpleadoMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnPrestamo;
        private Button btnLibro;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCliente;
        private Panel panel1;
        private Button btnMenu;
    }
}