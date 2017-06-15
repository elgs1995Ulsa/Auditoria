namespace Auditoria
{
    partial class CaracterGeneralCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaracterGeneralCuestionario));
            this.label2 = new System.Windows.Forms.Label();
            this.caracterGeneral = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.caracterGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Caracter General";
            // 
            // caracterGeneral
            // 
            this.caracterGeneral.Image = ((System.Drawing.Image)(resources.GetObject("caracterGeneral.Image")));
            this.caracterGeneral.Location = new System.Drawing.Point(12, 12);
            this.caracterGeneral.Name = "caracterGeneral";
            this.caracterGeneral.Size = new System.Drawing.Size(142, 115);
            this.caracterGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caracterGeneral.TabIndex = 14;
            this.caracterGeneral.TabStop = false;
            // 
            // CaracterGeneralCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caracterGeneral);
            this.Name = "CaracterGeneralCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaracterGeneralCuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaracterGeneralCuestionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.caracterGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox caracterGeneral;
    }
}