namespace TextToSpeech
{
    partial class FormSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeech));
            this.LbHeading = new System.Windows.Forms.Label();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BtnSpeak = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Literata 60pt", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.Location = new System.Drawing.Point(324, 9);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(230, 42);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "Text To Speech";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTB1
            // 
            this.RTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB1.Font = new System.Drawing.Font("Aleo", 10F);
            this.RTB1.Location = new System.Drawing.Point(39, 60);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(800, 480);
            this.RTB1.TabIndex = 1;
            this.RTB1.Text = "";
            // 
            // BtnSpeak
            // 
            this.BtnSpeak.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSpeak.Font = new System.Drawing.Font("Amarna", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSpeak.Location = new System.Drawing.Point(145, 576);
            this.BtnSpeak.Name = "BtnSpeak";
            this.BtnSpeak.Size = new System.Drawing.Size(120, 40);
            this.BtnSpeak.TabIndex = 2;
            this.BtnSpeak.Text = "Speak";
            this.BtnSpeak.UseVisualStyleBackColor = false;
            this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeak_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPause.Font = new System.Drawing.Font("Amarna", 11F, System.Drawing.FontStyle.Bold);
            this.BtnPause.Location = new System.Drawing.Point(301, 576);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(120, 40);
            this.BtnPause.TabIndex = 2;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResume.Font = new System.Drawing.Font("Amarna", 11F, System.Drawing.FontStyle.Bold);
            this.BtnResume.Location = new System.Drawing.Point(457, 576);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(120, 40);
            this.BtnResume.TabIndex = 2;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = false;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStop.Font = new System.Drawing.Font("Amarna", 11F, System.Drawing.FontStyle.Bold);
            this.BtnStop.Location = new System.Drawing.Point(613, 576);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(120, 40);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // FormSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnResume);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnSpeak);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.LbHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 300);
            this.Name = "FormSpeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BtnSpeak;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnStop;
    }
}

