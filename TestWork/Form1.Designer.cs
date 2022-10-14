
namespace TestWork
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.Label();
            this.buttonFindWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(12, 12);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(221, 20);
            this.inputText.TabIndex = 0;
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(12, 39);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(183, 13);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "Результат проверки будет здесь :)";
            // 
            // buttonFindWords
            // 
            this.buttonFindWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindWords.Location = new System.Drawing.Point(239, 10);
            this.buttonFindWords.Name = "buttonFindWords";
            this.buttonFindWords.Size = new System.Drawing.Size(76, 23);
            this.buttonFindWords.TabIndex = 2;
            this.buttonFindWords.Text = "проверить";
            this.buttonFindWords.UseVisualStyleBackColor = true;
            this.buttonFindWords.Click += new System.EventHandler(this.ButtonFindWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 230);
            this.Controls.Add(this.buttonFindWords);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Button buttonFindWords;
    }
}

