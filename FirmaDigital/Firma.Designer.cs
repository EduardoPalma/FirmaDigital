namespace FirmaDigital;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSignature = new System.Windows.Forms.TextBox();
            this.seleccionArchivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boxVerify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hashFirma = new System.Windows.Forms.RichTextBox();
            this.hashVerificacion = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta Archivo a Firmar";
            // 
            // boxSignature
            // 
            this.boxSignature.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boxSignature.Location = new System.Drawing.Point(152, 46);
            this.boxSignature.Name = "boxSignature";
            this.boxSignature.Size = new System.Drawing.Size(451, 23);
            this.boxSignature.TabIndex = 2;
            // 
            // seleccionArchivo
            // 
            this.seleccionArchivo.Image = ((System.Drawing.Image)(resources.GetObject("seleccionArchivo.Image")));
            this.seleccionArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seleccionArchivo.Location = new System.Drawing.Point(609, 46);
            this.seleccionArchivo.Name = "seleccionArchivo";
            this.seleccionArchivo.Size = new System.Drawing.Size(137, 23);
            this.seleccionArchivo.TabIndex = 3;
            this.seleccionArchivo.Text = "Seleccionar archivo";
            this.seleccionArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seleccionArchivo.UseVisualStyleBackColor = true;
            this.seleccionArchivo.Click += new System.EventHandler(this.Seleccionar_Archivo_Firmar);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(286, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Firmar Documento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Firma_Archivo_Click);
            // 
            // boxVerify
            // 
            this.boxVerify.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxVerify.Location = new System.Drawing.Point(152, 254);
            this.boxVerify.Name = "boxVerify";
            this.boxVerify.Size = new System.Drawing.Size(451, 23);
            this.boxVerify.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta Archivo a Verificar";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(609, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Seleccionar Archivo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Seleccionar_Archivo_Verificar);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(286, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Verificar Documento";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Verificar_Archivo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hash de firma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hash de verificacion";
            // 
            // hashFirma
            // 
            this.hashFirma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hashFirma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hashFirma.Location = new System.Drawing.Point(152, 141);
            this.hashFirma.Name = "hashFirma";
            this.hashFirma.Size = new System.Drawing.Size(451, 78);
            this.hashFirma.TabIndex = 14;
            this.hashFirma.Text = "";
            // 
            // hashVerificacion
            // 
            this.hashVerificacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hashVerificacion.Location = new System.Drawing.Point(152, 332);
            this.hashVerificacion.Name = "hashVerificacion";
            this.hashVerificacion.Size = new System.Drawing.Size(457, 68);
            this.hashVerificacion.TabIndex = 15;
            this.hashVerificacion.Text = "";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(637, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 78);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MostrarClavePrivada);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(637, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 76);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MostrarClavePublica);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(779, 427);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.hashVerificacion);
            this.Controls.Add(this.hashFirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxVerify);
            this.Controls.Add(this.boxSignature);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seleccionArchivo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Firma Digital";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private OpenFileDialog openFileDialog1;
    private Label label1;
    private TextBox boxSignature;
    private Button seleccionArchivo;
    private Button button1;
    private TextBox boxVerify;
    private Label label2;
    private Button button2;
    private Button button3;
    private Label label3;
    private Label label4;
    private Label label5;
    private RichTextBox hashFirma;
    private RichTextBox hashVerificacion;
    private Button button4;
    private Button button5;
}