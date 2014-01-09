namespace WinForms
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
            this.components = new System.ComponentModel.Container();
            this.bsMS = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editLengthMS = new System.Windows.Forms.TextBox();
            this.editMessageMS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsMS)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMS
            // 
            this.bsMS.DataSource = typeof(DataObjs.MyDataObject);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message:";
            // 
            // editLengthMS
            // 
            this.editLengthMS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMS, "MessageLength", true));
            this.editLengthMS.Location = new System.Drawing.Point(104, 57);
            this.editLengthMS.Name = "editLengthMS";
            this.editLengthMS.Size = new System.Drawing.Size(100, 20);
            this.editLengthMS.TabIndex = 5;
            // 
            // editMessageMS
            // 
            this.editMessageMS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMS, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editMessageMS.Location = new System.Drawing.Point(104, 31);
            this.editMessageMS.Name = "editMessageMS";
            this.editMessageMS.Size = new System.Drawing.Size(100, 20);
            this.editMessageMS.TabIndex = 4;
            this.editMessageMS.TextChanged += new System.EventHandler(this.editMessageMS_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editLengthMS);
            this.Controls.Add(this.editMessageMS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editLengthMS;
        private System.Windows.Forms.TextBox editMessageMS;
    }
}

