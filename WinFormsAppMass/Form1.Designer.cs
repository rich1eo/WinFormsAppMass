namespace WinFormsAppMass
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizemas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MassivIn = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.randomElem = new System.Windows.Forms.Button();
            this.SearchMax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Maxelem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sizemas
            // 
            this.sizemas.Location = new System.Drawing.Point(243, 40);
            this.sizemas.Name = "sizemas";
            this.sizemas.Size = new System.Drawing.Size(151, 20);
            this.sizemas.TabIndex = 0;
            this.sizemas.TextChanged += new System.EventHandler(this.sizemas_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество элементов массива: \r\n\r\n";
            // 
            // MassivIn
            // 
            this.MassivIn.Location = new System.Drawing.Point(19, 72);
            this.MassivIn.Multiline = true;
            this.MassivIn.Name = "MassivIn";
            this.MassivIn.Size = new System.Drawing.Size(218, 262);
            this.MassivIn.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(275, 92);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(119, 35);
            this.reset.TabIndex = 3;
            this.reset.Text = "Очистка\r\n";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // randomElem
            // 
            this.randomElem.Location = new System.Drawing.Point(275, 147);
            this.randomElem.Name = "randomElem";
            this.randomElem.Size = new System.Drawing.Size(119, 35);
            this.randomElem.TabIndex = 4;
            this.randomElem.Text = "Заполнить\r\n";
            this.randomElem.UseVisualStyleBackColor = true;
            this.randomElem.Click += new System.EventHandler(this.randomElem_Click);
            // 
            // SearchMax
            // 
            this.SearchMax.Location = new System.Drawing.Point(275, 205);
            this.SearchMax.Name = "SearchMax";
            this.SearchMax.Size = new System.Drawing.Size(119, 75);
            this.SearchMax.TabIndex = 5;
            this.SearchMax.Text = "Максимальный по модулю элемент массива, если сумма элементов массива больше 50\r\n";
            this.SearchMax.UseVisualStyleBackColor = true;
            this.SearchMax.Click += new System.EventHandler(this.SearchMax_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Максимальный по модулю элемент массива:\r\n\r\n";
            // 
            // Maxelem
            // 
            this.Maxelem.Enabled = false;
            this.Maxelem.Location = new System.Drawing.Point(270, 385);
            this.Maxelem.Name = "Maxelem";
            this.Maxelem.Size = new System.Drawing.Size(98, 20);
            this.Maxelem.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.Maxelem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchMax);
            this.Controls.Add(this.randomElem);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.MassivIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizemas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button randomElem;
        private System.Windows.Forms.Button reset;

        private System.Windows.Forms.TextBox MassivIn;
        private System.Windows.Forms.TextBox Maxelem;
        private System.Windows.Forms.Button SearchMax;

        private System.Windows.Forms.Label label2;

        protected System.Windows.Forms.TextBox sizemas;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}