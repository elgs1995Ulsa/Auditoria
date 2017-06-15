namespace Auditoria
{
    partial class ReclutamientoCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReclutamientoCuestionario));
            this.label4 = new System.Windows.Forms.Label();
            this.reclutamiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reclutamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reclutamiento";
            // 
            // reclutamiento
            // 
            this.reclutamiento.Image = ((System.Drawing.Image)(resources.GetObject("reclutamiento.Image")));
            this.reclutamiento.Location = new System.Drawing.Point(43, 24);
            this.reclutamiento.Name = "reclutamiento";
            this.reclutamiento.Size = new System.Drawing.Size(169, 115);
            this.reclutamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reclutamiento.TabIndex = 16;
            this.reclutamiento.TabStop = false;
            // 
            // ReclutamientoCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reclutamiento);
            this.Name = "ReclutamientoCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReclutamientoCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReclutamientoCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.reclutamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox reclutamiento;
    }
}