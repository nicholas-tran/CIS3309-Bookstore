namespace Tran_CIS3309_BookstoreProject
{
    partial class frmPin
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnOKPin = new System.Windows.Forms.Button();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblPinEntryForm = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(132, 100);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 0;
            // 
            // btnOKPin
            // 
            this.btnOKPin.Location = new System.Drawing.Point(30, 146);
            this.btnOKPin.Name = "btnOKPin";
            this.btnOKPin.Size = new System.Drawing.Size(75, 23);
            this.btnOKPin.TabIndex = 1;
            this.btnOKPin.Text = "OK";
            this.btnOKPin.UseVisualStyleBackColor = true;
            this.btnOKPin.Click += new System.EventHandler(this.btnOKPin_Click);
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Location = new System.Drawing.Point(12, 84);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(118, 13);
            this.lblEnterPin.TabIndex = 5;
            this.lblEnterPin.Text = "Enter Pin and Press OK";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(64, 15);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(114, 13);
            this.lblStore.TabIndex = 4;
            this.lblStore.Text = "Book Worm Bookstore";
            // 
            // lblPinEntryForm
            // 
            this.lblPinEntryForm.AutoSize = true;
            this.lblPinEntryForm.Location = new System.Drawing.Point(82, 41);
            this.lblPinEntryForm.Name = "lblPinEntryForm";
            this.lblPinEntryForm.Size = new System.Drawing.Size(75, 13);
            this.lblPinEntryForm.TabIndex = 8;
            this.lblPinEntryForm.Text = "Pin Entry Form";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(12, 103);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(114, 13);
            this.lblPin.TabIndex = 9;
            this.lblPin.Text = "Pin (A 4 Digit Number) ";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(132, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPin
            // 
            this.AcceptButton = this.btnOKPin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(245, 190);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblPinEntryForm);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnOKPin);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.lblStore);
            this.Name = "frmPin";
            this.Text = "frmPin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnOKPin;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblPinEntryForm;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnExit;
    }
}