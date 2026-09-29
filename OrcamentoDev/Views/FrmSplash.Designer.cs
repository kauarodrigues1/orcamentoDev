namespace OrcamentoDev.Views
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            lblTituloSplash = new Label();
            prgCarregando = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTituloSplash
            // 
            lblTituloSplash.AutoSize = true;
            lblTituloSplash.Font = new Font("Segoe UI", 30F);
            lblTituloSplash.Location = new Point(249, 78);
            lblTituloSplash.Name = "lblTituloSplash";
            lblTituloSplash.Size = new Size(441, 54);
            lblTituloSplash.TabIndex = 0;
            lblTituloSplash.Text = "Sistema de Orçamentos";
            // 
            // prgCarregando
            // 
            prgCarregando.Location = new Point(12, 245);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(837, 34);
            prgCarregando.Style = ProgressBarStyle.Marquee;
            prgCarregando.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 150);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Carregando Modulos";
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(944, 291);
            Controls.Add(label1);
            Controls.Add(prgCarregando);
            Controls.Add(lblTituloSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            Text = "Splash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloSplash;
        private ProgressBar prgCarregando;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}