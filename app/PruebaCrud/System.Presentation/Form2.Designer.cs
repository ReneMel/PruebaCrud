
namespace System.Presentation
{
    partial class Form2
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
            this.textname = new System.Windows.Forms.TextBox();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.duitxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(113, 51);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 0;
            // 
            // datepicker1
            // 
            this.datepicker1.Location = new System.Drawing.Point(39, 178);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(200, 20);
            this.datepicker1.TabIndex = 1;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(98, 238);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 2;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(36, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 3;
            this.name.Text = "name";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(113, 95);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(100, 20);
            this.lastnametxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "lastname";
            // 
            // duitxt
            // 
            this.duitxt.Location = new System.Drawing.Point(113, 134);
            this.duitxt.Name = "duitxt";
            this.duitxt.Size = new System.Drawing.Size(100, 20);
            this.duitxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "dui";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duitxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.textname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox textname;
        private Windows.Forms.DateTimePicker datepicker1;
        private Windows.Forms.Button guardarBtn;
        private Windows.Forms.Label name;
        private Windows.Forms.TextBox lastnametxt;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox duitxt;
        private Windows.Forms.Label label2;
    }
}