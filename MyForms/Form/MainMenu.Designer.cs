namespace MyForms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainBtn0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBtn2 = new System.Windows.Forms.Button();
            this.MainBtn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBtn0
            // 
            resources.ApplyResources(this.MainBtn0, "MainBtn0");
            this.MainBtn0.Name = "MainBtn0";
            this.MainBtn0.UseVisualStyleBackColor = true;
            this.MainBtn0.Click += new System.EventHandler(this.MainBtn0_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.MainBtn2);
            this.panel1.Controls.Add(this.MainBtn1);
            this.panel1.Controls.Add(this.MainBtn0);
            this.panel1.Name = "panel1";
            // 
            // MainBtn2
            // 
            resources.ApplyResources(this.MainBtn2, "MainBtn2");
            this.MainBtn2.Name = "MainBtn2";
            this.MainBtn2.UseVisualStyleBackColor = true;
            this.MainBtn2.Click += new System.EventHandler(this.MainBtn2_Click);
            // 
            // MainBtn1
            // 
            resources.ApplyResources(this.MainBtn1, "MainBtn1");
            this.MainBtn1.Name = "MainBtn1";
            this.MainBtn1.UseVisualStyleBackColor = true;
            this.MainBtn1.Click += new System.EventHandler(this.MainBtn1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button MainBtn0;
        private Panel panel1;
        private Button MainBtn2;
        private Button MainBtn1;
    }
}