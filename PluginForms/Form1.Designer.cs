namespace PluginForms
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Param1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.textBoxParametro1 = new System.Windows.Forms.TextBox();
            this.textBoxParametro2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aarchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPlugInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 77);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Parametro2";
            this.Label1.Click += new System.EventHandler(this.Param2_Click);
            // 
            // Param1
            // 
            this.Param1.AutoSize = true;
            this.Param1.Location = new System.Drawing.Point(12, 38);
            this.Param1.Name = "Param1";
            this.Param1.Size = new System.Drawing.Size(61, 13);
            this.Param1.TabIndex = 1;
            this.Param1.Text = "Parametro1";
            this.Param1.Click += new System.EventHandler(this.Param1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 117);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(58, 13);
            this.Result.TabIndex = 2;
            this.Result.Text = "Resultado:";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(12, 154);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(25, 13);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(105, 117);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(39, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Label3";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(105, 154);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(39, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Label4";
            // 
            // textBoxParametro1
            // 
            this.textBoxParametro1.Location = new System.Drawing.Point(97, 38);
            this.textBoxParametro1.Name = "textBoxParametro1";
            this.textBoxParametro1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParametro1.TabIndex = 6;
            this.textBoxParametro1.Text = "5";
            this.textBoxParametro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParametro2
            // 
            this.textBoxParametro2.Location = new System.Drawing.Point(97, 74);
            this.textBoxParametro2.Name = "textBoxParametro2";
            this.textBoxParametro2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParametro2.TabIndex = 7;
            this.textBoxParametro2.Text = "3";
            this.textBoxParametro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aarchivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aarchivoToolStripMenuItem
            // 
            this.aarchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPlugInToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.aarchivoToolStripMenuItem.Name = "aarchivoToolStripMenuItem";
            this.aarchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aarchivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarPlugInToolStripMenuItem
            // 
            this.cargarPlugInToolStripMenuItem.Name = "cargarPlugInToolStripMenuItem";
            this.cargarPlugInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarPlugInToolStripMenuItem.Text = "Cargar Plug In";
            this.cargarPlugInToolStripMenuItem.Click += new System.EventHandler(this.cargarPlugInToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 210);
            this.Controls.Add(this.textBoxParametro2);
            this.Controls.Add(this.textBoxParametro1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Param1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Param1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox textBoxParametro1;
        private System.Windows.Forms.TextBox textBoxParametro2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aarchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPlugInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

