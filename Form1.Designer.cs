namespace PictureView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lopic = new System.Windows.Forms.Button();
            this.bacolor = new System.Windows.Forms.Button();
            this.rotbut = new System.Windows.Forms.Button();
            this.picolor = new System.Windows.Forms.Button();
            this.picsize = new System.Windows.Forms.Button();
            this.chBk = new System.Windows.Forms.CheckBox();
            this.openFileDiaPict = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.picBox1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // picBox1
            // 
            resources.ApplyResources(this.picBox1, "picBox1");
            this.picBox1.Name = "picBox1";
            this.picBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lopic);
            this.flowLayoutPanel1.Controls.Add(this.bacolor);
            this.flowLayoutPanel1.Controls.Add(this.rotbut);
            this.flowLayoutPanel1.Controls.Add(this.picolor);
            this.flowLayoutPanel1.Controls.Add(this.picsize);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.chBk);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // lopic
            // 
            resources.ApplyResources(this.lopic, "lopic");
            this.lopic.Name = "lopic";
            this.lopic.UseVisualStyleBackColor = true;
            this.lopic.Click += new System.EventHandler(this.lopic_Click);
            // 
            // bacolor
            // 
            resources.ApplyResources(this.bacolor, "bacolor");
            this.bacolor.Name = "bacolor";
            this.bacolor.UseVisualStyleBackColor = true;
            this.bacolor.Click += new System.EventHandler(this.bacolor_Click);
            // 
            // rotbut
            // 
            resources.ApplyResources(this.rotbut, "rotbut");
            this.rotbut.Name = "rotbut";
            this.rotbut.UseVisualStyleBackColor = true;
            this.rotbut.Click += new System.EventHandler(this.rotbut_Click);
            // 
            // picolor
            // 
            resources.ApplyResources(this.picolor, "picolor");
            this.picolor.Name = "picolor";
            this.picolor.UseVisualStyleBackColor = true;
            this.picolor.Click += new System.EventHandler(this.picolor_Click);
            // 
            // picsize
            // 
            resources.ApplyResources(this.picsize, "picsize");
            this.picsize.Name = "picsize";
            this.picsize.UseVisualStyleBackColor = true;
            this.picsize.Click += new System.EventHandler(this.picsize_Click);
            // 
            // chBk
            // 
            resources.ApplyResources(this.chBk, "chBk");
            this.chBk.Name = "chBk";
            this.chBk.UseVisualStyleBackColor = true;
            this.chBk.CheckedChanged += new System.EventHandler(this.chBk_CheckedChanged);
            // 
            // openFileDiaPict
            // 
            this.openFileDiaPict.FileName = "openFileDialog1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button lopic;
        private System.Windows.Forms.Button bacolor;
        private System.Windows.Forms.Button rotbut;
        private System.Windows.Forms.Button picolor;
        private System.Windows.Forms.Button picsize;
        private System.Windows.Forms.CheckBox chBk;
        private System.Windows.Forms.OpenFileDialog openFileDiaPict;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

