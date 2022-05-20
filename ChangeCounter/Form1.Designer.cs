
namespace ChangeCounter
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.fifteCentsPic = new System.Windows.Forms.PictureBox();
            this.twentyfiveCentsPic = new System.Windows.Forms.PictureBox();
            this.tenCentsPic = new System.Windows.Forms.PictureBox();
            this.fiveCentsPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fifteCentsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCentsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(171, 28);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(254, 31);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click Coins to Add";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(629, 271);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(89, 31);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(581, 322);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(182, 56);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(229, 550);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fifteCentsPic
            // 
            this.fifteCentsPic.Image = global::ChangeCounter.Properties.Resources._50a;
            this.fifteCentsPic.Location = new System.Drawing.Point(316, 322);
            this.fifteCentsPic.Name = "fifteCentsPic";
            this.fifteCentsPic.Size = new System.Drawing.Size(200, 200);
            this.fifteCentsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fifteCentsPic.TabIndex = 4;
            this.fifteCentsPic.TabStop = false;
            this.fifteCentsPic.Click += new System.EventHandler(this.fifteCentsPic_Click);
            // 
            // twentyfiveCentsPic
            // 
            this.twentyfiveCentsPic.Image = global::ChangeCounter.Properties.Resources._25;
            this.twentyfiveCentsPic.Location = new System.Drawing.Point(88, 322);
            this.twentyfiveCentsPic.Name = "twentyfiveCentsPic";
            this.twentyfiveCentsPic.Size = new System.Drawing.Size(200, 200);
            this.twentyfiveCentsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twentyfiveCentsPic.TabIndex = 3;
            this.twentyfiveCentsPic.TabStop = false;
            this.twentyfiveCentsPic.Click += new System.EventHandler(this.twentyfiveCentsPic_Click);
            // 
            // tenCentsPic
            // 
            this.tenCentsPic.Image = ((System.Drawing.Image)(resources.GetObject("tenCentsPic.Image")));
            this.tenCentsPic.Location = new System.Drawing.Point(316, 94);
            this.tenCentsPic.Name = "tenCentsPic";
            this.tenCentsPic.Size = new System.Drawing.Size(200, 200);
            this.tenCentsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tenCentsPic.TabIndex = 2;
            this.tenCentsPic.TabStop = false;
            this.tenCentsPic.Click += new System.EventHandler(this.tenCentsPic_Click);
            // 
            // fiveCentsPic
            // 
            this.fiveCentsPic.Image = global::ChangeCounter.Properties.Resources._5a;
            this.fiveCentsPic.Location = new System.Drawing.Point(88, 94);
            this.fiveCentsPic.Name = "fiveCentsPic";
            this.fiveCentsPic.Size = new System.Drawing.Size(200, 200);
            this.fiveCentsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiveCentsPic.TabIndex = 1;
            this.fiveCentsPic.TabStop = false;
            this.fiveCentsPic.Click += new System.EventHandler(this.fiveCentsPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 629);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.fifteCentsPic);
            this.Controls.Add(this.twentyfiveCentsPic);
            this.Controls.Add(this.tenCentsPic);
            this.Controls.Add(this.fiveCentsPic);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.fifteCentsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCentsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox fiveCentsPic;
        private System.Windows.Forms.PictureBox tenCentsPic;
        private System.Windows.Forms.PictureBox twentyfiveCentsPic;
        private System.Windows.Forms.PictureBox fifteCentsPic;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

