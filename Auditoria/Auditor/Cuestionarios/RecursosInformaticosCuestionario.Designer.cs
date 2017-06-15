namespace Auditoria.Auditor.Cuestionarios
{
    partial class RecursosInformaticosCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosInformaticosCuestionario));
            this.label7 = new System.Windows.Forms.Label();
            this.recursosInformaticos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recursosInformaticos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Recursos Informáticos";
            // 
            // recursosInformaticos
            // 
            this.recursosInformaticos.Image = ((System.Drawing.Image)(resources.GetObject("recursosInformaticos.Image")));
            this.recursosInformaticos.Location = new System.Drawing.Point(48, 30);
            this.recursosInformaticos.Name = "recursosInformaticos";
            this.recursosInformaticos.Size = new System.Drawing.Size(127, 115);
            this.recursosInformaticos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recursosInformaticos.TabIndex = 19;
            this.recursosInformaticos.TabStop = false;
            // 
            // RecursosInformaticosCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 233);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recursosInformaticos);
            this.Name = "RecursosInformaticosCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecursosInformaticosCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecursosInformaticosCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.recursosInformaticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox recursosInformaticos;
    }
}