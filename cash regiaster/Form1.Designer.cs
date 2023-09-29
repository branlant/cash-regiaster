namespace cash_regiaster
{
    partial class Form1
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
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.BurgerInput = new System.Windows.Forms.TextBox();
            this.BurgerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.DrinkLabel = new System.Windows.Forms.Label();
            this.FriesLabel = new System.Windows.Forms.Label();
            this.DrinkInput = new System.Windows.Forms.TextBox();
            this.FriesInput = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(262, 367);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(19, 16);
            this.totalOutput.TabIndex = 19;
            this.totalOutput.Text = "---";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(145, 367);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(72, 16);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total Price";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(262, 310);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(19, 16);
            this.taxOutput.TabIndex = 17;
            this.taxOutput.Text = "---";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(139, 310);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(78, 16);
            this.taxLabel.TabIndex = 16;
            this.taxLabel.Text = "Tax Amount";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Location = new System.Drawing.Point(262, 254);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(19, 16);
            this.subTotalOutput.TabIndex = 15;
            this.subTotalOutput.Text = "---";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(161, 254);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(56, 16);
            this.subtotalLabel.TabIndex = 14;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(234, 217);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // BurgerInput
            // 
            this.BurgerInput.Location = new System.Drawing.Point(226, 84);
            this.BurgerInput.Name = "BurgerInput";
            this.BurgerInput.Size = new System.Drawing.Size(100, 22);
            this.BurgerInput.TabIndex = 12;
            // 
            // BurgerLabel
            // 
            this.BurgerLabel.AutoSize = true;
            this.BurgerLabel.Location = new System.Drawing.Point(138, 90);
            this.BurgerLabel.Name = "BurgerLabel";
            this.BurgerLabel.Size = new System.Drawing.Size(79, 16);
            this.BurgerLabel.TabIndex = 11;
            this.BurgerLabel.Text = "FunniBurger";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(231, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 16);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "McFun Burger";
            // 
            // DrinkLabel
            // 
            this.DrinkLabel.AutoSize = true;
            this.DrinkLabel.Location = new System.Drawing.Point(167, 138);
            this.DrinkLabel.Name = "DrinkLabel";
            this.DrinkLabel.Size = new System.Drawing.Size(38, 16);
            this.DrinkLabel.TabIndex = 20;
            this.DrinkLabel.Text = "Drink";
            // 
            // FriesLabel
            // 
            this.FriesLabel.AutoSize = true;
            this.FriesLabel.Location = new System.Drawing.Point(137, 181);
            this.FriesLabel.Name = "FriesLabel";
            this.FriesLabel.Size = new System.Drawing.Size(69, 16);
            this.FriesLabel.TabIndex = 21;
            this.FriesLabel.Text = "FunniFries";
            // 
            // DrinkInput
            // 
            this.DrinkInput.Location = new System.Drawing.Point(226, 132);
            this.DrinkInput.Name = "DrinkInput";
            this.DrinkInput.Size = new System.Drawing.Size(100, 22);
            this.DrinkInput.TabIndex = 22;
            // 
            // FriesInput
            // 
            this.FriesInput.Location = new System.Drawing.Point(226, 178);
            this.FriesInput.Name = "FriesInput";
            this.FriesInput.Size = new System.Drawing.Size(100, 22);
            this.FriesInput.TabIndex = 23;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Location = new System.Drawing.Point(458, 56);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(44, 16);
            this.receiptLabel.TabIndex = 24;
            this.receiptLabel.Text = "label1";
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(234, 403);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(75, 23);
            this.receiptButton.TabIndex = 25;
            this.receiptButton.Text = "Calculate";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.FriesInput);
            this.Controls.Add(this.DrinkInput);
            this.Controls.Add(this.FriesLabel);
            this.Controls.Add(this.DrinkLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.BurgerInput);
            this.Controls.Add(this.BurgerLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox BurgerInput;
        private System.Windows.Forms.Label BurgerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label DrinkLabel;
        private System.Windows.Forms.Label FriesLabel;
        private System.Windows.Forms.TextBox DrinkInput;
        private System.Windows.Forms.TextBox FriesInput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button receiptButton;
    }
}

