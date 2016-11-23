namespace _16.CatchTheButton
{
    partial class FormCatchTheButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatchTheButton));
            this.btnCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchMe
            // 
            this.btnCatchMe.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCatchMe, "btnCatchMe");
            this.btnCatchMe.Name = "btnCatchMe";
            this.btnCatchMe.UseVisualStyleBackColor = true;
            this.btnCatchMe.Click += new System.EventHandler(this.btnCatchMe_Click);
            this.btnCatchMe.MouseEnter += new System.EventHandler(this.btnCatchMe_MouseEnter);
            // 
            // FormCatchTheButton
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCatchMe);
            this.Name = "FormCatchTheButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchMe;
    }
}

