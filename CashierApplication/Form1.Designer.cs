
namespace CashierApplication
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
            this.itemInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.percentInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amountOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentOutput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // itemInput
            // 
            this.itemInput.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemInput.Location = new System.Drawing.Point(106, 35);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(461, 27);
            this.itemInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(215, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discount:";
            // 
            // percentInput
            // 
            this.percentInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.percentInput.Location = new System.Drawing.Point(305, 68);
            this.percentInput.Name = "percentInput";
            this.percentInput.Size = new System.Drawing.Size(49, 27);
            this.percentInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(381, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceInput.Location = new System.Drawing.Point(442, 68);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(125, 27);
            this.priceInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityInput.Location = new System.Drawing.Point(106, 68);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(103, 27);
            this.quantityInput.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(353, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 27);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "%";
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.computeButton.Location = new System.Drawing.Point(468, 101);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(99, 32);
            this.computeButton.TabIndex = 5;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Amount:";
            // 
            // amountOutput
            // 
            this.amountOutput.BackColor = System.Drawing.Color.Transparent;
            this.amountOutput.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.amountOutput.Location = new System.Drawing.Point(142, 108);
            this.amountOutput.MinimumSize = new System.Drawing.Size(250, 25);
            this.amountOutput.Name = "amountOutput";
            this.amountOutput.Size = new System.Drawing.Size(250, 25);
            this.amountOutput.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(8, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment Recieved:";
            // 
            // paymentInput
            // 
            this.paymentInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentInput.Location = new System.Drawing.Point(176, 164);
            this.paymentInput.Name = "paymentInput";
            this.paymentInput.Size = new System.Drawing.Size(125, 27);
            this.paymentInput.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(307, 162);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(85, 32);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(93, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Change:";
            // 
            // paymentOutput
            // 
            this.paymentOutput.BackColor = System.Drawing.Color.Transparent;
            this.paymentOutput.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.paymentOutput.Location = new System.Drawing.Point(175, 201);
            this.paymentOutput.MinimumSize = new System.Drawing.Size(250, 25);
            this.paymentOutput.Name = "paymentOutput";
            this.paymentOutput.Size = new System.Drawing.Size(250, 25);
            this.paymentOutput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutButton,
            this.exitButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutButton
            // 
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 22);
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 22);
            this.exitButton.Text = "Exit Application";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(580, 318);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.paymentOutput);
            this.Controls.Add(this.amountOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.percentInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Purchase Discounted Item";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox percentInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label amountOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paymentInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label paymentOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
    }
}

