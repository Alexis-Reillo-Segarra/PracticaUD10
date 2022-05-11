
namespace Practica
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TNum1 = new System.Windows.Forms.TextBox();
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.BDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "/";
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(189, 111);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(189, 20);
            this.TNum1.TabIndex = 1;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(408, 111);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(189, 20);
            this.TNum2.TabIndex = 2;
            // 
            // BDividir
            // 
            this.BDividir.Location = new System.Drawing.Point(325, 174);
            this.BDividir.Name = "BDividir";
            this.BDividir.Size = new System.Drawing.Size(151, 100);
            this.BDividir.TabIndex = 4;
            this.BDividir.Text = "Dividir";
            this.BDividir.UseVisualStyleBackColor = true;
            this.BDividir.Click += new System.EventHandler(this.BDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BDividir);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Button BDividir;
    }
}

