
namespace Act1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lApellido = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lEdad = new System.Windows.Forms.Label();
            this.lDirec = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.lResul = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(12, 44);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(60, 15);
            this.lApellido.TabIndex = 0;
            this.lApellido.Text = "APELLIDO";
            this.lApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApe
            // 
            this.txtApe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApe.Location = new System.Drawing.Point(78, 41);
            this.txtApe.MaxLength = 100;
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(292, 23);
            this.txtApe.TabIndex = 1;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(12, 81);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(56, 15);
            this.lNom.TabIndex = 2;
            this.lNom.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(78, 78);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(78, 115);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(42, 23);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(12, 118);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(37, 15);
            this.lEdad.TabIndex = 5;
            this.lEdad.Text = "EDAD";
            // 
            // lDirec
            // 
            this.lDirec.AutoSize = true;
            this.lDirec.Location = new System.Drawing.Point(12, 154);
            this.lDirec.Name = "lDirec";
            this.lDirec.Size = new System.Drawing.Size(68, 15);
            this.lDirec.TabIndex = 6;
            this.lDirec.Text = "DIRECCION";
            // 
            // txtDirec
            // 
            this.txtDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirec.Location = new System.Drawing.Point(78, 151);
            this.txtDirec.MaxLength = 200;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(292, 23);
            this.txtDirec.TabIndex = 7;
            // 
            // lResul
            // 
            this.lResul.AutoSize = true;
            this.lResul.Location = new System.Drawing.Point(13, 220);
            this.lResul.Name = "lResul";
            this.lResul.Size = new System.Drawing.Size(69, 15);
            this.lResul.TabIndex = 8;
            this.lResul.Text = "RESULTADO";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 239);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(358, 77);
            this.txtRes.TabIndex = 9;
            // 
            // aceptar
            // 
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aceptar.Location = new System.Drawing.Point(78, 323);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelar.Location = new System.Drawing.Point(206, 323);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 377);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.lResul);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.lDirec);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.lApellido);
            this.Name = "Form1";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.Label lDirec;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label lResul;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}

