
namespace TheBindingOfIsaac
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
            this.isaac = new System.Windows.Forms.PictureBox();
            this.potion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isaac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion)).BeginInit();
            this.SuspendLayout();
            // 
            // isaac
            // 
            this.isaac.BackgroundImage = global::TheBindingOfIsaac.Properties.Resources.isaac1;
            this.isaac.Location = new System.Drawing.Point(135, 146);
            this.isaac.Name = "isaac";
            this.isaac.Size = new System.Drawing.Size(36, 42);
            this.isaac.TabIndex = 0;
            this.isaac.TabStop = false;
            this.isaac.Click += new System.EventHandler(this.isaac_Click);
            // 
            // potion
            // 
            this.potion.Image = global::TheBindingOfIsaac.Properties.Resources.potion;
            this.potion.Location = new System.Drawing.Point(231, 141);
            this.potion.Name = "potion";
            this.potion.Size = new System.Drawing.Size(42, 47);
            this.potion.TabIndex = 1;
            this.potion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheBindingOfIsaac.Properties.Resources.Downpour;
            this.ClientSize = new System.Drawing.Size(901, 601);
            this.Controls.Add(this.potion);
            this.Controls.Add(this.isaac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.isaac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox isaac;
        private System.Windows.Forms.PictureBox potion;
    }
}

