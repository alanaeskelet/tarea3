namespace tarea3
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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfahrenhaitacelsius = new System.Windows.Forms.Button();
            this.btncelsiusafahrenhait = new System.Windows.Forms.Button();
            this.txtgradosgahrenhait = new System.Windows.Forms.TextBox();
            this.txtgradoscelsius = new System.Windows.Forms.TextBox();
            this.txtconvertidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Pink;
            this.btnlimpiar.Location = new System.Drawing.Point(382, 281);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 0;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfahrenhaitacelsius
            // 
            this.btnfahrenhaitacelsius.BackColor = System.Drawing.Color.Pink;
            this.btnfahrenhaitacelsius.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfahrenhaitacelsius.Location = new System.Drawing.Point(595, 221);
            this.btnfahrenhaitacelsius.Name = "btnfahrenhaitacelsius";
            this.btnfahrenhaitacelsius.Size = new System.Drawing.Size(139, 83);
            this.btnfahrenhaitacelsius.TabIndex = 1;
            this.btnfahrenhaitacelsius.Text = "fahrenhait a celsius";
            this.btnfahrenhaitacelsius.UseVisualStyleBackColor = false;
            this.btnfahrenhaitacelsius.Click += new System.EventHandler(this.btnfahrenhaitacelsius_Click);
            // 
            // btncelsiusafahrenhait
            // 
            this.btncelsiusafahrenhait.BackColor = System.Drawing.Color.Pink;
            this.btncelsiusafahrenhait.ForeColor = System.Drawing.Color.Green;
            this.btncelsiusafahrenhait.Location = new System.Drawing.Point(59, 209);
            this.btncelsiusafahrenhait.Name = "btncelsiusafahrenhait";
            this.btncelsiusafahrenhait.Size = new System.Drawing.Size(158, 95);
            this.btncelsiusafahrenhait.TabIndex = 2;
            this.btncelsiusafahrenhait.Text = "celsius a fahrenhait";
            this.btncelsiusafahrenhait.UseVisualStyleBackColor = false;
            this.btncelsiusafahrenhait.Click += new System.EventHandler(this.btncelsiusafahrenhait_Click);
            // 
            // txtgradosgahrenhait
            // 
            this.txtgradosgahrenhait.BackColor = System.Drawing.Color.Red;
            this.txtgradosgahrenhait.Location = new System.Drawing.Point(611, 86);
            this.txtgradosgahrenhait.Name = "txtgradosgahrenhait";
            this.txtgradosgahrenhait.Size = new System.Drawing.Size(123, 22);
            this.txtgradosgahrenhait.TabIndex = 3;
            this.txtgradosgahrenhait.Text = "grados fahrenhait";
            this.txtgradosgahrenhait.TextChanged += new System.EventHandler(this.txtgradosgahrenhait_TextChanged);
            // 
            // txtgradoscelsius
            // 
            this.txtgradoscelsius.BackColor = System.Drawing.Color.Blue;
            this.txtgradoscelsius.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgradoscelsius.Location = new System.Drawing.Point(90, 86);
            this.txtgradoscelsius.Name = "txtgradoscelsius";
            this.txtgradoscelsius.Size = new System.Drawing.Size(100, 25);
            this.txtgradoscelsius.TabIndex = 4;
            this.txtgradoscelsius.Text = "grados celsius";
            // 
            // txtconvertidor
            // 
            this.txtconvertidor.BackColor = System.Drawing.Color.Green;
            this.txtconvertidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconvertidor.Location = new System.Drawing.Point(241, 23);
            this.txtconvertidor.Name = "txtconvertidor";
            this.txtconvertidor.Size = new System.Drawing.Size(331, 41);
            this.txtconvertidor.TabIndex = 5;
            this.txtconvertidor.Text = "convertidor de grados";
            this.txtconvertidor.TextChanged += new System.EventHandler(this.txtconvertidor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::tarea3.Properties.Resources.bros_clasico_juego_mario_wallpaper_preview1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtconvertidor);
            this.Controls.Add(this.txtgradoscelsius);
            this.Controls.Add(this.txtgradosgahrenhait);
            this.Controls.Add(this.btncelsiusafahrenhait);
            this.Controls.Add(this.btnfahrenhaitacelsius);
            this.Controls.Add(this.btnlimpiar);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnfahrenhaitacelsius;
        private System.Windows.Forms.Button btncelsiusafahrenhait;
        private System.Windows.Forms.TextBox txtgradosgahrenhait;
        private System.Windows.Forms.TextBox txtgradoscelsius;
        private System.Windows.Forms.TextBox txtconvertidor;
    }
}

