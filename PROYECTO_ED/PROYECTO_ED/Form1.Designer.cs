namespace PROYECTO_ED
{
    partial class Form1
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
            btnImportar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnEncriptar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tb_sitename = new TextBox();
            tb_username = new TextBox();
            tb_password = new TextBox();
            tb_url = new TextBox();
            tb_notes = new TextBox();
            tb_extra1 = new TextBox();
            tb_extra2 = new TextBox();
            tb_extra3 = new TextBox();
            tb_extra4 = new TextBox();
            tb_extra5 = new TextBox();
            tb_tags = new TextBox();
            tb_icon = new TextBox();
            tb_json = new TextBox();
            btnAgregar = new Button();
            btnActivarAgregar = new Button();
            btnActivarModificar = new Button();
            comboBox1 = new ComboBox();
            tb_buscar = new TextBox();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnLlaveMaestra = new Button();
            btnInactividad = new Button();
            btnConfigurarPortapapeles = new Button();
            SuspendLayout();
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(1247, 11);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(146, 65);
            btnImportar.TabIndex = 0;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 29);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(927, 33);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(53, 30);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el Archivo:";
            // 
            // btnEncriptar
            // 
            btnEncriptar.Location = new Point(1422, 651);
            btnEncriptar.Margin = new Padding(3, 2, 3, 2);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(185, 58);
            btnEncriptar.TabIndex = 5;
            btnEncriptar.Text = "Exportar";
            btnEncriptar.UseVisualStyleBackColor = true;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1442, 731);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(193, 54);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(854, 266);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 47;
            label2.Text = "Site Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(854, 335);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 48;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(854, 398);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 49;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(854, 460);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 50;
            label5.Text = "URL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(854, 518);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 51;
            label6.Text = "Notes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1267, 266);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 52;
            label7.Text = "Extra 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1267, 335);
            label8.Name = "label8";
            label8.Size = new Size(73, 28);
            label8.TabIndex = 53;
            label8.Text = "Extra 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1267, 398);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 54;
            label9.Text = "Extra 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1267, 460);
            label10.Name = "label10";
            label10.Size = new Size(74, 28);
            label10.TabIndex = 55;
            label10.Text = "Extra 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1267, 518);
            label11.Name = "label11";
            label11.Size = new Size(73, 28);
            label11.TabIndex = 56;
            label11.Text = "Extra 5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(856, 582);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 57;
            label12.Text = "Tangs";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1276, 585);
            label13.Name = "label13";
            label13.Size = new Size(51, 28);
            label13.TabIndex = 58;
            label13.Text = "Icon";
            // 
            // tb_sitename
            // 
            tb_sitename.Location = new Point(981, 263);
            tb_sitename.Name = "tb_sitename";
            tb_sitename.Size = new Size(246, 33);
            tb_sitename.TabIndex = 59;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(981, 330);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(246, 33);
            tb_username.TabIndex = 60;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(981, 393);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(246, 33);
            tb_password.TabIndex = 61;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(981, 460);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(246, 33);
            tb_url.TabIndex = 62;
            // 
            // tb_notes
            // 
            tb_notes.Location = new Point(981, 518);
            tb_notes.Name = "tb_notes";
            tb_notes.Size = new Size(246, 33);
            tb_notes.TabIndex = 63;
            // 
            // tb_extra1
            // 
            tb_extra1.Location = new Point(1361, 266);
            tb_extra1.Name = "tb_extra1";
            tb_extra1.Size = new Size(246, 33);
            tb_extra1.TabIndex = 64;
            // 
            // tb_extra2
            // 
            tb_extra2.Location = new Point(1361, 330);
            tb_extra2.Name = "tb_extra2";
            tb_extra2.Size = new Size(246, 33);
            tb_extra2.TabIndex = 65;
            // 
            // tb_extra3
            // 
            tb_extra3.Location = new Point(1361, 393);
            tb_extra3.Name = "tb_extra3";
            tb_extra3.Size = new Size(246, 33);
            tb_extra3.TabIndex = 66;
            // 
            // tb_extra4
            // 
            tb_extra4.Location = new Point(1361, 457);
            tb_extra4.Name = "tb_extra4";
            tb_extra4.Size = new Size(246, 33);
            tb_extra4.TabIndex = 67;
            // 
            // tb_extra5
            // 
            tb_extra5.Location = new Point(1361, 518);
            tb_extra5.Name = "tb_extra5";
            tb_extra5.Size = new Size(246, 33);
            tb_extra5.TabIndex = 68;
            // 
            // tb_tags
            // 
            tb_tags.Location = new Point(981, 586);
            tb_tags.Name = "tb_tags";
            tb_tags.Size = new Size(246, 33);
            tb_tags.TabIndex = 69;
            // 
            // tb_icon
            // 
            tb_icon.Location = new Point(1361, 582);
            tb_icon.Name = "tb_icon";
            tb_icon.Size = new Size(246, 33);
            tb_icon.TabIndex = 70;
            // 
            // tb_json
            // 
            tb_json.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_json.Location = new Point(27, 92);
            tb_json.Multiline = true;
            tb_json.Name = "tb_json";
            tb_json.ReadOnly = true;
            tb_json.RightToLeft = RightToLeft.No;
            tb_json.ScrollBars = ScrollBars.Both;
            tb_json.Size = new Size(798, 590);
            tb_json.TabIndex = 71;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(967, 651);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 58);
            btnAgregar.TabIndex = 72;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActivarAgregar
            // 
            btnActivarAgregar.ForeColor = SystemColors.ControlText;
            btnActivarAgregar.Location = new Point(967, 101);
            btnActivarAgregar.Name = "btnActivarAgregar";
            btnActivarAgregar.Size = new Size(257, 62);
            btnActivarAgregar.TabIndex = 73;
            btnActivarAgregar.Text = "Activar Agregar";
            btnActivarAgregar.UseVisualStyleBackColor = true;
            btnActivarAgregar.Click += btnActivarAgregar_Click;
            // 
            // btnActivarModificar
            // 
            btnActivarModificar.Location = new Point(1267, 101);
            btnActivarModificar.Name = "btnActivarModificar";
            btnActivarModificar.Size = new Size(257, 62);
            btnActivarModificar.TabIndex = 74;
            btnActivarModificar.Text = "Activar Modificar/Buscar";
            btnActivarModificar.UseVisualStyleBackColor = true;
            btnActivarModificar.Click += btnActivarModificar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "site name", "username" });
            comboBox1.Location = new Point(940, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 33);
            comboBox1.TabIndex = 75;
            // 
            // tb_buscar
            // 
            tb_buscar.Location = new Point(1197, 190);
            tb_buscar.Name = "tb_buscar";
            tb_buscar.Size = new Size(192, 33);
            tb_buscar.TabIndex = 76;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1442, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 55);
            btnBuscar.TabIndex = 77;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1197, 651);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(185, 58);
            btnModificar.TabIndex = 78;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLlaveMaestra
            // 
            btnLlaveMaestra.Location = new Point(345, 702);
            btnLlaveMaestra.Name = "btnLlaveMaestra";
            btnLlaveMaestra.Size = new Size(169, 74);
            btnLlaveMaestra.TabIndex = 79;
            btnLlaveMaestra.Text = "Llave Maestra";
            btnLlaveMaestra.UseVisualStyleBackColor = true;
            btnLlaveMaestra.Click += btnLlaveMaestra_Click;
            // 
            // btnInactividad
            // 
            btnInactividad.Location = new Point(97, 702);
            btnInactividad.Name = "btnInactividad";
            btnInactividad.Size = new Size(213, 74);
            btnInactividad.TabIndex = 80;
            btnInactividad.Text = "Configurar Tiempo Inactividad";
            btnInactividad.UseVisualStyleBackColor = true;
            btnInactividad.Click += btnInactividad_Click;
            // 
            // btnConfigurarPortapapeles
            // 
            btnConfigurarPortapapeles.Location = new Point(547, 702);
            btnConfigurarPortapapeles.Name = "btnConfigurarPortapapeles";
            btnConfigurarPortapapeles.Size = new Size(219, 74);
            btnConfigurarPortapapeles.TabIndex = 81;
            btnConfigurarPortapapeles.Text = "Configurar Tiempo Portapapeles";
            btnConfigurarPortapapeles.UseVisualStyleBackColor = true;
            btnConfigurarPortapapeles.Click += btnConfigurarPortapapeles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1667, 808);
            Controls.Add(btnConfigurarPortapapeles);
            Controls.Add(btnInactividad);
            Controls.Add(btnLlaveMaestra);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(tb_buscar);
            Controls.Add(comboBox1);
            Controls.Add(btnActivarModificar);
            Controls.Add(btnActivarAgregar);
            Controls.Add(btnAgregar);
            Controls.Add(tb_json);
            Controls.Add(tb_icon);
            Controls.Add(tb_tags);
            Controls.Add(tb_extra5);
            Controls.Add(tb_extra4);
            Controls.Add(tb_extra3);
            Controls.Add(tb_extra2);
            Controls.Add(tb_extra1);
            Controls.Add(tb_notes);
            Controls.Add(tb_url);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(tb_sitename);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnEncriptar);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnImportar);
            Font = new Font("Segoe UI Semibold", 8.142858F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImportar;
        private TextBox textBox1;
        private Label label1;
        private Button btnEncriptar;
        private Button btnSalir;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tb_sitename;
        private TextBox tb_username;
        private TextBox tb_password;
        private TextBox tb_url;
        private TextBox tb_notes;
        private TextBox tb_extra1;
        private TextBox tb_extra2;
        private TextBox tb_extra3;
        private TextBox tb_extra4;
        private TextBox tb_extra5;
        private TextBox tb_tags;
        private TextBox tb_icon;
        private TextBox tb_json;
        private Button btnAgregar;
        private Button btnActivarAgregar;
        private Button btnActivarModificar;
        private ComboBox comboBox1;
        private TextBox tb_buscar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnLlaveMaestra;
        private Button btnInactividad;
        private Button btnConfigurarPortapapeles;
    }
}
