using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppSueldos
{ 
    public partial class Inicio : Form
    {


    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
        {
            this.btiniciarsesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnombreusuario = new System.Windows.Forms.TextBox();
            this.tbcontrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizarApp = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btiniciarsesion
            // 
            this.btiniciarsesion.Location = new System.Drawing.Point(786, 408);
            this.btiniciarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.btiniciarsesion.Name = "btiniciarsesion";
            this.btiniciarsesion.Size = new System.Drawing.Size(167, 52);
            this.btiniciarsesion.TabIndex = 0;
            this.btiniciarsesion.Text = "Iniciar Sesion";
            this.btiniciarsesion.UseVisualStyleBackColor = true;
            this.btiniciarsesion.Click += new System.EventHandler(this.btiniciarsesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autenticacion";
            // 
            // tbnombreusuario
            // 
            this.tbnombreusuario.Location = new System.Drawing.Point(731, 297);
            this.tbnombreusuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbnombreusuario.Name = "tbnombreusuario";
            this.tbnombreusuario.Size = new System.Drawing.Size(273, 22);
            this.tbnombreusuario.TabIndex = 3;
            // 
            // tbcontrasena
            // 
            this.tbcontrasena.Location = new System.Drawing.Point(731, 360);
            this.tbcontrasena.Margin = new System.Windows.Forms.Padding(4);
            this.tbcontrasena.Name = "tbcontrasena";
            this.tbcontrasena.Size = new System.Drawing.Size(273, 22);
            this.tbcontrasena.TabIndex = 4;
            this.tbcontrasena.TextChanged += new System.EventHandler(this.tbcontrasena_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "App Sueldos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AppSueldos.Properties.Resources.hoja_de_calculo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(811, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 108);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizarApp
            // 
            this.btnMinimizarApp.BackgroundImage = global::AppSueldos.Properties.Resources.descargar;
            this.btnMinimizarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarApp.Location = new System.Drawing.Point(994, 12);
            this.btnMinimizarApp.Name = "btnMinimizarApp";
            this.btnMinimizarApp.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizarApp.TabIndex = 9;
            this.btnMinimizarApp.TabStop = false;
            this.btnMinimizarApp.Click += new System.EventHandler(this.btnMinimizarApp_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.BackgroundImage = global::AppSueldos.Properties.Resources.cerrar;
            this.btnCerrarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarApp.Location = new System.Drawing.Point(1024, 12);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(24, 25);
            this.btnCerrarApp.TabIndex = 8;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppSueldos.Properties.Resources.documentacion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-117, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 497);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1060, 482);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMinimizarApp);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcontrasena);
            this.Controls.Add(this.tbnombreusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btiniciarsesion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Sueldos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btiniciarsesion;

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbnombreusuario;
        private TextBox tbcontrasena;
        private PictureBox pictureBox1;
        private PictureBox btnCerrarApp;
        private PictureBox btnMinimizarApp;
        private Label label4;
        private PictureBox pictureBox2;
    }
}


