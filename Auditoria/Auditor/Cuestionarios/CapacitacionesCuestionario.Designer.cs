namespace Auditoria.Auditor
{
    partial class CapacitacionesCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapacitacionesCuestionario));
            this.label5 = new System.Windows.Forms.Label();
            this.formacionDesarrollo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.formacionDesarrollo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Formación y Desarrollo";
            // 
            // formacionDesarrollo
            // 
            this.formacionDesarrollo.Image = ((System.Drawing.Image)(resources.GetObject("formacionDesarrollo.Image")));
            this.formacionDesarrollo.Location = new System.Drawing.Point(38, 12);
            this.formacionDesarrollo.Name = "formacionDesarrollo";
            this.formacionDesarrollo.Size = new System.Drawing.Size(134, 115);
            this.formacionDesarrollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formacionDesarrollo.TabIndex = 17;
            this.formacionDesarrollo.TabStop = false;
            // 
            // CapacitacionesCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formacionDesarrollo);
            this.Name = "CapacitacionesCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapacitacionesCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CapacitacionesCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.formacionDesarrollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox formacionDesarrollo;
    }
}