
namespace persist_start_location
{
    partial class MainForm
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
            this.buttonSaveSizeAndPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveSizeAndPosition
            // 
            this.buttonSaveSizeAndPosition.Location = new System.Drawing.Point(30, 53);
            this.buttonSaveSizeAndPosition.Name = "buttonSaveSizeAndPosition";
            this.buttonSaveSizeAndPosition.Size = new System.Drawing.Size(280, 34);
            this.buttonSaveSizeAndPosition.TabIndex = 0;
            this.buttonSaveSizeAndPosition.Text = "Save Size and Position";
            this.buttonSaveSizeAndPosition.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonSaveSizeAndPosition);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSizeAndPosition;
    }
}

