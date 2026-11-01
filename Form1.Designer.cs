namespace UcmayanTeyyare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKalkis = new System.Windows.Forms.Button();
            this.btnInis = new System.Windows.Forms.Button();
            this.btnSola = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnArxa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnKalkis);
            this.groupBox1.Controls.Add(this.btnInis);
            this.groupBox1.Controls.Add(this.btnSola);
            this.groupBox1.Controls.Add(this.btnSag);
            this.groupBox1.Controls.Add(this.btnOn);
            this.groupBox1.Controls.Add(this.btnArxa);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teyyare";
            //
            // btnKalkis
            //
            this.btnKalkis.Location = new System.Drawing.Point(20, 40);
            this.btnKalkis.Name = "btnKalkis";
            this.btnKalkis.Size = new System.Drawing.Size(150, 45);
            this.btnKalkis.TabIndex = 0;
            this.btnKalkis.Text = "Kalkış";
            this.btnKalkis.UseVisualStyleBackColor = true;
            this.btnKalkis.Click += new System.EventHandler(this.btnKalkis_Click);
            //
            // btnInis
            //
            this.btnInis.Location = new System.Drawing.Point(185, 40);
            this.btnInis.Name = "btnInis";
            this.btnInis.Size = new System.Drawing.Size(150, 45);
            this.btnInis.TabIndex = 1;
            this.btnInis.Text = "İniş";
            this.btnInis.UseVisualStyleBackColor = true;
            this.btnInis.Click += new System.EventHandler(this.btnInis_Click);
            //
            // btnSola
            //
            this.btnSola.Location = new System.Drawing.Point(20, 100);
            this.btnSola.Name = "btnSola";
            this.btnSola.Size = new System.Drawing.Size(150, 45);
            this.btnSola.TabIndex = 2;
            this.btnSola.Text = "Sola";
            this.btnSola.UseVisualStyleBackColor = true;
            this.btnSola.Click += new System.EventHandler(this.btnSola_Click);
            //
            // btnSag
            //
            this.btnSag.Location = new System.Drawing.Point(185, 100);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(150, 45);
            this.btnSag.TabIndex = 3;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            //
            // btnOn
            //
            this.btnOn.Location = new System.Drawing.Point(20, 160);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(150, 45);
            this.btnOn.TabIndex = 4;
            this.btnOn.Text = "Ön";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            //
            // btnArxa
            //
            this.btnArxa.Location = new System.Drawing.Point(185, 160);
            this.btnArxa.Name = "btnArxa";
            this.btnArxa.Size = new System.Drawing.Size(150, 45);
            this.btnArxa.TabIndex = 5;
            this.btnArxa.Text = "Arxa";
            this.btnArxa.UseVisualStyleBackColor = true;
            this.btnArxa.Click += new System.EventHandler(this.btnArxa_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ucmayan-teyyare";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKalkis;
        private System.Windows.Forms.Button btnInis;
        private System.Windows.Forms.Button btnSola;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnArxa;
    }
}
