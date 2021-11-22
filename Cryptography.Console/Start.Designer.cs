namespace Cryptography.Console
{
    partial class Start
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
            this.TextTextbox = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.AlgorithmCombobox = new System.Windows.Forms.ComboBox();
            this.ActionCombobox = new System.Windows.Forms.ComboBox();
            this.LoadKeys = new System.Windows.Forms.Button();
            this.AlgorithmLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.GenerateKeys = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextTextbox
            // 
            this.TextTextbox.Location = new System.Drawing.Point(12, 107);
            this.TextTextbox.Name = "TextTextbox";
            this.TextTextbox.Size = new System.Drawing.Size(355, 23);
            this.TextTextbox.TabIndex = 0;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(12, 171);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(450, 23);
            this.ResultTextbox.TabIndex = 1;
            // 
            // AlgorithmCombobox
            // 
            this.AlgorithmCombobox.FormattingEnabled = true;
            this.AlgorithmCombobox.Location = new System.Drawing.Point(12, 44);
            this.AlgorithmCombobox.Name = "AlgorithmCombobox";
            this.AlgorithmCombobox.Size = new System.Drawing.Size(121, 23);
            this.AlgorithmCombobox.TabIndex = 2;
            // 
            // ActionCombobox
            // 
            this.ActionCombobox.FormattingEnabled = true;
            this.ActionCombobox.Location = new System.Drawing.Point(139, 44);
            this.ActionCombobox.Name = "ActionCombobox";
            this.ActionCombobox.Size = new System.Drawing.Size(121, 23);
            this.ActionCombobox.TabIndex = 3;
            // 
            // LoadKeys
            // 
            this.LoadKeys.Location = new System.Drawing.Point(292, 44);
            this.LoadKeys.Name = "LoadKeys";
            this.LoadKeys.Size = new System.Drawing.Size(75, 23);
            this.LoadKeys.TabIndex = 4;
            this.LoadKeys.Text = "Load Keys";
            this.LoadKeys.UseVisualStyleBackColor = true;
            this.LoadKeys.Click += new System.EventHandler(this.LoadKeys_Click);
            // 
            // AlgorithmLabel
            // 
            this.AlgorithmLabel.AutoSize = true;
            this.AlgorithmLabel.Location = new System.Drawing.Point(12, 25);
            this.AlgorithmLabel.Name = "AlgorithmLabel";
            this.AlgorithmLabel.Size = new System.Drawing.Size(61, 15);
            this.AlgorithmLabel.TabIndex = 5;
            this.AlgorithmLabel.Text = "Algorithm";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(139, 25);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(42, 15);
            this.ActionLabel.TabIndex = 6;
            this.ActionLabel.Text = "Action";
            // 
            // GenerateKeys
            // 
            this.GenerateKeys.Location = new System.Drawing.Point(373, 44);
            this.GenerateKeys.Name = "GenerateKeys";
            this.GenerateKeys.Size = new System.Drawing.Size(89, 23);
            this.GenerateKeys.TabIndex = 7;
            this.GenerateKeys.Text = "Generate Keys";
            this.GenerateKeys.UseVisualStyleBackColor = true;
            this.GenerateKeys.Click += new System.EventHandler(this.GenerateKeys_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 89);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 15);
            this.TextLabel.TabIndex = 8;
            this.TextLabel.Text = "Text";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(373, 107);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(89, 24);
            this.Execute.TabIndex = 9;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 153);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(39, 15);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Result";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.GenerateKeys);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.AlgorithmLabel);
            this.Controls.Add(this.LoadKeys);
            this.Controls.Add(this.ActionCombobox);
            this.Controls.Add(this.AlgorithmCombobox);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.TextTextbox);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextTextbox;
        private TextBox ResultTextbox;
        private ComboBox AlgorithmCombobox;
        private ComboBox ActionCombobox;
        private Button LoadKeys;
        private Label AlgorithmLabel;
        private Label ActionLabel;
        private Button GenerateKeys;
        private Label TextLabel;
        private Button Execute;
        private Label ResultLabel;
    }
}