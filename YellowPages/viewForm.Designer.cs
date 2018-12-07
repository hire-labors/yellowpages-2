namespace YellowPages
{
    partial class viewForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtBday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEOR = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBOR = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(374, 89);
            this.txtAddress.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 217);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(15, 25);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(181, 20);
            this.txtFName.TabIndex = 14;
            // 
            // txtBday
            // 
            this.txtBday.Location = new System.Drawing.Point(15, 270);
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(166, 20);
            this.txtBday.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birthday : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEOR
            // 
            this.btnEOR.Location = new System.Drawing.Point(354, 318);
            this.btnEOR.Name = "btnEOR";
            this.btnEOR.Size = new System.Drawing.Size(35, 23);
            this.btnEOR.TabIndex = 18;
            this.btnEOR.Text = ">>";
            this.btnEOR.UseVisualStyleBackColor = true;
            this.btnEOR.Click += new System.EventHandler(this.btnEOR_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(313, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBOR
            // 
            this.btnBOR.Location = new System.Drawing.Point(12, 318);
            this.btnBOR.Name = "btnBOR";
            this.btnBOR.Size = new System.Drawing.Size(35, 23);
            this.btnBOR.TabIndex = 18;
            this.btnBOR.Text = "<<";
            this.btnBOR.UseVisualStyleBackColor = true;
            this.btnBOR.Click += new System.EventHandler(this.btnBOR_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(53, 318);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 23);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(202, 318);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 23);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete Contact";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(211, 25);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(181, 20);
            this.txtSName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname: ";
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 421);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnBOR);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnEOR);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFName);
            this.Name = "viewForm";
            this.Text = "viewForm";
            this.Load += new System.EventHandler(this.viewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtBday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEOR;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBOR;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label4;
    }
}