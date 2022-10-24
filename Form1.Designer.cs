
namespace Anomaly_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modelBtn = new System.Windows.Forms.Button();
            this.imageBtn = new System.Windows.Forms.Button();
            this.modelTbox = new System.Windows.Forms.TextBox();
            this.imageTbox = new System.Windows.Forms.TextBox();
            this.modelpathLabel = new System.Windows.Forms.Label();
            this.imagepathLabel = new System.Windows.Forms.Label();
            this.predictBtn = new System.Windows.Forms.Button();
            this.savepathLabel = new System.Windows.Forms.Label();
            this.savepathTbox = new System.Windows.Forms.TextBox();
            this.savepathBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.outputTbox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modelBtn
            // 
            this.modelBtn.Location = new System.Drawing.Point(512, 59);
            this.modelBtn.Name = "modelBtn";
            this.modelBtn.Size = new System.Drawing.Size(32, 23);
            this.modelBtn.TabIndex = 1;
            this.modelBtn.Text = "...";
            this.modelBtn.UseVisualStyleBackColor = true;
            this.modelBtn.Click += new System.EventHandler(this.modelBtn_Click);
            // 
            // imageBtn
            // 
            this.imageBtn.Location = new System.Drawing.Point(512, 115);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(32, 23);
            this.imageBtn.TabIndex = 2;
            this.imageBtn.Text = "...";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.Click += new System.EventHandler(this.imageBtn_Click);
            // 
            // modelTbox
            // 
            this.modelTbox.Location = new System.Drawing.Point(80, 60);
            this.modelTbox.Name = "modelTbox";
            this.modelTbox.ReadOnly = true;
            this.modelTbox.Size = new System.Drawing.Size(426, 23);
            this.modelTbox.TabIndex = 3;
            // 
            // imageTbox
            // 
            this.imageTbox.Location = new System.Drawing.Point(80, 115);
            this.imageTbox.Name = "imageTbox";
            this.imageTbox.ReadOnly = true;
            this.imageTbox.Size = new System.Drawing.Size(426, 23);
            this.imageTbox.TabIndex = 4;
            // 
            // modelpathLabel
            // 
            this.modelpathLabel.AutoSize = true;
            this.modelpathLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelpathLabel.Location = new System.Drawing.Point(80, 35);
            this.modelpathLabel.Name = "modelpathLabel";
            this.modelpathLabel.Size = new System.Drawing.Size(80, 19);
            this.modelpathLabel.TabIndex = 5;
            this.modelpathLabel.Text = "Model Path";
            // 
            // imagepathLabel
            // 
            this.imagepathLabel.AutoSize = true;
            this.imagepathLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imagepathLabel.Location = new System.Drawing.Point(80, 90);
            this.imagepathLabel.Name = "imagepathLabel";
            this.imagepathLabel.Size = new System.Drawing.Size(79, 19);
            this.imagepathLabel.TabIndex = 6;
            this.imagepathLabel.Text = "Image Path";
            // 
            // predictBtn
            // 
            this.predictBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.predictBtn.Location = new System.Drawing.Point(568, 59);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(96, 133);
            this.predictBtn.TabIndex = 7;
            this.predictBtn.Text = "Predict";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // savepathLabel
            // 
            this.savepathLabel.AutoSize = true;
            this.savepathLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savepathLabel.Location = new System.Drawing.Point(80, 145);
            this.savepathLabel.Name = "savepathLabel";
            this.savepathLabel.Size = new System.Drawing.Size(69, 19);
            this.savepathLabel.TabIndex = 8;
            this.savepathLabel.Text = "Save Path";
            // 
            // savepathTbox
            // 
            this.savepathTbox.Location = new System.Drawing.Point(80, 170);
            this.savepathTbox.Name = "savepathTbox";
            this.savepathTbox.ReadOnly = true;
            this.savepathTbox.Size = new System.Drawing.Size(426, 23);
            this.savepathTbox.TabIndex = 9;
            // 
            // savepathBtn
            // 
            this.savepathBtn.Location = new System.Drawing.Point(512, 170);
            this.savepathBtn.Name = "savepathBtn";
            this.savepathBtn.Size = new System.Drawing.Size(32, 23);
            this.savepathBtn.TabIndex = 10;
            this.savepathBtn.Text = "...";
            this.savepathBtn.UseVisualStyleBackColor = true;
            this.savepathBtn.Click += new System.EventHandler(this.savepathBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.Location = new System.Drawing.Point(80, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(584, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // outputTbox
            // 
            this.outputTbox.AllowDrop = true;
            this.outputTbox.Location = new System.Drawing.Point(80, 242);
            this.outputTbox.Multiline = true;
            this.outputTbox.Name = "outputTbox";
            this.outputTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTbox.Size = new System.Drawing.Size(584, 73);
            this.outputTbox.TabIndex = 12;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(80, 199);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 19);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(738, 346);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.outputTbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.savepathBtn);
            this.Controls.Add(this.savepathTbox);
            this.Controls.Add(this.savepathLabel);
            this.Controls.Add(this.predictBtn);
            this.Controls.Add(this.imagepathLabel);
            this.Controls.Add(this.modelpathLabel);
            this.Controls.Add(this.imageTbox);
            this.Controls.Add(this.modelTbox);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.modelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CLAVI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modelBtn;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.TextBox modelTbox;
        private System.Windows.Forms.TextBox imageTbox;
        private System.Windows.Forms.Label modelpathLabel;
        private System.Windows.Forms.Label imagepathLabel;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Label savepathLabel;
        private System.Windows.Forms.TextBox savepathTbox;
        private System.Windows.Forms.Button savepathBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox outputTbox;
        private System.Windows.Forms.Label statusLabel;
    }
}

