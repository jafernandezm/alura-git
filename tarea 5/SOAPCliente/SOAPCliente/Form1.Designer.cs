
namespace SOAPCliente
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
            this.txtbNum = new System.Windows.Forms.TextBox();
            this.cboxOperaciones = new System.Windows.Forms.ComboBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNum
            // 
            this.txtbNum.Location = new System.Drawing.Point(221, 71);
            this.txtbNum.Name = "txtbNum";
            this.txtbNum.Size = new System.Drawing.Size(100, 20);
            this.txtbNum.TabIndex = 1;
            // 
            // cboxOperaciones
            // 
            this.cboxOperaciones.FormattingEnabled = true;
            this.cboxOperaciones.Items.AddRange(new object[] {
            "SUMATORIA",
            "FACTORIAL",
            "FIBONACCI"});
            this.cboxOperaciones.Location = new System.Drawing.Point(221, 128);
            this.cboxOperaciones.Name = "cboxOperaciones";
            this.cboxOperaciones.Size = new System.Drawing.Size(121, 21);
            this.cboxOperaciones.TabIndex = 4;
            // 
            // btCalcular
            // 
            this.btCalcular.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btCalcular.Location = new System.Drawing.Point(234, 182);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operaciones";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(95, 74);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(91, 13);
            this.lbNum.TabIndex = 7;
            this.lbNum.Text = "Escriba el numero";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(248, 240);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(61, 13);
            this.lbResultado.TabIndex = 8;
            this.lbResultado.Text = "Resultado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Operaciones Sumatoria factorial fibonacci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.cboxOperaciones);
            this.Controls.Add(this.txtbNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbNum;
        private System.Windows.Forms.ComboBox cboxOperaciones;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label1;
    }
}

