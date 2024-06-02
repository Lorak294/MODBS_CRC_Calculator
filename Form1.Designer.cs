namespace MODBS_CRC_Calculator
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
            bytesInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            iterationCountInput = new NumericUpDown();
            groupbox1 = new GroupBox();
            singleTimeLabel = new Label();
            totalTimeLabel = new Label();
            resultLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            calcCRCBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)iterationCountInput).BeginInit();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // bytesInput
            // 
            bytesInput.Location = new Point(16, 35);
            bytesInput.Name = "bytesInput";
            bytesInput.Size = new Size(430, 23);
            bytesInput.TabIndex = 0;
            bytesInput.Validating += bytesInput_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Frame Bytes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 74);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "# Iterations";
            // 
            // iterationCountInput
            // 
            iterationCountInput.Location = new Point(368, 92);
            iterationCountInput.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iterationCountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            iterationCountInput.Name = "iterationCountInput";
            iterationCountInput.Size = new Size(78, 23);
            iterationCountInput.TabIndex = 4;
            iterationCountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(singleTimeLabel);
            groupbox1.Controls.Add(totalTimeLabel);
            groupbox1.Controls.Add(resultLabel);
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label3);
            groupbox1.Location = new Point(16, 74);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(346, 128);
            groupbox1.TabIndex = 5;
            groupbox1.TabStop = false;
            groupbox1.Text = "Result";
            // 
            // singleTimeLabel
            // 
            singleTimeLabel.AutoSize = true;
            singleTimeLabel.Location = new Point(158, 85);
            singleTimeLabel.Name = "singleTimeLabel";
            singleTimeLabel.Size = new Size(0, 15);
            singleTimeLabel.TabIndex = 5;
            // 
            // totalTimeLabel
            // 
            totalTimeLabel.AutoSize = true;
            totalTimeLabel.Location = new Point(158, 56);
            totalTimeLabel.Name = "totalTimeLabel";
            totalTimeLabel.Size = new Size(0, 15);
            totalTimeLabel.TabIndex = 4;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(158, 29);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 85);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 2;
            label5.Text = "Time per iteration [ms]:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 58);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 1;
            label4.Text = "Total Execution time [ms]:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "CRC Sum Result:";
            // 
            // calcCRCBtn
            // 
            calcCRCBtn.Location = new Point(368, 121);
            calcCRCBtn.Name = "calcCRCBtn";
            calcCRCBtn.Size = new Size(78, 81);
            calcCRCBtn.TabIndex = 6;
            calcCRCBtn.Text = "Calculate";
            calcCRCBtn.UseVisualStyleBackColor = true;
            calcCRCBtn.Click += calcCRCBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 227);
            Controls.Add(calcCRCBtn);
            Controls.Add(groupbox1);
            Controls.Add(iterationCountInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bytesInput);
            Name = "Form1";
            Text = "MODBUS CRC Calculator";
            ((System.ComponentModel.ISupportInitialize)iterationCountInput).EndInit();
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bytesInput;
        private Label label1;
        private Label label2;
        private NumericUpDown iterationCountInput;
        private GroupBox groupbox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button calcCRCBtn;
        private Label singleTimeLabel;
        private Label totalTimeLabel;
        private Label resultLabel;
    }
}
