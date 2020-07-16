namespace PROG2EVA2FranciscoArmijo
{
    partial class Acciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.botonTraspasar = new System.Windows.Forms.Button();
            this.dataAcciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 94);
            this.panel1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(294, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acciones";
            // 
            // botonTraspasar
            // 
            this.botonTraspasar.BackColor = System.Drawing.Color.YellowGreen;
            this.botonTraspasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTraspasar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonTraspasar.Location = new System.Drawing.Point(258, 97);
            this.botonTraspasar.Margin = new System.Windows.Forms.Padding(4);
            this.botonTraspasar.Name = "botonTraspasar";
            this.botonTraspasar.Size = new System.Drawing.Size(319, 50);
            this.botonTraspasar.TabIndex = 55;
            this.botonTraspasar.Text = "TRASPASAR A TABLA";
            this.botonTraspasar.UseVisualStyleBackColor = false;
            this.botonTraspasar.Click += new System.EventHandler(this.botonTraspasar_Click);
            // 
            // dataAcciones
            // 
            this.dataAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAcciones.Location = new System.Drawing.Point(12, 276);
            this.dataAcciones.Name = "dataAcciones";
            this.dataAcciones.RowHeadersWidth = 51;
            this.dataAcciones.RowTemplate.Height = 24;
            this.dataAcciones.Size = new System.Drawing.Size(825, 162);
            this.dataAcciones.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(258, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 50);
            this.button1.TabIndex = 64;
            this.button1.Text = "BUSCAR POR FECHA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(261, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Selecciona una fecha de inicio de sesión";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 22);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // Acciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataAcciones);
            this.Controls.Add(this.botonTraspasar);
            this.Controls.Add(this.panel1);
            this.Name = "Acciones";
            this.Text = "Acciones";
            this.Load += new System.EventHandler(this.Acciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonTraspasar;
        private System.Windows.Forms.DataGridView dataAcciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}