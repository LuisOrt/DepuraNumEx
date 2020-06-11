namespace DepuraNumExt
{
    partial class DepuraNumExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepuraNumExt));
            this.Boton = new System.Windows.Forms.Button();
            this.Etiqueta = new System.Windows.Forms.Label();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(292, 13);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(75, 23);
            this.Boton.TabIndex = 0;
            this.Boton.Text = "Seleccionar";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etiqueta
            // 
            this.Etiqueta.AutoSize = true;
            this.Etiqueta.Location = new System.Drawing.Point(12, 18);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(0, 13);
            this.Etiqueta.TabIndex = 1;
            // 
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(12, 42);
            this.TextArea.Name = "TextArea";
            this.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextArea.Size = new System.Drawing.Size(354, 126);
            this.TextArea.TabIndex = 2;
            this.TextArea.Text = "";
            // 
            // DepuraNumExt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(379, 180);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.Etiqueta);
            this.Controls.Add(this.Boton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepuraNumExt";
            this.Text = "DepuraNumExt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.Label Etiqueta;
        private System.Windows.Forms.RichTextBox TextArea;
    }
}

