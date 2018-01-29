namespace TestGame
{
    partial class Form1view
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
            this.tmrMoving = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrMoving
            // 
            this.tmrMoving.Enabled = true;
            this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
            // 
            // Form1view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 591);
            this.Name = "Form1view";
            this.Text = "Object_Moving";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1view_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1view_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMoving;
    }
}

