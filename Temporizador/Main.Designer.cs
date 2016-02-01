namespace Temporizador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.apagarrb = new System.Windows.Forms.RadioButton();
            this.hibernarrb = new System.Windows.Forms.RadioButton();
            this.tiempoup = new System.Windows.Forms.NumericUpDown();
            this.formatocb = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.KEYtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SSIDtb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contador = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoup)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "tiempo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(194, 143);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.apagarrb);
            this.tabPage1.Controls.Add(this.hibernarrb);
            this.tabPage1.Controls.Add(this.tiempoup);
            this.tabPage1.Controls.Add(this.formatocb);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(186, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Temporizador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // apagarrb
            // 
            this.apagarrb.AutoSize = true;
            this.apagarrb.Checked = true;
            this.apagarrb.Location = new System.Drawing.Point(15, 40);
            this.apagarrb.Name = "apagarrb";
            this.apagarrb.Size = new System.Drawing.Size(59, 17);
            this.apagarrb.TabIndex = 7;
            this.apagarrb.TabStop = true;
            this.apagarrb.Text = "Apagar";
            this.apagarrb.UseVisualStyleBackColor = true;
            // 
            // hibernarrb
            // 
            this.hibernarrb.AutoSize = true;
            this.hibernarrb.Location = new System.Drawing.Point(9, 62);
            this.hibernarrb.Name = "hibernarrb";
            this.hibernarrb.Size = new System.Drawing.Size(65, 17);
            this.hibernarrb.TabIndex = 6;
            this.hibernarrb.Text = "Hibernar";
            this.hibernarrb.UseVisualStyleBackColor = true;
            // 
            // tiempoup
            // 
            this.tiempoup.Location = new System.Drawing.Point(53, 14);
            this.tiempoup.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.tiempoup.Name = "tiempoup";
            this.tiempoup.Size = new System.Drawing.Size(45, 20);
            this.tiempoup.TabIndex = 5;
            this.tiempoup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // formatocb
            // 
            this.formatocb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatocb.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.formatocb.Items.AddRange(new object[] {
            "Horas",
            "Minutos",
            "Segundos"});
            this.formatocb.Location = new System.Drawing.Point(104, 13);
            this.formatocb.Name = "formatocb";
            this.formatocb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formatocb.Size = new System.Drawing.Size(74, 21);
            this.formatocb.TabIndex = 2;
            this.formatocb.Text = "Horas";
            this.formatocb.SelectedIndexChanged += new System.EventHandler(this.formatocb_SelectedIndexChanged);
            this.formatocb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatocb_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.KEYtb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.SSIDtb);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(186, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotspot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KEYtb
            // 
            this.KEYtb.Location = new System.Drawing.Point(8, 60);
            this.KEYtb.Name = "KEYtb";
            this.KEYtb.Size = new System.Drawing.Size(100, 20);
            this.KEYtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ":Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ":SSID";
            // 
            // SSIDtb
            // 
            this.SSIDtb.Location = new System.Drawing.Point(8, 20);
            this.SSIDtb.Name = "SSIDtb";
            this.SSIDtb.Size = new System.Drawing.Size(100, 20);
            this.SSIDtb.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Tacos";
            this.notifyIcon1.BalloonTipTitle = "bu c:";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Utilities jarcor";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contador
            // 
            this.contador.Interval = 1000;
            this.contador.Tick += new System.EventHandler(this.contador_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatocb_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 143);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities jarcor";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoup)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox KEYtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SSIDtb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox formatocb;
        private System.Windows.Forms.NumericUpDown tiempoup;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton apagarrb;
        private System.Windows.Forms.RadioButton hibernarrb;
        private System.Windows.Forms.Timer contador;
        private System.Windows.Forms.TextBox textBox1;
    }
}

