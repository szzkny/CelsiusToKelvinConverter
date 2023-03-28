namespace CelsiusToKelvinConverter
{
    partial class form_converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_converter));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(214, 73);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(370, 31);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Celsius (C°) - Kelvin (K) Converter";
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.AutoSize = true;
            this.lbl_celsius.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_celsius.Location = new System.Drawing.Point(291, 141);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(103, 25);
            this.lbl_celsius.TabIndex = 1;
            this.lbl_celsius.Text = "Celsius (C°):";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kelvin.Location = new System.Drawing.Point(307, 185);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(87, 25);
            this.lbl_kelvin.TabIndex = 2;
            this.lbl_kelvin.Text = "Kelvin (K):";
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(403, 185);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(110, 25);
            this.lbl_result.TabIndex = 3;
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_input.Location = new System.Drawing.Point(403, 144);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(110, 31);
            this.txt_input.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(368, 250);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(99, 32);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // form_converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_celsius);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label lbl_celsius;
        private Label lbl_kelvin;
        private Label lbl_result;
        private TextBox txt_input;
        private Button btn_convert;
    }
}