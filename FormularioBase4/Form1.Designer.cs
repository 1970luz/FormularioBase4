namespace FormularioBase4
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
            this.buttonSaludo = new System.Windows.Forms.Button();
            this.buttoncargo = new System.Windows.Forms.Button();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.buttonPaterno = new System.Windows.Forms.Button();
            this.buttonMaterno = new System.Windows.Forms.Button();
            this.labelsaludo = new System.Windows.Forms.Label();
            this.labelcargo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPaterno = new System.Windows.Forms.Label();
            this.labelMaterno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaludo
            // 
            this.buttonSaludo.Location = new System.Drawing.Point(25, 238);
            this.buttonSaludo.Name = "buttonSaludo";
            this.buttonSaludo.Size = new System.Drawing.Size(67, 23);
            this.buttonSaludo.TabIndex = 0;
            this.buttonSaludo.Text = " saludo";
            this.buttonSaludo.UseVisualStyleBackColor = true;
            this.buttonSaludo.Click += new System.EventHandler(this.buttonSaludo_Click);
            // 
            // buttoncargo
            // 
            this.buttoncargo.Location = new System.Drawing.Point(144, 240);
            this.buttoncargo.Name = "buttoncargo";
            this.buttoncargo.Size = new System.Drawing.Size(73, 20);
            this.buttoncargo.TabIndex = 1;
            this.buttoncargo.Text = "cargo";
            this.buttoncargo.UseVisualStyleBackColor = true;
            this.buttoncargo.Click += new System.EventHandler(this.buttoncargo_Click);
            // 
            // buttonNombre
            // 
            this.buttonNombre.Location = new System.Drawing.Point(253, 240);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(64, 20);
            this.buttonNombre.TabIndex = 2;
            this.buttonNombre.Text = "nombre";
            this.buttonNombre.UseVisualStyleBackColor = true;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // buttonPaterno
            // 
            this.buttonPaterno.Location = new System.Drawing.Point(339, 240);
            this.buttonPaterno.Name = "buttonPaterno";
            this.buttonPaterno.Size = new System.Drawing.Size(65, 19);
            this.buttonPaterno.TabIndex = 3;
            this.buttonPaterno.Text = "paterno";
            this.buttonPaterno.UseVisualStyleBackColor = true;
            this.buttonPaterno.Click += new System.EventHandler(this.buttonPaterno_Click);
            // 
            // buttonMaterno
            // 
            this.buttonMaterno.Location = new System.Drawing.Point(456, 241);
            this.buttonMaterno.Name = "buttonMaterno";
            this.buttonMaterno.Size = new System.Drawing.Size(65, 20);
            this.buttonMaterno.TabIndex = 4;
            this.buttonMaterno.Text = "materno";
            this.buttonMaterno.UseVisualStyleBackColor = true;
            this.buttonMaterno.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelsaludo
            // 
            this.labelsaludo.AutoSize = true;
            this.labelsaludo.Location = new System.Drawing.Point(34, 45);
            this.labelsaludo.Name = "labelsaludo";
            this.labelsaludo.Size = new System.Drawing.Size(38, 13);
            this.labelsaludo.TabIndex = 5;
            this.labelsaludo.Text = "saludo";
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Location = new System.Drawing.Point(127, 45);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(34, 13);
            this.labelcargo.TabIndex = 6;
            this.labelcargo.Text = "cargo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(250, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(42, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "nombre";
            // 
            // labelPaterno
            // 
            this.labelPaterno.AutoSize = true;
            this.labelPaterno.Location = new System.Drawing.Point(358, 45);
            this.labelPaterno.Name = "labelPaterno";
            this.labelPaterno.Size = new System.Drawing.Size(43, 13);
            this.labelPaterno.TabIndex = 8;
            this.labelPaterno.Text = "paterno";
            // 
            // labelMaterno
            // 
            this.labelMaterno.AutoSize = true;
            this.labelMaterno.Location = new System.Drawing.Point(462, 45);
            this.labelMaterno.Name = "labelMaterno";
            this.labelMaterno.Size = new System.Drawing.Size(45, 13);
            this.labelMaterno.TabIndex = 9;
            this.labelMaterno.Text = "materno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.labelMaterno);
            this.Controls.Add(this.labelPaterno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelcargo);
            this.Controls.Add(this.labelsaludo);
            this.Controls.Add(this.buttonMaterno);
            this.Controls.Add(this.buttonPaterno);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.buttoncargo);
            this.Controls.Add(this.buttonSaludo);
            this.Name = "Form1";
            this.Text = "luci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludo;
        private System.Windows.Forms.Button buttoncargo;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.Button buttonPaterno;
        private System.Windows.Forms.Button buttonMaterno;
        private System.Windows.Forms.Label labelsaludo;
        private System.Windows.Forms.Label labelcargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPaterno;
        private System.Windows.Forms.Label labelMaterno;
    }
}

