
namespace project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiphotosModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(240, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 353);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            this.panel1.AutoScroll = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 407);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.singleModeToolStripMenuItem,
            this.multiphotosModeToolStripMenuItem,
            this.slideshowModeToolStripMenuItem,
            this.defaultModeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // singleModeToolStripMenuItem
            // 
            this.singleModeToolStripMenuItem.Name = "singleModeToolStripMenuItem";
            this.singleModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.singleModeToolStripMenuItem.Text = "Single mode";
            this.singleModeToolStripMenuItem.Click += new System.EventHandler(this.singleModeToolStripMenuItem_Click);
            // 
            // multiphotosModeToolStripMenuItem
            // 
            this.multiphotosModeToolStripMenuItem.Name = "multiphotosModeToolStripMenuItem";
            this.multiphotosModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.multiphotosModeToolStripMenuItem.Text = "Multi-photos mode";
            this.multiphotosModeToolStripMenuItem.Click += new System.EventHandler(this.multiphotosModeToolStripMenuItem_Click);
            // 
            // slideshowModeToolStripMenuItem
            // 
            this.slideshowModeToolStripMenuItem.Name = "slideshowModeToolStripMenuItem";
            this.slideshowModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.slideshowModeToolStripMenuItem.Text = "Slideshow mode";
            this.slideshowModeToolStripMenuItem.Click += new System.EventHandler(this.slideshowModeToolStripMenuItem_Click);
            // 
            // defaultModeToolStripMenuItem
            // 
            this.defaultModeToolStripMenuItem.Name = "defaultModeToolStripMenuItem";
            this.defaultModeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.defaultModeToolStripMenuItem.Text = "Default mode";
            this.defaultModeToolStripMenuItem.Visible = false;
            this.defaultModeToolStripMenuItem.Click += new System.EventHandler(this.defaultModeToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 353);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(243, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 353);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(732, 444);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiphotosModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideshowModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultModeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

