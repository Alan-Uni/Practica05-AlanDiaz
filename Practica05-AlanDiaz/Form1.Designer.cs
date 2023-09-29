
namespace Practica05_AlanDiaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Estatura = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Estatura = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.gp_Genero = new System.Windows.Forms.GroupBox();
            this.rbtn_Mujer = new System.Windows.Forms.RadioButton();
            this.rbtn_Hombre = new System.Windows.Forms.RadioButton();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gp_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(56, 32);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre :";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(56, 66);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(73, 17);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos :";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(50, 104);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(72, 17);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Teléfono :";
            // 
            // lbl_Estatura
            // 
            this.lbl_Estatura.AutoSize = true;
            this.lbl_Estatura.Location = new System.Drawing.Point(56, 132);
            this.lbl_Estatura.Name = "lbl_Estatura";
            this.lbl_Estatura.Size = new System.Drawing.Size(69, 17);
            this.lbl_Estatura.TabIndex = 3;
            this.lbl_Estatura.Text = "Estatura :";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(65, 166);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(49, 17);
            this.lbl_Edad.TabIndex = 4;
            this.lbl_Edad.Text = "Edad :";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(201, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(162, 22);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(201, 166);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(162, 22);
            this.txt_Edad.TabIndex = 6;
            // 
            // txt_Estatura
            // 
            this.txt_Estatura.Location = new System.Drawing.Point(201, 132);
            this.txt_Estatura.Name = "txt_Estatura";
            this.txt_Estatura.Size = new System.Drawing.Size(162, 22);
            this.txt_Estatura.TabIndex = 7;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(201, 104);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(162, 22);
            this.txt_Telefono.TabIndex = 8;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(201, 66);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(162, 22);
            this.txt_Apellidos.TabIndex = 9;
            // 
            // gp_Genero
            // 
            this.gp_Genero.Controls.Add(this.rbtn_Mujer);
            this.gp_Genero.Controls.Add(this.rbtn_Hombre);
            this.gp_Genero.Location = new System.Drawing.Point(84, 227);
            this.gp_Genero.Name = "gp_Genero";
            this.gp_Genero.Size = new System.Drawing.Size(267, 72);
            this.gp_Genero.TabIndex = 10;
            this.gp_Genero.TabStop = false;
            this.gp_Genero.Text = "Genero";
            // 
            // rbtn_Mujer
            // 
            this.rbtn_Mujer.AutoSize = true;
            this.rbtn_Mujer.Location = new System.Drawing.Point(157, 34);
            this.rbtn_Mujer.Name = "rbtn_Mujer";
            this.rbtn_Mujer.Size = new System.Drawing.Size(64, 21);
            this.rbtn_Mujer.TabIndex = 1;
            this.rbtn_Mujer.TabStop = true;
            this.rbtn_Mujer.Text = "Mujer";
            this.rbtn_Mujer.UseVisualStyleBackColor = true;
            // 
            // rbtn_Hombre
            // 
            this.rbtn_Hombre.AutoSize = true;
            this.rbtn_Hombre.Location = new System.Drawing.Point(30, 38);
            this.rbtn_Hombre.Name = "rbtn_Hombre";
            this.rbtn_Hombre.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Hombre.TabIndex = 0;
            this.rbtn_Hombre.TabStop = true;
            this.rbtn_Hombre.Text = "Hombre";
            this.rbtn_Hombre.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(101, 338);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(237, 69);
            this.btn_Guardar.TabIndex = 11;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(101, 442);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(237, 69);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 546);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.gp_Genero);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Estatura);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Estatura);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gp_Genero.ResumeLayout(false);
            this.gp_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Estatura;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Estatura;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.GroupBox gp_Genero;
        private System.Windows.Forms.RadioButton rbtn_Mujer;
        private System.Windows.Forms.RadioButton rbtn_Hombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

