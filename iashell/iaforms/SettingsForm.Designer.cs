namespace iaforms
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.tabDerivative = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabMaster);
            this.tabControl1.Controls.Add(this.tabDerivative);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 594);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.checkedListBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(830, 561);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(177, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabMaster
            // 
            this.tabMaster.Location = new System.Drawing.Point(4, 29);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(830, 561);
            this.tabMaster.TabIndex = 1;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // tabDerivative
            // 
            this.tabDerivative.Location = new System.Drawing.Point(4, 29);
            this.tabDerivative.Name = "tabDerivative";
            this.tabDerivative.Size = new System.Drawing.Size(830, 561);
            this.tabDerivative.TabIndex = 2;
            this.tabDerivative.Text = "Derivative";
            this.tabDerivative.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 697);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabMaster;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabDerivative;
    }
}