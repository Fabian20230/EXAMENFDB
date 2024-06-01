namespace EXAMENFDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.textBoxcondicion = new System.Windows.Forms.TextBox();
            this.textBoxsexo = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raza";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Condicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sexo";
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.Beige;
            this.textBoxid.Location = new System.Drawing.Point(162, 99);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 22);
            this.textBoxid.TabIndex = 8;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.BackColor = System.Drawing.Color.Beige;
            this.textBoxnombre.Location = new System.Drawing.Point(162, 135);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxnombre.TabIndex = 9;
            // 
            // textBoxraza
            // 
            this.textBoxraza.BackColor = System.Drawing.Color.Beige;
            this.textBoxraza.Location = new System.Drawing.Point(162, 203);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(208, 22);
            this.textBoxraza.TabIndex = 10;
            this.textBoxraza.TextChanged += new System.EventHandler(this.textBoxraza_TextChanged);
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.BackColor = System.Drawing.Color.Beige;
            this.textBoxcolor.Location = new System.Drawing.Point(162, 236);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.Size = new System.Drawing.Size(208, 22);
            this.textBoxcolor.TabIndex = 11;
            // 
            // textBoxcondicion
            // 
            this.textBoxcondicion.BackColor = System.Drawing.Color.Beige;
            this.textBoxcondicion.Location = new System.Drawing.Point(162, 268);
            this.textBoxcondicion.Name = "textBoxcondicion";
            this.textBoxcondicion.Size = new System.Drawing.Size(290, 22);
            this.textBoxcondicion.TabIndex = 12;
            // 
            // textBoxsexo
            // 
            this.textBoxsexo.BackColor = System.Drawing.Color.Beige;
            this.textBoxsexo.Location = new System.Drawing.Point(162, 300);
            this.textBoxsexo.Name = "textBoxsexo";
            this.textBoxsexo.Size = new System.Drawing.Size(100, 22);
            this.textBoxsexo.TabIndex = 13;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(162, 166);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(277, 22);
            this.dateTimePicker.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buttonbuscar);
            this.groupBox1.Controls.Add(this.buttonactualizar);
            this.groupBox1.Controls.Add(this.buttonborrar);
            this.groupBox1.Controls.Add(this.buttoncrear);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(614, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 236);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.button2.Location = new System.Drawing.Point(244, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir de la aplicacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.buttonbuscar.Location = new System.Drawing.Point(244, 99);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(123, 50);
            this.buttonbuscar.TabIndex = 4;
            this.buttonbuscar.Text = "Buscar  un perro";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.buttonactualizar.Location = new System.Drawing.Point(18, 99);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(123, 50);
            this.buttonactualizar.TabIndex = 3;
            this.buttonactualizar.Text = "Actualizar datos de un perro";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.buttonborrar.Location = new System.Drawing.Point(244, 34);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(123, 50);
            this.buttonborrar.TabIndex = 2;
            this.buttonborrar.Text = "Borrar de la lista a un perro adoptado";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
            // 
            // buttoncrear
            // 
            this.buttoncrear.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.buttoncrear.Location = new System.Drawing.Point(18, 169);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(123, 50);
            this.buttoncrear.TabIndex = 1;
            this.buttoncrear.Text = "Dar en adopcion a un perro";
            this.buttoncrear.UseVisualStyleBackColor = true;
            this.buttoncrear.Click += new System.EventHandler(this.buttoncrear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::EXAMENFDB.Properties.Resources.ADOP;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::EXAMENFDB.Properties.Resources.ADOP;
            this.button1.Location = new System.Drawing.Point(18, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar lista de perritos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(260, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(495, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "ENCUENTRA A TU MASCOTA IDEAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1039, 674);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxsexo);
            this.Controls.Add(this.textBoxcondicion);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.textBoxraza);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "MASCOTITAS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxraza;
        private System.Windows.Forms.TextBox textBoxcolor;
        private System.Windows.Forms.TextBox textBoxcondicion;
        private System.Windows.Forms.TextBox textBoxsexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}

