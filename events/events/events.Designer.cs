namespace events
{
    partial class events
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
            this.lblColor = new System.Windows.Forms.Label();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            this.rdoFrench = new System.Windows.Forms.RadioButton();
            this.rdoGerman = new System.Windows.Forms.RadioButton();
            this.rdoItalian = new System.Windows.Forms.RadioButton();
            this.rdoSpanish = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(383, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(137, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Please click on a color chip";
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.AutoSize = true;
            this.rdoEnglish.Checked = true;
            this.rdoEnglish.Location = new System.Drawing.Point(12, 5);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(59, 17);
            this.rdoEnglish.TabIndex = 1;
            this.rdoEnglish.TabStop = true;
            this.rdoEnglish.Text = "English";
            this.rdoEnglish.UseVisualStyleBackColor = true;
            this.rdoEnglish.Click += new System.EventHandler(this.rdoEnglish_Click);
            // 
            // rdoFrench
            // 
            this.rdoFrench.AutoSize = true;
            this.rdoFrench.Location = new System.Drawing.Point(77, 5);
            this.rdoFrench.Name = "rdoFrench";
            this.rdoFrench.Size = new System.Drawing.Size(58, 17);
            this.rdoFrench.TabIndex = 2;
            this.rdoFrench.Text = "French";
            this.rdoFrench.UseVisualStyleBackColor = true;
            this.rdoFrench.Click += new System.EventHandler(this.rdoFrench_Click);
            // 
            // rdoGerman
            // 
            this.rdoGerman.AutoSize = true;
            this.rdoGerman.Location = new System.Drawing.Point(141, 5);
            this.rdoGerman.Name = "rdoGerman";
            this.rdoGerman.Size = new System.Drawing.Size(62, 17);
            this.rdoGerman.TabIndex = 3;
            this.rdoGerman.Text = "German";
            this.rdoGerman.UseVisualStyleBackColor = true;
            this.rdoGerman.Click += new System.EventHandler(this.rdoGerman_Click);
            // 
            // rdoItalian
            // 
            this.rdoItalian.AutoSize = true;
            this.rdoItalian.Location = new System.Drawing.Point(209, 5);
            this.rdoItalian.Name = "rdoItalian";
            this.rdoItalian.Size = new System.Drawing.Size(53, 17);
            this.rdoItalian.TabIndex = 4;
            this.rdoItalian.Text = "Italian";
            this.rdoItalian.UseVisualStyleBackColor = true;
            this.rdoItalian.Click += new System.EventHandler(this.rdoItalian_Click);
            // 
            // rdoSpanish
            // 
            this.rdoSpanish.AutoSize = true;
            this.rdoSpanish.Location = new System.Drawing.Point(268, 5);
            this.rdoSpanish.Name = "rdoSpanish";
            this.rdoSpanish.Size = new System.Drawing.Size(63, 17);
            this.rdoSpanish.TabIndex = 5;
            this.rdoSpanish.Text = "Spanish";
            this.rdoSpanish.UseVisualStyleBackColor = true;
            this.rdoSpanish.Click += new System.EventHandler(this.rdoSpanish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ctrl + I : Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shift + A : Version";
            // 
            // events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoSpanish);
            this.Controls.Add(this.rdoItalian);
            this.Controls.Add(this.rdoGerman);
            this.Controls.Add(this.rdoFrench);
            this.Controls.Add(this.rdoEnglish);
            this.Controls.Add(this.lblColor);
            this.KeyPreview = true;
            this.Name = "events";
            this.Text = "Color Translations";
            this.Load += new System.EventHandler(this.events_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.events_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.events_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton rdoEnglish;
        private System.Windows.Forms.RadioButton rdoFrench;
        private System.Windows.Forms.RadioButton rdoGerman;
        private System.Windows.Forms.RadioButton rdoItalian;
        private System.Windows.Forms.RadioButton rdoSpanish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

