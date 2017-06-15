namespace Auditoria
{
    partial class PlanificacionCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanificacionCuestionario));
            this.label3 = new System.Windows.Forms.Label();
            this.planificacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Planificación";
            // 
            // planificacion
            // 
            this.planificacion.Image = ((System.Drawing.Image)(resources.GetObject("planificacion.Image")));
            this.planificacion.Location = new System.Drawing.Point(12, 12);
            this.planificacion.Name = "planificacion";
            this.planificacion.Size = new System.Drawing.Size(127, 115);
            this.planificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planificacion.TabIndex = 15;
            this.planificacion.TabStop = false;
            // 
            // PlanificacionCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.planificacion);
            this.Name = "PlanificacionCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanificacionCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlanificacionCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.planificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox planificacion;
    }
}