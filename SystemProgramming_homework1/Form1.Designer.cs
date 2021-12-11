namespace SystemProgramming_homework1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lowerBoundTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upperBoundTextBox = new System.Windows.Forms.TextBox();
            this.startPrimeNumbersButton = new System.Windows.Forms.Button();
            this.primeNumbersTextBox = new System.Windows.Forms.TextBox();
            this.fibonacciNumbersTextBox = new System.Windows.Forms.TextBox();
            this.startFibonacciButton = new System.Windows.Forms.Button();
            this.stopPrimeButton = new System.Windows.Forms.Button();
            this.stopFibonacciButton = new System.Windows.Forms.Button();
            this.pausePrimeNumbersButton = new System.Windows.Forms.Button();
            this.resumePrimeNumbersButton = new System.Windows.Forms.Button();
            this.restartPrimeButton = new System.Windows.Forms.Button();
            this.restartFibonacciButton = new System.Windows.Forms.Button();
            this.pauseFibonacciButton = new System.Windows.Forms.Button();
            this.resumeFibonacciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Bound: ";
            // 
            // lowerBoundTextBox
            // 
            this.lowerBoundTextBox.Location = new System.Drawing.Point(143, 6);
            this.lowerBoundTextBox.Name = "lowerBoundTextBox";
            this.lowerBoundTextBox.Size = new System.Drawing.Size(125, 31);
            this.lowerBoundTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upper Bound: ";
            // 
            // upperBoundTextBox
            // 
            this.upperBoundTextBox.Location = new System.Drawing.Point(432, 9);
            this.upperBoundTextBox.Name = "upperBoundTextBox";
            this.upperBoundTextBox.Size = new System.Drawing.Size(125, 31);
            this.upperBoundTextBox.TabIndex = 3;
            // 
            // startPrimeNumbersButton
            // 
            this.startPrimeNumbersButton.Location = new System.Drawing.Point(597, 9);
            this.startPrimeNumbersButton.Name = "startPrimeNumbersButton";
            this.startPrimeNumbersButton.Size = new System.Drawing.Size(132, 31);
            this.startPrimeNumbersButton.TabIndex = 4;
            this.startPrimeNumbersButton.Text = "Start(Prime)";
            this.startPrimeNumbersButton.UseVisualStyleBackColor = true;
            this.startPrimeNumbersButton.Click += new System.EventHandler(this.startPrimeNumbersButton_Click);
            // 
            // primeNumbersTextBox
            // 
            this.primeNumbersTextBox.Location = new System.Drawing.Point(12, 55);
            this.primeNumbersTextBox.Multiline = true;
            this.primeNumbersTextBox.Name = "primeNumbersTextBox";
            this.primeNumbersTextBox.Size = new System.Drawing.Size(717, 88);
            this.primeNumbersTextBox.TabIndex = 5;
            // 
            // fibonacciNumbersTextBox
            // 
            this.fibonacciNumbersTextBox.Location = new System.Drawing.Point(12, 285);
            this.fibonacciNumbersTextBox.Multiline = true;
            this.fibonacciNumbersTextBox.Name = "fibonacciNumbersTextBox";
            this.fibonacciNumbersTextBox.Size = new System.Drawing.Size(717, 84);
            this.fibonacciNumbersTextBox.TabIndex = 6;
            // 
            // startFibonacciButton
            // 
            this.startFibonacciButton.Location = new System.Drawing.Point(12, 235);
            this.startFibonacciButton.Name = "startFibonacciButton";
            this.startFibonacciButton.Size = new System.Drawing.Size(153, 34);
            this.startFibonacciButton.TabIndex = 7;
            this.startFibonacciButton.Text = "Start(fibonacci)";
            this.startFibonacciButton.UseVisualStyleBackColor = true;
            this.startFibonacciButton.Click += new System.EventHandler(this.startFibonacciButton_Click);
            // 
            // stopPrimeButton
            // 
            this.stopPrimeButton.Location = new System.Drawing.Point(12, 149);
            this.stopPrimeButton.Name = "stopPrimeButton";
            this.stopPrimeButton.Size = new System.Drawing.Size(112, 34);
            this.stopPrimeButton.TabIndex = 8;
            this.stopPrimeButton.Text = "Stop(Prime)";
            this.stopPrimeButton.UseVisualStyleBackColor = true;
            this.stopPrimeButton.Click += new System.EventHandler(this.stopPrimeButton_Click);
            // 
            // stopFibonacciButton
            // 
            this.stopFibonacciButton.Location = new System.Drawing.Point(12, 375);
            this.stopFibonacciButton.Name = "stopFibonacciButton";
            this.stopFibonacciButton.Size = new System.Drawing.Size(153, 34);
            this.stopFibonacciButton.TabIndex = 9;
            this.stopFibonacciButton.Text = "Stop(fibonacci)";
            this.stopFibonacciButton.UseVisualStyleBackColor = true;
            this.stopFibonacciButton.Click += new System.EventHandler(this.stopFibonacciButton_Click);
            // 
            // pausePrimeNumbersButton
            // 
            this.pausePrimeNumbersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pausePrimeNumbersButton.Location = new System.Drawing.Point(156, 149);
            this.pausePrimeNumbersButton.Name = "pausePrimeNumbersButton";
            this.pausePrimeNumbersButton.Size = new System.Drawing.Size(112, 34);
            this.pausePrimeNumbersButton.TabIndex = 10;
            this.pausePrimeNumbersButton.Text = "Pause";
            this.pausePrimeNumbersButton.UseVisualStyleBackColor = true;
            this.pausePrimeNumbersButton.Click += new System.EventHandler(this.pausePrimeNumbersButton_Click);
            // 
            // resumePrimeNumbersButton
            // 
            this.resumePrimeNumbersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resumePrimeNumbersButton.Location = new System.Drawing.Point(299, 149);
            this.resumePrimeNumbersButton.Name = "resumePrimeNumbersButton";
            this.resumePrimeNumbersButton.Size = new System.Drawing.Size(112, 34);
            this.resumePrimeNumbersButton.TabIndex = 11;
            this.resumePrimeNumbersButton.Text = "Resume";
            this.resumePrimeNumbersButton.UseVisualStyleBackColor = true;
            this.resumePrimeNumbersButton.Click += new System.EventHandler(this.resumePrimeNumbersButton_Click);
            // 
            // restartPrimeButton
            // 
            this.restartPrimeButton.Location = new System.Drawing.Point(432, 149);
            this.restartPrimeButton.Name = "restartPrimeButton";
            this.restartPrimeButton.Size = new System.Drawing.Size(112, 34);
            this.restartPrimeButton.TabIndex = 12;
            this.restartPrimeButton.Text = "Restart";
            this.restartPrimeButton.UseVisualStyleBackColor = true;
            this.restartPrimeButton.Click += new System.EventHandler(this.restartPrimeButton_Click);
            // 
            // restartFibonacciButton
            // 
            this.restartFibonacciButton.Location = new System.Drawing.Point(445, 375);
            this.restartFibonacciButton.Name = "restartFibonacciButton";
            this.restartFibonacciButton.Size = new System.Drawing.Size(112, 34);
            this.restartFibonacciButton.TabIndex = 13;
            this.restartFibonacciButton.Text = "Restart";
            this.restartFibonacciButton.UseVisualStyleBackColor = true;
            this.restartFibonacciButton.Click += new System.EventHandler(this.restartFibonacciButton_Click);
            // 
            // pauseFibonacciButton
            // 
            this.pauseFibonacciButton.Location = new System.Drawing.Point(188, 375);
            this.pauseFibonacciButton.Name = "pauseFibonacciButton";
            this.pauseFibonacciButton.Size = new System.Drawing.Size(112, 34);
            this.pauseFibonacciButton.TabIndex = 14;
            this.pauseFibonacciButton.Text = "Pause";
            this.pauseFibonacciButton.UseVisualStyleBackColor = true;
            this.pauseFibonacciButton.Click += new System.EventHandler(this.pauseFibonacciButton_Click);
            // 
            // resumeFibonacciButton
            // 
            this.resumeFibonacciButton.Location = new System.Drawing.Point(314, 375);
            this.resumeFibonacciButton.Name = "resumeFibonacciButton";
            this.resumeFibonacciButton.Size = new System.Drawing.Size(112, 34);
            this.resumeFibonacciButton.TabIndex = 15;
            this.resumeFibonacciButton.Text = "Resume";
            this.resumeFibonacciButton.UseVisualStyleBackColor = true;
            this.resumeFibonacciButton.Click += new System.EventHandler(this.resumeFibonacciButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.resumeFibonacciButton);
            this.Controls.Add(this.pauseFibonacciButton);
            this.Controls.Add(this.restartFibonacciButton);
            this.Controls.Add(this.restartPrimeButton);
            this.Controls.Add(this.resumePrimeNumbersButton);
            this.Controls.Add(this.pausePrimeNumbersButton);
            this.Controls.Add(this.stopFibonacciButton);
            this.Controls.Add(this.stopPrimeButton);
            this.Controls.Add(this.startFibonacciButton);
            this.Controls.Add(this.fibonacciNumbersTextBox);
            this.Controls.Add(this.primeNumbersTextBox);
            this.Controls.Add(this.startPrimeNumbersButton);
            this.Controls.Add(this.upperBoundTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowerBoundTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowerBoundTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upperBoundTextBox;
        private System.Windows.Forms.Button startPrimeNumbersButton;
        private System.Windows.Forms.TextBox primeNumbersTextBox;
        private System.Windows.Forms.TextBox fibonacciNumbersTextBox;
        private System.Windows.Forms.Button startFibonacciButton;
        private System.Windows.Forms.Button stopPrimeButton;
        private System.Windows.Forms.Button stopFibonacciButton;
        private System.Windows.Forms.Button pausePrimeNumbersButton;
        private System.Windows.Forms.Button resumePrimeNumbersButton;
        private System.Windows.Forms.Button restartPrimeButton;
        private System.Windows.Forms.Button restartFibonacciButton;
        private System.Windows.Forms.Button pauseFibonacciButton;
        private System.Windows.Forms.Button resumeFibonacciButton;
    }
}

