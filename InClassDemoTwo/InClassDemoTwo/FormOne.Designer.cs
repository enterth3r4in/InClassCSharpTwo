namespace InClassDemoTwo
{
    partial class FormOne
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
            this.btnClickCounter = new System.Windows.Forms.Button();
            this.myFirstLabel = new System.Windows.Forms.Label();
            this.picboxFirstPicture = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFirstPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClickCounter
            // 
            this.btnClickCounter.Location = new System.Drawing.Point(249, 32);
            this.btnClickCounter.Name = "btnClickCounter";
            this.btnClickCounter.Size = new System.Drawing.Size(152, 38);
            this.btnClickCounter.TabIndex = 0;
            this.btnClickCounter.Text = "Click Counter";
            this.btnClickCounter.UseVisualStyleBackColor = true;
            this.btnClickCounter.Click += new System.EventHandler(this.button1_Click);
            // 
            // myFirstLabel
            // 
            this.myFirstLabel.AutoSize = true;
            this.myFirstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myFirstLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myFirstLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myFirstLabel.Location = new System.Drawing.Point(249, 102);
            this.myFirstLabel.Name = "myFirstLabel";
            this.myFirstLabel.Size = new System.Drawing.Size(2, 27);
            this.myFirstLabel.TabIndex = 1;
            this.myFirstLabel.Click += new System.EventHandler(this.myFirstLabel_Click);
            // 
            // picboxFirstPicture
            // 
            this.picboxFirstPicture.Image = global::InClassDemoTwo.Properties.Resources.minionHydrant;
            this.picboxFirstPicture.Location = new System.Drawing.Point(40, 257);
            this.picboxFirstPicture.Name = "picboxFirstPicture";
            this.picboxFirstPicture.Size = new System.Drawing.Size(194, 261);
            this.picboxFirstPicture.TabIndex = 2;
            this.picboxFirstPicture.TabStop = false;
            this.picboxFirstPicture.Visible = false;
            this.picboxFirstPicture.Click += new System.EventHandler(this.picboxFirstPicture_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 81);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 555);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picboxFirstPicture);
            this.Controls.Add(this.myFirstLabel);
            this.Controls.Add(this.btnClickCounter);
            this.MaximizeBox = false;
            this.Name = "FormOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shiny New Form";
            ((System.ComponentModel.ISupportInitialize)(this.picboxFirstPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickCounter;
        private System.Windows.Forms.Label myFirstLabel;
        private System.Windows.Forms.PictureBox picboxFirstPicture;
        private System.Windows.Forms.Button btnExit;
    }
}

