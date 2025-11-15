namespace ParcialProgramacionManuelRompani
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.cboxTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboxPlanWifi = new System.Windows.Forms.ComboBox();
            this.tboxGbConsumidos = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.tboxCostoMensual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxNombrePlanWifi = new System.Windows.Forms.TextBox();
            this.tboxCostoGbExtra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarPlanWifi = new System.Windows.Forms.Button();
            this.lblClienteMasPaga = new System.Windows.Forms.Label();
            this.lblPromedioNormales = new System.Windows.Forms.Label();
            this.dgvClientesMas15Gb = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesMas15Gb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(210, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(542, 150);
            this.dgvClientes.TabIndex = 0;
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(24, 54);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(100, 20);
            this.tboxDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alta cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plan de Wifi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "GB Consumidos";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(24, 105);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 8;
            // 
            // cboxTipoCliente
            // 
            this.cboxTipoCliente.FormattingEnabled = true;
            this.cboxTipoCliente.Location = new System.Drawing.Point(24, 156);
            this.cboxTipoCliente.Name = "cboxTipoCliente";
            this.cboxTipoCliente.Size = new System.Drawing.Size(100, 21);
            this.cboxTipoCliente.TabIndex = 9;
            // 
            // cboxPlanWifi
            // 
            this.cboxPlanWifi.FormattingEnabled = true;
            this.cboxPlanWifi.Location = new System.Drawing.Point(24, 208);
            this.cboxPlanWifi.Name = "cboxPlanWifi";
            this.cboxPlanWifi.Size = new System.Drawing.Size(100, 21);
            this.cboxPlanWifi.TabIndex = 10;
            // 
            // tboxGbConsumidos
            // 
            this.tboxGbConsumidos.Location = new System.Drawing.Point(24, 260);
            this.tboxGbConsumidos.Name = "tboxGbConsumidos";
            this.tboxGbConsumidos.Size = new System.Drawing.Size(100, 20);
            this.tboxGbConsumidos.TabIndex = 11;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(49, 298);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 12;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // tboxCostoMensual
            // 
            this.tboxCostoMensual.Location = new System.Drawing.Point(796, 105);
            this.tboxCostoMensual.Name = "tboxCostoMensual";
            this.tboxCostoMensual.Size = new System.Drawing.Size(100, 20);
            this.tboxCostoMensual.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Costo Mensual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(793, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Alta Plan";
            // 
            // tboxNombrePlanWifi
            // 
            this.tboxNombrePlanWifi.Location = new System.Drawing.Point(796, 54);
            this.tboxNombrePlanWifi.Name = "tboxNombrePlanWifi";
            this.tboxNombrePlanWifi.Size = new System.Drawing.Size(100, 20);
            this.tboxNombrePlanWifi.TabIndex = 13;
            // 
            // tboxCostoGbExtra
            // 
            this.tboxCostoGbExtra.Location = new System.Drawing.Point(796, 157);
            this.tboxCostoGbExtra.Name = "tboxCostoGbExtra";
            this.tboxCostoGbExtra.Size = new System.Drawing.Size(100, 20);
            this.tboxCostoGbExtra.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(793, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Costo por GB extra";
            // 
            // btnAgregarPlanWifi
            // 
            this.btnAgregarPlanWifi.Location = new System.Drawing.Point(821, 191);
            this.btnAgregarPlanWifi.Name = "btnAgregarPlanWifi";
            this.btnAgregarPlanWifi.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPlanWifi.TabIndex = 20;
            this.btnAgregarPlanWifi.Text = "Agregar Cliente";
            this.btnAgregarPlanWifi.UseVisualStyleBackColor = true;
            this.btnAgregarPlanWifi.Click += new System.EventHandler(this.btnAgregarPlanWifi_Click);
            // 
            // lblClienteMasPaga
            // 
            this.lblClienteMasPaga.AutoSize = true;
            this.lblClienteMasPaga.Location = new System.Drawing.Point(207, 208);
            this.lblClienteMasPaga.Name = "lblClienteMasPaga";
            this.lblClienteMasPaga.Size = new System.Drawing.Size(112, 13);
            this.lblClienteMasPaga.TabIndex = 21;
            this.lblClienteMasPaga.Text = "Cliente que mas paga:";
            // 
            // lblPromedioNormales
            // 
            this.lblPromedioNormales.AutoSize = true;
            this.lblPromedioNormales.Location = new System.Drawing.Point(207, 229);
            this.lblPromedioNormales.Name = "lblPromedioNormales";
            this.lblPromedioNormales.Size = new System.Drawing.Size(180, 13);
            this.lblPromedioNormales.TabIndex = 22;
            this.lblPromedioNormales.Text = "Promedio mensual clientes normales:";
            // 
            // dgvClientesMas15Gb
            // 
            this.dgvClientesMas15Gb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesMas15Gb.Location = new System.Drawing.Point(210, 288);
            this.dgvClientesMas15Gb.Name = "dgvClientesMas15Gb";
            this.dgvClientesMas15Gb.Size = new System.Drawing.Size(542, 150);
            this.dgvClientesMas15Gb.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Clientes que consumieron mas de 15GB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Clientes totales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvClientesMas15Gb);
            this.Controls.Add(this.lblPromedioNormales);
            this.Controls.Add(this.lblClienteMasPaga);
            this.Controls.Add(this.btnAgregarPlanWifi);
            this.Controls.Add(this.tboxCostoGbExtra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tboxCostoMensual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tboxNombrePlanWifi);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.tboxGbConsumidos);
            this.Controls.Add(this.cboxPlanWifi);
            this.Controls.Add(this.cboxTipoCliente);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesMas15Gb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.ComboBox cboxTipoCliente;
        private System.Windows.Forms.ComboBox cboxPlanWifi;
        private System.Windows.Forms.TextBox tboxGbConsumidos;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox tboxCostoMensual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxNombrePlanWifi;
        private System.Windows.Forms.TextBox tboxCostoGbExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarPlanWifi;
        private System.Windows.Forms.Label lblClienteMasPaga;
        private System.Windows.Forms.Label lblPromedioNormales;
        private System.Windows.Forms.DataGridView dgvClientesMas15Gb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

