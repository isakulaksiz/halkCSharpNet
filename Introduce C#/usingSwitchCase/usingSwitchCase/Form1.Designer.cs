namespace usingSwitchCase
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCalender = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownTaxCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(235, 45);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(168, 23);
            this.textBoxPrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taksit Sayısı";
            // 
            // listBoxCalender
            // 
            this.listBoxCalender.FormattingEnabled = true;
            this.listBoxCalender.ItemHeight = 15;
            this.listBoxCalender.Location = new System.Drawing.Point(67, 165);
            this.listBoxCalender.Name = "listBoxCalender";
            this.listBoxCalender.Size = new System.Drawing.Size(336, 169);
            this.listBoxCalender.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(328, 123);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Hesapla";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numericUpDownTaxCount
            // 
            this.numericUpDownTaxCount.Location = new System.Drawing.Point(235, 84);
            this.numericUpDownTaxCount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownTaxCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownTaxCount.Name = "numericUpDownTaxCount";
            this.numericUpDownTaxCount.Size = new System.Drawing.Size(72, 23);
            this.numericUpDownTaxCount.TabIndex = 6;
            this.numericUpDownTaxCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 391);
            this.Controls.Add(this.numericUpDownTaxCount);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.listBoxCalender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPrice;
        private Label label1;
        private Label label2;
        private ListBox listBoxCalender;
        private Button buttonCalculate;
        private NumericUpDown numericUpDownTaxCount;
    }
}