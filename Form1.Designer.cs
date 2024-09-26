namespace WebCrawler_JUSBrasil
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ListBox lstResultados;

        /// limpa os recursos que estão sendo usados.
        /// <param name="disposing">true se os recursos gerenciados for descartado; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Formulários Windows

        /// método necessário para suporte ao designer - não modifique
        /// o conteúdo deste método com o editor de código.
        private void InitializeComponent()
        {
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(13, 13);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(200, 20);
            this.txtCpf.TabIndex = 0;

            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(220, 10);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(13, 40);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(282, 199);
            this.lstResultados.TabIndex = 2;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtCpf);
            this.Name = "Form1";
            this.Text = "Consulta de Processos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}