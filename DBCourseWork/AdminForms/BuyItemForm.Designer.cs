﻿using System.ComponentModel;
using System.Windows.Forms;

namespace DBCourseWork.AdminForms
{
    partial class BuyItemForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qunatityTxt = new System.Windows.Forms.TextBox();
            this.itemsCombobox = new System.Windows.Forms.ComboBox();
            this.contrCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(255, 138);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(167, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Вийти в Меню";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(29, 138);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(167, 23);
            this.buyBtn.TabIndex = 12;
            this.buyBtn.Text = "Закупити";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ім\'я Контрагента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назва Товару:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кількість:";
            // 
            // qunatityTxt
            // 
            this.qunatityTxt.Location = new System.Drawing.Point(128, 90);
            this.qunatityTxt.Name = "qunatityTxt";
            this.qunatityTxt.Size = new System.Drawing.Size(294, 20);
            this.qunatityTxt.TabIndex = 14;
            // 
            // itemsCombobox
            // 
            this.itemsCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemsCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemsCombobox.FormattingEnabled = true;
            this.itemsCombobox.Location = new System.Drawing.Point(128, 15);
            this.itemsCombobox.Name = "itemsCombobox";
            this.itemsCombobox.Size = new System.Drawing.Size(294, 21);
            this.itemsCombobox.TabIndex = 16;
            // 
            // contrCombobox
            // 
            this.contrCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contrCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contrCombobox.FormattingEnabled = true;
            this.contrCombobox.Location = new System.Drawing.Point(128, 52);
            this.contrCombobox.Name = "contrCombobox";
            this.contrCombobox.Size = new System.Drawing.Size(294, 21);
            this.contrCombobox.TabIndex = 17;
            // 
            // BuyItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 177);
            this.Controls.Add(this.contrCombobox);
            this.Controls.Add(this.itemsCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qunatityTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuyItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закупка Товару";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBtn;
        private Button buyBtn;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox qunatityTxt;
        private ComboBox itemsCombobox;
        private ComboBox contrCombobox;
    }
}