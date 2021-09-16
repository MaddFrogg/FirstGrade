
namespace FirstGrade
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
            this.fn = new System.Windows.Forms.TextBox();
            this.mn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prsnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(102, 0);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(458, 22);
            this.fn.TabIndex = 0;
            this.fn.TextChanged += new System.EventHandler(this.fn_TextChanged);
            // 
            // mn
            // 
            this.mn.Location = new System.Drawing.Point(102, 28);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(458, 22);
            this.mn.TabIndex = 1;
            this.mn.TextChanged += new System.EventHandler(this.mn_TextChanged);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(102, 56);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(458, 22);
            this.ln.TabIndex = 2;
            this.ln.TextChanged += new System.EventHandler(this.ln_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "middlename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "lastname";
            // 
            // prsnSave
            // 
            this.prsnSave.Location = new System.Drawing.Point(339, 145);
            this.prsnSave.Name = "prsnSave";
            this.prsnSave.Size = new System.Drawing.Size(75, 23);
            this.prsnSave.TabIndex = 6;
            this.prsnSave.Text = "Save";
            this.prsnSave.UseVisualStyleBackColor = true;
            this.prsnSave.Click += new System.EventHandler(this.prsnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prsnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.fn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox mn;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prsnSave;
    }
}