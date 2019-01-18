namespace FormWithListBox
{
    partial class FormWithListBox
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxDateofbirth = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.txtboxFilename = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.Color.Azure;
            this.grpbox.Controls.Add(this.btnChange);
            this.grpbox.Controls.Add(this.btnAdd);
            this.grpbox.Controls.Add(this.label5);
            this.grpbox.Controls.Add(this.label4);
            this.grpbox.Controls.Add(this.label3);
            this.grpbox.Controls.Add(this.label2);
            this.grpbox.Controls.Add(this.label1);
            this.grpbox.Controls.Add(this.txtboxDateofbirth);
            this.grpbox.Controls.Add(this.txtboxSurname);
            this.grpbox.Controls.Add(this.txtboxEmail);
            this.grpbox.Controls.Add(this.txtboxPhone);
            this.grpbox.Controls.Add(this.txtboxName);
            this.grpbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbox.Location = new System.Drawing.Point(12, 12);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(491, 358);
            this.grpbox.TabIndex = 0;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Form";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(61, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnChange_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnChange_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // txtboxDateofbirth
            // 
            this.txtboxDateofbirth.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxDateofbirth.Location = new System.Drawing.Point(123, 149);
            this.txtboxDateofbirth.Name = "txtboxDateofbirth";
            this.txtboxDateofbirth.Size = new System.Drawing.Size(195, 20);
            this.txtboxDateofbirth.TabIndex = 4;
            this.txtboxDateofbirth.Text = "Date of birth";
            this.txtboxDateofbirth.Enter += new System.EventHandler(this.txtboxDateofbirth_Enter);
            this.txtboxDateofbirth.Leave += new System.EventHandler(this.txtboxDateofbirth_Leave);
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxSurname.Location = new System.Drawing.Point(123, 71);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(195, 20);
            this.txtboxSurname.TabIndex = 1;
            this.txtboxSurname.Text = "Surname";
            this.txtboxSurname.Enter += new System.EventHandler(this.txtboxSurname_Enter);
            this.txtboxSurname.Leave += new System.EventHandler(this.txtboxSurname_Leave);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxEmail.Location = new System.Drawing.Point(123, 97);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(195, 20);
            this.txtboxEmail.TabIndex = 2;
            this.txtboxEmail.Text = "Email";
            this.txtboxEmail.Enter += new System.EventHandler(this.txtboxEmail_Enter);
            this.txtboxEmail.Leave += new System.EventHandler(this.txtboxEmail_Leave);
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxPhone.Location = new System.Drawing.Point(123, 123);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(195, 20);
            this.txtboxPhone.TabIndex = 3;
            this.txtboxPhone.Text = "Phone";
            this.txtboxPhone.Enter += new System.EventHandler(this.txtboxPhone_Enter);
            this.txtboxPhone.Leave += new System.EventHandler(this.txtboxPhone_Leave);
            // 
            // txtboxName
            // 
            this.txtboxName.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxName.Location = new System.Drawing.Point(123, 48);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(195, 20);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.Text = "Name";
            this.txtboxName.Enter += new System.EventHandler(this.txtboxName_Enter);
            this.txtboxName.Leave += new System.EventHandler(this.txtboxName_Leave);
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.Color.Azure;
            this.listbox.DisplayMember = "None";
            this.listbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 22;
            this.listbox.Location = new System.Drawing.Point(533, 26);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(255, 268);
            this.listbox.TabIndex = 1;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // txtboxFilename
            // 
            this.txtboxFilename.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtboxFilename.Location = new System.Drawing.Point(533, 307);
            this.txtboxFilename.Name = "txtboxFilename";
            this.txtboxFilename.Size = new System.Drawing.Size(255, 20);
            this.txtboxFilename.TabIndex = 2;
            this.txtboxFilename.Text = "Enter the file name (without extension)";
            this.txtboxFilename.TextChanged += new System.EventHandler(this.txtboxFilename_TextChanged);
            this.txtboxFilename.Enter += new System.EventHandler(this.txtboxFilename_Enter);
            this.txtboxFilename.Leave += new System.EventHandler(this.txtboxFilename_Leave);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Window;
            this.btnLoad.Location = new System.Drawing.Point(533, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(123, 37);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnLoad.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(665, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Window;
            this.btnChange.Location = new System.Drawing.Point(61, 272);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(330, 43);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "UPDATE İNFO";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.MouseLeave += new System.EventHandler(this.btnChange_MouseLeave);
            this.btnChange.MouseHover += new System.EventHandler(this.btnChange_MouseHover);
            // 
            // FormWithListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtboxFilename);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.grpbox);
            this.Name = "FormWithListBox";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.FormWithListBox_Load);
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.TextBox txtboxFilename;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxDateofbirth;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btnChange;
    }
}

