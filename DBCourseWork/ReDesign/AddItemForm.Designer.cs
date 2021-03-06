﻿using System.ComponentModel;
using System.Windows.Forms;

namespace DBCourseWork.ReDesign
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.termTxt = new System.Windows.Forms.TextBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookRadio = new System.Windows.Forms.RadioButton();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.publishTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // termTxt
            // 
            this.termTxt.Location = new System.Drawing.Point(637, 87);
            this.termTxt.Name = "termTxt";
            this.termTxt.Size = new System.Drawing.Size(245, 20);
            this.termTxt.TabIndex = 42;
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(637, 13);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(245, 20);
            this.itemNameTxt.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Строк придатності (в днях):";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(715, 335);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(167, 23);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "Вийти в Меню";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(489, 335);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 23);
            this.addBtn.TabIndex = 37;
            this.addBtn.Text = "Додати Товар";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Назва товару:";
            // 
            // bookRadio
            // 
            this.bookRadio.AutoSize = true;
            this.bookRadio.Location = new System.Drawing.Point(6, 19);
            this.bookRadio.Name = "bookRadio";
            this.bookRadio.Size = new System.Drawing.Size(55, 17);
            this.bookRadio.TabIndex = 27;
            this.bookRadio.TabStop = true;
            this.bookRadio.Text = "Книга";
            this.bookRadio.UseVisualStyleBackColor = true;
            this.bookRadio.CheckedChanged += new System.EventHandler(this.bookRadio_CheckedChanged);
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Location = new System.Drawing.Point(6, 42);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(88, 17);
            this.otherRadio.TabIndex = 28;
            this.otherRadio.TabStop = true;
            this.otherRadio.Text = "Інший Товар";
            this.otherRadio.UseVisualStyleBackColor = true;
            this.otherRadio.CheckedChanged += new System.EventHandler(this.otherRadio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Оберіть тип товару:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bookRadio);
            this.groupBox1.Controls.Add(this.otherRadio);
            this.groupBox1.Location = new System.Drawing.Point(631, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 70);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-138, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Автор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Назва Книги:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Рік Видання:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "ISBN:";
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(631, 204);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(249, 20);
            this.authorTxt.TabIndex = 56;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(631, 233);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(249, 20);
            this.nameTxt.TabIndex = 57;
            // 
            // publishTxt
            // 
            this.publishTxt.Location = new System.Drawing.Point(631, 263);
            this.publishTxt.Name = "publishTxt";
            this.publishTxt.Size = new System.Drawing.Size(249, 20);
            this.publishTxt.TabIndex = 58;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(631, 294);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(249, 20);
            this.isbnTxt.TabIndex = 59;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(637, 49);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(245, 20);
            this.priceTxt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ціна товару:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(480, 478);
            this.dataGridView1.TabIndex = 61;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.publishTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.termTxt);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати Товар";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox termTxt;
        private TextBox itemNameTxt;
        private Label label3;
        private Button exitBtn;
        private Button addBtn;
        private Label label1;
        private RadioButton bookRadio;
        private RadioButton otherRadio;
        private Label label4;
        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox authorTxt;
        private TextBox nameTxt;
        private TextBox publishTxt;
        private TextBox isbnTxt;
        private TextBox priceTxt;
        private Label label2;
        private DataGridView dataGridView1;
    }
}