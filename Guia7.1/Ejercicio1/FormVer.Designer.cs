namespace Ejercicio1
{
    partial class FormVer
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
            tbVer = new TextBox();
            Cerrar = new Button();
            SuspendLayout();
            // 
            // tbVer
            // 
            tbVer.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 177);
            tbVer.Location = new Point(13, 14);
            tbVer.Margin = new Padding(4, 5, 4, 5);
            tbVer.Multiline = true;
            tbVer.Name = "tbVer";
            tbVer.ScrollBars = ScrollBars.Both;
            tbVer.Size = new Size(610, 455);
            tbVer.TabIndex = 0;
            // 
            // Cerrar
            // 
            Cerrar.DialogResult = DialogResult.OK;
            Cerrar.Location = new Point(252, 479);
            Cerrar.Margin = new Padding(4, 5, 4, 5);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(112, 35);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 517);
            Controls.Add(Cerrar);
            Controls.Add(tbVer);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormVer";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cerrar;
        public System.Windows.Forms.TextBox tbVer;
    }
}