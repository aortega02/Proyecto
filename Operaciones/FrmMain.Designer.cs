namespace Operaciones
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.cmbOper = new System.Windows.Forms.ComboBox();
            this.lblselec = new System.Windows.Forms.Label();
            this.btnIr = new System.Windows.Forms.Button();
            this.lblparam = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResInfo = new System.Windows.Forms.Label();
            this.gpTipoOper = new System.Windows.Forms.GroupBox();
            this.rdOpc1 = new System.Windows.Forms.RadioButton();
            this.rdOpc2 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpTipoOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOper
            // 
            this.cmbOper.FormattingEnabled = true;
            this.cmbOper.Items.AddRange(new object[] {
            "Area de un Circulo",
            "Area de un Cuadrado",
            "Cantidad de Letras",
            "Sumas"});
            this.cmbOper.Location = new System.Drawing.Point(166, 44);
            this.cmbOper.Name = "cmbOper";
            this.cmbOper.Size = new System.Drawing.Size(121, 21);
            this.cmbOper.TabIndex = 0;
            this.cmbOper.SelectedIndexChanged += new System.EventHandler(this.cmbOper_SelectedIndexChanged);
            // 
            // lblselec
            // 
            this.lblselec.AutoSize = true;
            this.lblselec.BackColor = System.Drawing.SystemColors.Window;
            this.lblselec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblselec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblselec.Location = new System.Drawing.Point(29, 47);
            this.lblselec.Name = "lblselec";
            this.lblselec.Size = new System.Drawing.Size(125, 15);
            this.lblselec.TabIndex = 1;
            this.lblselec.Text = "Seleccione la Operacion";
            this.lblselec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(126, 199);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(70, 23);
            this.btnIr.TabIndex = 2;
            this.btnIr.Text = "Calcular";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // lblparam
            // 
            this.lblparam.AutoSize = true;
            this.lblparam.BackColor = System.Drawing.SystemColors.Info;
            this.lblparam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblparam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblparam.Location = new System.Drawing.Point(46, 97);
            this.lblparam.Name = "lblparam";
            this.lblparam.Size = new System.Drawing.Size(2, 15);
            this.lblparam.TabIndex = 3;
            this.lblparam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(187, 97);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(100, 20);
            this.txtval1.TabIndex = 4;
            this.txtval1.Visible = false;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(187, 144);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(100, 20);
            this.txtval2.TabIndex = 5;
            this.txtval2.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Location = new System.Drawing.Point(152, 263);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResult.Visible = false;
            // 
            // lblResInfo
            // 
            this.lblResInfo.AutoSize = true;
            this.lblResInfo.Location = new System.Drawing.Point(79, 263);
            this.lblResInfo.Name = "lblResInfo";
            this.lblResInfo.Size = new System.Drawing.Size(35, 13);
            this.lblResInfo.TabIndex = 7;
            this.lblResInfo.Text = "label1";
            this.lblResInfo.Visible = false;
            // 
            // gpTipoOper
            // 
            this.gpTipoOper.Controls.Add(this.rdOpc2);
            this.gpTipoOper.Controls.Add(this.rdOpc1);
            this.gpTipoOper.Location = new System.Drawing.Point(29, 127);
            this.gpTipoOper.Name = "gpTipoOper";
            this.gpTipoOper.Size = new System.Drawing.Size(125, 66);
            this.gpTipoOper.TabIndex = 8;
            this.gpTipoOper.TabStop = false;
            this.gpTipoOper.Text = "Tipo de Operacion";
            this.gpTipoOper.Visible = false;
            // 
            // rdOpc1
            // 
            this.rdOpc1.AutoSize = true;
            this.rdOpc1.Location = new System.Drawing.Point(17, 20);
            this.rdOpc1.Name = "rdOpc1";
            this.rdOpc1.Size = new System.Drawing.Size(72, 17);
            this.rdOpc1.TabIndex = 0;
            this.rdOpc1.TabStop = true;
            this.rdOpc1.Text = "Por Radio";
            this.rdOpc1.UseVisualStyleBackColor = true;
            this.rdOpc1.CheckedChanged += new System.EventHandler(this.rdOpc1_CheckedChanged);
            // 
            // rdOpc2
            // 
            this.rdOpc2.AutoSize = true;
            this.rdOpc2.Location = new System.Drawing.Point(17, 43);
            this.rdOpc2.Name = "rdOpc2";
            this.rdOpc2.Size = new System.Drawing.Size(86, 17);
            this.rdOpc2.TabIndex = 1;
            this.rdOpc2.TabStop = true;
            this.rdOpc2.Text = "Por Diametro";
            this.rdOpc2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 343);
            this.Controls.Add(this.gpTipoOper);
            this.Controls.Add(this.lblResInfo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.lblparam);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.lblselec);
            this.Controls.Add(this.cmbOper);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones";
            this.gpTipoOper.ResumeLayout(false);
            this.gpTipoOper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOper;
        private System.Windows.Forms.Label lblselec;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Label lblparam;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResInfo;
        private System.Windows.Forms.GroupBox gpTipoOper;
        private System.Windows.Forms.RadioButton rdOpc2;
        private System.Windows.Forms.RadioButton rdOpc1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

