namespace Winkelen
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
            calculateTotal = new Button();
            label1 = new Label();
            totalPrice = new TextBox();
            koopPs5 = new Button();
            koopElden = new Button();
            koopSponge = new Button();
            koopSpiderman = new Button();
            koopController = new Button();
            labelPs5Amount = new Label();
            labelCtrlAmount = new Label();
            labelSpongeAmount = new Label();
            labelSpiderAmount = new Label();
            labelEldenAmount = new Label();
            SuspendLayout();
            // 
            // calculateTotal
            // 
            calculateTotal.Location = new Point(270, 73);
            calculateTotal.Margin = new Padding(3, 4, 3, 4);
            calculateTotal.Name = "calculateTotal";
            calculateTotal.Size = new Size(165, 31);
            calculateTotal.TabIndex = 0;
            calculateTotal.Text = "bereken totaal";
            calculateTotal.UseVisualStyleBackColor = true;
            calculateTotal.Click += calculateTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "totaal:";
            // 
            // totalPrice
            // 
            totalPrice.Enabled = false;
            totalPrice.Location = new Point(128, 73);
            totalPrice.Margin = new Padding(3, 4, 3, 4);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(114, 27);
            totalPrice.TabIndex = 2;
            totalPrice.TextChanged += totalPrice_TextChanged;
            // 
            // koopPs5
            // 
            koopPs5.Location = new Point(80, 312);
            koopPs5.Margin = new Padding(3, 4, 3, 4);
            koopPs5.Name = "koopPs5";
            koopPs5.Size = new Size(94, 101);
            koopPs5.TabIndex = 3;
            koopPs5.Text = "Ps5";
            koopPs5.UseVisualStyleBackColor = true;
            koopPs5.Click += koopPs5_Click;
            // 
            // koopElden
            // 
            koopElden.Location = new Point(545, 312);
            koopElden.Margin = new Padding(3, 4, 3, 4);
            koopElden.Name = "koopElden";
            koopElden.Size = new Size(94, 101);
            koopElden.TabIndex = 4;
            koopElden.Text = "Elden ring";
            koopElden.UseVisualStyleBackColor = true;
            koopElden.Click += koopElden_Click;
            // 
            // koopSponge
            // 
            koopSponge.Location = new Point(341, 312);
            koopSponge.Margin = new Padding(3, 4, 3, 4);
            koopSponge.Name = "koopSponge";
            koopSponge.Size = new Size(94, 101);
            koopSponge.TabIndex = 5;
            koopSponge.Text = "Sponge bob";
            koopSponge.UseVisualStyleBackColor = true;
            koopSponge.Click += koopSponge_Click;
            // 
            // koopSpiderman
            // 
            koopSpiderman.Location = new Point(445, 312);
            koopSpiderman.Margin = new Padding(3, 4, 3, 4);
            koopSpiderman.Name = "koopSpiderman";
            koopSpiderman.Size = new Size(94, 101);
            koopSpiderman.TabIndex = 6;
            koopSpiderman.Text = "Spiderman";
            koopSpiderman.UseVisualStyleBackColor = true;
            koopSpiderman.Click += koopSpiderman_Click;
            // 
            // koopController
            // 
            koopController.Location = new Point(181, 312);
            koopController.Margin = new Padding(3, 4, 3, 4);
            koopController.Name = "koopController";
            koopController.Size = new Size(94, 101);
            koopController.TabIndex = 7;
            koopController.Text = "Dualshock 5";
            koopController.UseVisualStyleBackColor = true;
            koopController.Click += koopController_Click;
            // 
            // labelPs5Amount
            // 
            labelPs5Amount.AutoSize = true;
            labelPs5Amount.Location = new Point(80, 433);
            labelPs5Amount.Name = "labelPs5Amount";
            labelPs5Amount.Size = new Size(17, 20);
            labelPs5Amount.TabIndex = 8;
            labelPs5Amount.Text = "0";
            // 
            // labelCtrlAmount
            // 
            labelCtrlAmount.AutoSize = true;
            labelCtrlAmount.Location = new Point(181, 433);
            labelCtrlAmount.Name = "labelCtrlAmount";
            labelCtrlAmount.Size = new Size(17, 20);
            labelCtrlAmount.TabIndex = 9;
            labelCtrlAmount.Text = "0";
            // 
            // labelSpongeAmount
            // 
            labelSpongeAmount.AutoSize = true;
            labelSpongeAmount.Location = new Point(341, 433);
            labelSpongeAmount.Name = "labelSpongeAmount";
            labelSpongeAmount.Size = new Size(17, 20);
            labelSpongeAmount.TabIndex = 10;
            labelSpongeAmount.Text = "0";
            // 
            // labelSpiderAmount
            // 
            labelSpiderAmount.AutoSize = true;
            labelSpiderAmount.Location = new Point(445, 433);
            labelSpiderAmount.Name = "labelSpiderAmount";
            labelSpiderAmount.Size = new Size(17, 20);
            labelSpiderAmount.TabIndex = 11;
            labelSpiderAmount.Text = "0";
            // 
            // labelEldenAmount
            // 
            labelEldenAmount.AutoSize = true;
            labelEldenAmount.Location = new Point(545, 433);
            labelEldenAmount.Name = "labelEldenAmount";
            labelEldenAmount.Size = new Size(17, 20);
            labelEldenAmount.TabIndex = 12;
            labelEldenAmount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelEldenAmount);
            Controls.Add(labelSpiderAmount);
            Controls.Add(labelSpongeAmount);
            Controls.Add(labelCtrlAmount);
            Controls.Add(labelPs5Amount);
            Controls.Add(koopController);
            Controls.Add(koopSpiderman);
            Controls.Add(koopSponge);
            Controls.Add(koopElden);
            Controls.Add(koopPs5);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Controls.Add(calculateTotal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateTotal;
        private Label label1;
        private TextBox totalPrice;
        private Button koopPs5;
        private Button koopElden;
        private Button koopSponge;
        private Button koopSpiderman;
        private Button koopController;
        private Label labelPs5Amount;
        private Label labelCtrlAmount;
        private Label labelSpongeAmount;
        private Label labelSpiderAmount;
        private Label labelEldenAmount;
    }
}
