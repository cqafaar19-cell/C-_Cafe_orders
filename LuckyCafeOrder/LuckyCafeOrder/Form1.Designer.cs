namespace LuckyCafeOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxStudentMember = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radbtnJuice = new System.Windows.Forms.RadioButton();
            this.radbtnCoffee = new System.Windows.Forms.RadioButton();
            this.radbtnTea = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbLuckymessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxStudentMember);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxStudentMember
            // 
            this.checkBoxStudentMember.AutoSize = true;
            this.checkBoxStudentMember.Location = new System.Drawing.Point(263, 330);
            this.checkBoxStudentMember.Name = "checkBoxStudentMember";
            this.checkBoxStudentMember.Size = new System.Drawing.Size(200, 24);
            this.checkBoxStudentMember.TabIndex = 6;
            this.checkBoxStudentMember.Text = "Student member (10%)";
            this.checkBoxStudentMember.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(104, 328);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 26);
            this.txtQuantity.TabIndex = 5;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(25, 328);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(76, 20);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Quantity: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.radbtnJuice);
            this.groupBox2.Controls.Add(this.radbtnCoffee);
            this.groupBox2.Controls.Add(this.radbtnTea);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drink Type";
            // 
            // radbtnJuice
            // 
            this.radbtnJuice.AutoSize = true;
            this.radbtnJuice.Location = new System.Drawing.Point(28, 101);
            this.radbtnJuice.Name = "radbtnJuice";
            this.radbtnJuice.Size = new System.Drawing.Size(124, 26);
            this.radbtnJuice.TabIndex = 0;
            this.radbtnJuice.TabStop = true;
            this.radbtnJuice.Text = "Juice (3$)";
            this.radbtnJuice.UseVisualStyleBackColor = true;
            // 
            // radbtnCoffee
            // 
            this.radbtnCoffee.AutoSize = true;
            this.radbtnCoffee.Location = new System.Drawing.Point(28, 69);
            this.radbtnCoffee.Name = "radbtnCoffee";
            this.radbtnCoffee.Size = new System.Drawing.Size(136, 26);
            this.radbtnCoffee.TabIndex = 0;
            this.radbtnCoffee.TabStop = true;
            this.radbtnCoffee.Text = "Coffee (2$)";
            this.radbtnCoffee.UseVisualStyleBackColor = true;
            // 
            // radbtnTea
            // 
            this.radbtnTea.AutoSize = true;
            this.radbtnTea.Location = new System.Drawing.Point(28, 37);
            this.radbtnTea.Name = "radbtnTea";
            this.radbtnTea.Size = new System.Drawing.Size(112, 26);
            this.radbtnTea.TabIndex = 0;
            this.radbtnTea.TabStop = true;
            this.radbtnTea.Text = "Tea (1$)";
            this.radbtnTea.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 120);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(499, 26);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costumer name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costumer information";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luck Cafe Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(580, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(650, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order list: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 20;
            this.listBoxOrder.Location = new System.Drawing.Point(585, 81);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(676, 364);
            this.listBoxOrder.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 463);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate order";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save to files";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(617, 463);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(159, 40);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load from File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(946, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalPrice.Location = new System.Drawing.Point(26, 529);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(1150, 41);
            this.lbTotalPrice.TabIndex = 13;
            // 
            // lbLuckymessage
            // 
            this.lbLuckymessage.BackColor = System.Drawing.SystemColors.Control;
            this.lbLuckymessage.Location = new System.Drawing.Point(26, 570);
            this.lbLuckymessage.Name = "lbLuckymessage";
            this.lbLuckymessage.Size = new System.Drawing.Size(1150, 41);
            this.lbLuckymessage.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 637);
            this.Controls.Add(this.lbLuckymessage);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radbtnJuice;
        private System.Windows.Forms.RadioButton radbtnCoffee;
        private System.Windows.Forms.RadioButton radbtnTea;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.CheckBox checkBoxStudentMember;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbLuckymessage;
    }
}

