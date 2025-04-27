namespace GUARDERIA
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbexpediente = new System.Windows.Forms.ComboBox();
            this.eXPEDIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUARDERIADataSet = new GUARDERIA.GUARDERIADataSet();
            this.cbbsalon = new System.Windows.Forms.ComboBox();
            this.sALONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUARDERIADataSet1 = new GUARDERIA.GUARDERIADataSet1();
            this.cbbtutor = new System.Windows.Forms.ComboBox();
            this.tUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUARDERIADataSet2 = new GUARDERIA.GUARDERIADataSet2();
            this.cbbempleado = new System.Windows.Forms.ComboBox();
            this.eMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUARDERIADataSet3 = new GUARDERIA.GUARDERIADataSet3();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.eXPEDIENTETableAdapter = new GUARDERIA.GUARDERIADataSetTableAdapters.EXPEDIENTETableAdapter();
            this.sALONTableAdapter = new GUARDERIA.GUARDERIADataSet1TableAdapters.SALONTableAdapter();
            this.tUTORTableAdapter = new GUARDERIA.GUARDERIADataSet2TableAdapters.TUTORTableAdapter();
            this.eMPLEADOTableAdapter = new GUARDERIA.GUARDERIADataSet3TableAdapters.EMPLEADOTableAdapter();
            this.btnReporte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(439, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 31);
            this.label12.TabIndex = 49;
            this.label12.Text = "Datos del niño";
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(529, 297);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(206, 22);
            this.txtcurp.TabIndex = 42;
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(529, 269);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(95, 22);
            this.txtgrupo.TabIndex = 40;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(529, 236);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 22);
            this.txtnombre.TabIndex = 39;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(529, 205);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(147, 22);
            this.txtcodigo.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Codigo del salon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Codigo del expediente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre del niño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numero de control del niño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Codigo del tutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Codigo del empleado";
            // 
            // cbbexpediente
            // 
            this.cbbexpediente.DataSource = this.eXPEDIENTEBindingSource;
            this.cbbexpediente.DisplayMember = "ID_EXPEDIENTE";
            this.cbbexpediente.FormattingEnabled = true;
            this.cbbexpediente.Location = new System.Drawing.Point(529, 327);
            this.cbbexpediente.Name = "cbbexpediente";
            this.cbbexpediente.Size = new System.Drawing.Size(121, 24);
            this.cbbexpediente.TabIndex = 58;
            this.cbbexpediente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eXPEDIENTEBindingSource
            // 
            this.eXPEDIENTEBindingSource.DataMember = "EXPEDIENTE";
            this.eXPEDIENTEBindingSource.DataSource = this.gUARDERIADataSet;
            // 
            // gUARDERIADataSet
            // 
            this.gUARDERIADataSet.DataSetName = "GUARDERIADataSet";
            this.gUARDERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbsalon
            // 
            this.cbbsalon.DataSource = this.sALONBindingSource;
            this.cbbsalon.DisplayMember = "ID_SALON";
            this.cbbsalon.FormattingEnabled = true;
            this.cbbsalon.Location = new System.Drawing.Point(529, 354);
            this.cbbsalon.Name = "cbbsalon";
            this.cbbsalon.Size = new System.Drawing.Size(121, 24);
            this.cbbsalon.TabIndex = 59;
            // 
            // sALONBindingSource
            // 
            this.sALONBindingSource.DataMember = "SALON";
            this.sALONBindingSource.DataSource = this.gUARDERIADataSet1;
            // 
            // gUARDERIADataSet1
            // 
            this.gUARDERIADataSet1.DataSetName = "GUARDERIADataSet1";
            this.gUARDERIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbtutor
            // 
            this.cbbtutor.DataSource = this.tUTORBindingSource;
            this.cbbtutor.DisplayMember = "ID_TUTOR";
            this.cbbtutor.FormattingEnabled = true;
            this.cbbtutor.Location = new System.Drawing.Point(529, 382);
            this.cbbtutor.Name = "cbbtutor";
            this.cbbtutor.Size = new System.Drawing.Size(121, 24);
            this.cbbtutor.TabIndex = 60;
            // 
            // tUTORBindingSource
            // 
            this.tUTORBindingSource.DataMember = "TUTOR";
            this.tUTORBindingSource.DataSource = this.gUARDERIADataSet2;
            // 
            // gUARDERIADataSet2
            // 
            this.gUARDERIADataSet2.DataSetName = "GUARDERIADataSet2";
            this.gUARDERIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbempleado
            // 
            this.cbbempleado.DataSource = this.eMPLEADOBindingSource;
            this.cbbempleado.DisplayMember = "ID_EMPLEADO";
            this.cbbempleado.FormattingEnabled = true;
            this.cbbempleado.Location = new System.Drawing.Point(529, 410);
            this.cbbempleado.Name = "cbbempleado";
            this.cbbempleado.Size = new System.Drawing.Size(121, 24);
            this.cbbempleado.TabIndex = 61;
            // 
            // eMPLEADOBindingSource
            // 
            this.eMPLEADOBindingSource.DataMember = "EMPLEADO";
            this.eMPLEADOBindingSource.DataSource = this.gUARDERIADataSet3;
            // 
            // gUARDERIADataSet3
            // 
            this.gUARDERIADataSet3.DataSetName = "GUARDERIADataSet3";
            this.gUARDERIADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImage = global::GUARDERIA.Properties.Resources.png_transparent_computer_icons_house_house_angle_logo_home_icon1;
            this.btnmenu.Location = new System.Drawing.Point(596, 108);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(64, 59);
            this.btnmenu.TabIndex = 94;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::GUARDERIA.Properties.Resources.x31;
            this.btneliminar.Location = new System.Drawing.Point(526, 108);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 59);
            this.btneliminar.TabIndex = 93;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::GUARDERIA.Properties.Resources._31762382;
            this.btnbuscar.Location = new System.Drawing.Point(456, 107);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 59);
            this.btnbuscar.TabIndex = 92;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::GUARDERIA.Properties.Resources._2690742;
            this.btnmodificar.Location = new System.Drawing.Point(386, 108);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(64, 59);
            this.btnmodificar.TabIndex = 91;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::GUARDERIA.Properties.Resources.Save_371102;
            this.btnGuardar.Location = new System.Drawing.Point(316, 106);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 61);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 469);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(995, 150);
            this.DataView.TabIndex = 96;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // eXPEDIENTETableAdapter
            // 
            this.eXPEDIENTETableAdapter.ClearBeforeFill = true;
            // 
            // sALONTableAdapter
            // 
            this.sALONTableAdapter.ClearBeforeFill = true;
            // 
            // tUTORTableAdapter
            // 
            this.tUTORTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLEADOTableAdapter
            // 
            this.eMPLEADOTableAdapter.ClearBeforeFill = true;
            // 
            // btnReporte
            // 
            this.btnReporte.BackgroundImage = global::GUARDERIA.Properties.Resources.images;
            this.btnReporte.Location = new System.Drawing.Point(666, 107);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(64, 59);
            this.btnReporte.TabIndex = 103;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = global::GUARDERIA.Properties.Resources.modelo_tropical_inconsútil_de_hojas_verdes_ejemplo_mano_para_los_niños_verano_primavera_cuarto_bebé_la_hoja_fondo_142298515;
            this.button1.Location = new System.Drawing.Point(-9, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1042, 187);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUARDERIA.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1019, 632);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbbempleado);
            this.Controls.Add(this.cbbtutor);
            this.Controls.Add(this.cbbsalon);
            this.Controls.Add(this.cbbexpediente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Nino";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcurp;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbexpediente;
        private System.Windows.Forms.ComboBox cbbsalon;
        private System.Windows.Forms.ComboBox cbbtutor;
        private System.Windows.Forms.ComboBox cbbempleado;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DataView;
        private GUARDERIADataSet gUARDERIADataSet;
        private System.Windows.Forms.BindingSource eXPEDIENTEBindingSource;
        private GUARDERIADataSetTableAdapters.EXPEDIENTETableAdapter eXPEDIENTETableAdapter;
        private GUARDERIADataSet1 gUARDERIADataSet1;
        private System.Windows.Forms.BindingSource sALONBindingSource;
        private GUARDERIADataSet1TableAdapters.SALONTableAdapter sALONTableAdapter;
        private GUARDERIADataSet2 gUARDERIADataSet2;
        private System.Windows.Forms.BindingSource tUTORBindingSource;
        private GUARDERIADataSet2TableAdapters.TUTORTableAdapter tUTORTableAdapter;
        private GUARDERIADataSet3 gUARDERIADataSet3;
        private System.Windows.Forms.BindingSource eMPLEADOBindingSource;
        private GUARDERIADataSet3TableAdapters.EMPLEADOTableAdapter eMPLEADOTableAdapter;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button button1;
    }
}