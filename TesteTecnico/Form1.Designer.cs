
namespace TesteTecnico
{
    partial class frmTeste
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lstInput = new System.Windows.Forms.ListBox();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdResult = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sector";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(65, 51);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(125, 27);
            this.txtValue.TabIndex = 2;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Items.AddRange(new object[] {
            "PRIVATE",
            "PUBLIC"});
            this.cmbSector.Location = new System.Drawing.Point(65, 152);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(151, 28);
            this.cmbSector.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(245, 69);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(95, 30);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = ">>";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lstInput
            // 
            this.lstInput.FormattingEnabled = true;
            this.lstInput.ItemHeight = 20;
            this.lstInput.Location = new System.Drawing.Point(375, 42);
            this.lstInput.Name = "lstInput";
            this.lstInput.Size = new System.Drawing.Size(285, 144);
            this.lstInput.TabIndex = 5;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(245, 120);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(95, 30);
            this.cmdRemove.TabIndex = 6;
            this.cmdRemove.Text = "<<";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdResult
            // 
            this.cmdResult.Location = new System.Drawing.Point(8, 213);
            this.cmdResult.Name = "cmdResult";
            this.cmdResult.Size = new System.Drawing.Size(652, 29);
            this.cmdResult.TabIndex = 7;
            this.cmdResult.Text = "Result";
            this.cmdResult.UseVisualStyleBackColor = true;
            this.cmdResult.Click += new System.EventHandler(this.cmdResult_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(168, 257);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(314, 104);
            this.lstOutput.TabIndex = 8;
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 400);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.cmdResult);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.lstInput);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListBox lstInput;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdResult;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

