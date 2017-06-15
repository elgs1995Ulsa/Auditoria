namespace Auditoria.Auditor
{
    partial class RelacionesLaboralesCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelacionesLaboralesCuestionario));
            this.label6 = new System.Windows.Forms.Label();
            this.relacionesLaborales = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.relacionesLaborales)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Relaciones Laborales";
            // 
            // relacionesLaborales
            // 
            this.relacionesLaborales.Image = ((System.Drawing.Image)(resources.GetObject("relacionesLaborales.Image")));
            this.relacionesLaborales.Location = new System.Drawing.Point(71, 51);
            this.relacionesLaborales.Name = "relacionesLaborales";
            this.relacionesLaborales.Size = new System.Drawing.Size(157, 115);
            this.relacionesLaborales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.relacionesLaborales.TabIndex = 18;
            this.relacionesLaborales.TabStop = false;
            // 
            // RelacionesLaboralesCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.relacionesLaborales);
            this.Name = "RelacionesLaboralesCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelacionesLaboralesCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RelacionesLaboralesCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.relacionesLaborales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox relacionesLaborales;
    }
}