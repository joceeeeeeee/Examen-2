namespace GUARDERIA
{
    partial class Form11
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataEMPLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataEMPLE = new GUARDERIA.DataEMPLE();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUARDERIADataSet6 = new GUARDERIA.GUARDERIADataSet6();
            this.eMPLEADOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOTableAdapter = new GUARDERIA.GUARDERIADataSet6TableAdapters.EMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataEMPLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEMPLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEMPLEBindingSource
            // 
            this.dataEMPLEBindingSource.DataSource = this.dataEMPLE;
            this.dataEMPLEBindingSource.Position = 0;
            // 
            // dataEMPLE
            // 
            this.dataEMPLE.DataSetName = "DataEMPLE";
            this.dataEMPLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dataemple";
            reportDataSource1.Value = this.eMPLEADOBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUARDERIA.inReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EMPLEADOBindingSource
            // 
            this.EMPLEADOBindingSource.DataMember = "EMPLEADO";
            this.EMPLEADOBindingSource.DataSource = this.dataEMPLE;
            // 
            // gUARDERIADataSet6
            // 
            this.gUARDERIADataSet6.DataSetName = "GUARDERIADataSet6";
            this.gUARDERIADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLEADOBindingSource1
            // 
            this.eMPLEADOBindingSource1.DataMember = "EMPLEADO";
            this.eMPLEADOBindingSource1.DataSource = this.gUARDERIADataSet6;
            // 
            // eMPLEADOTableAdapter
            // 
            this.eMPLEADOTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEMPLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEMPLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataEMPLEBindingSource;
        private DataEMPLE dataEMPLE;
        private System.Windows.Forms.BindingSource EMPLEADOBindingSource;
        private GUARDERIADataSet6 gUARDERIADataSet6;
        private System.Windows.Forms.BindingSource eMPLEADOBindingSource1;
        private GUARDERIADataSet6TableAdapters.EMPLEADOTableAdapter eMPLEADOTableAdapter;
    }
}