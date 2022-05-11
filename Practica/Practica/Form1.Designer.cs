
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
            this.TBNum1 = new System.Windows.Forms.TextBox();
            this.TBNum2 = new System.Windows.Forms.TextBox();
            this.BMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // TBNum1
            // 
            this.TBNum1.Location = new System.Drawing.Point(237, 174);
            this.TBNum1.Name = "TBNum1";
            this.TBNum1.Size = new System.Drawing.Size(100, 20);
            this.TBNum1.TabIndex = 1;
            // 
            // TBNum2
            // 
            this.TBNum2.Location = new System.Drawing.Point(423, 174);
            this.TBNum2.Name = "TBNum2";
            this.TBNum2.Size = new System.Drawing.Size(100, 20);
            this.TBNum2.TabIndex = 2;
            // 
            // BMultiplicar
            // 
            this.BMultiplicar.Location = new System.Drawing.Point(237, 235);
            this.BMultiplicar.Name = "BMultiplicar";
            this.BMultiplicar.Size = new System.Drawing.Size(286, 51);
            this.BMultiplicar.TabIndex = 3;
            this.BMultiplicar.Text = "Multiplicar números";
            this.BMultiplicar.UseVisualStyleBackColor = true;
            this.BMultiplicar.Click += new System.EventHandler(this.BMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMultiplicar);
            this.Controls.Add(this.TBNum2);
            this.Controls.Add(this.TBNum1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNum1;
        private System.Windows.Forms.TextBox TBNum2;
        private System.Windows.Forms.Button BMultiplicar;
    }
}

