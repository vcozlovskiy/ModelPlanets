
namespace MatModelPlanets.Forms
{
    partial class AddPlanet
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBvelositiY = new System.Windows.Forms.TextBox();
            this.tBvelositiX = new System.Windows.Forms.TextBox();
            this.tBMass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Velocity Y :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Velocity Х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mass :";
            // 
            // tBvelositiY
            // 
            this.tBvelositiY.Location = new System.Drawing.Point(113, 70);
            this.tBvelositiY.Margin = new System.Windows.Forms.Padding(4);
            this.tBvelositiY.Name = "tBvelositiY";
            this.tBvelositiY.Size = new System.Drawing.Size(103, 22);
            this.tBvelositiY.TabIndex = 15;
            // 
            // tBvelositiX
            // 
            this.tBvelositiX.Location = new System.Drawing.Point(113, 40);
            this.tBvelositiX.Margin = new System.Windows.Forms.Padding(4);
            this.tBvelositiX.Name = "tBvelositiX";
            this.tBvelositiX.Size = new System.Drawing.Size(103, 22);
            this.tBvelositiX.TabIndex = 14;
            // 
            // tBMass
            // 
            this.tBMass.Location = new System.Drawing.Point(113, 13);
            this.tBMass.Margin = new System.Windows.Forms.Padding(4);
            this.tBMass.Name = "tBMass";
            this.tBMass.Size = new System.Drawing.Size(103, 22);
            this.tBMass.TabIndex = 13;
            this.tBMass.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // AddPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBvelositiY);
            this.Controls.Add(this.tBvelositiX);
            this.Controls.Add(this.tBMass);
            this.Name = "AddPlanet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBvelositiY;
        private System.Windows.Forms.TextBox tBvelositiX;
        private System.Windows.Forms.TextBox tBMass;
        private System.Windows.Forms.Button button1;
    }
}