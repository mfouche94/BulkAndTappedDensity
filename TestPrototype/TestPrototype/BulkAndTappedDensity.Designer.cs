﻿
namespace TestPrototype
{
    partial class BulkAndTappedDensity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkAndTappedDensity));
            this.textBoxBulkDensity = new System.Windows.Forms.TextBox();
            this.labelBulkDensity = new System.Windows.Forms.Label();
            this.labelTappedDensity = new System.Windows.Forms.Label();
            this.textBoxTappedDensity = new System.Windows.Forms.TextBox();
            this.btnCalculateParameters = new System.Windows.Forms.Button();
            this.LabelInterParticlePorosity = new System.Windows.Forms.Label();
            this.labelHausnerRatio = new System.Windows.Forms.Label();
            this.textBoxInterParticlePorosity = new System.Windows.Forms.TextBox();
            this.textBoxHausnerRatio = new System.Windows.Forms.TextBox();
            this.labelCarrIndex = new System.Windows.Forms.Label();
            this.textBoxCarrIndex = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveCSV = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBulkDensity
            // 
            this.textBoxBulkDensity.Location = new System.Drawing.Point(133, 36);
            this.textBoxBulkDensity.Name = "textBoxBulkDensity";
            this.textBoxBulkDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxBulkDensity.TabIndex = 0;
            // 
            // labelBulkDensity
            // 
            this.labelBulkDensity.AutoSize = true;
            this.labelBulkDensity.Location = new System.Drawing.Point(45, 39);
            this.labelBulkDensity.Name = "labelBulkDensity";
            this.labelBulkDensity.Size = new System.Drawing.Size(69, 13);
            this.labelBulkDensity.TabIndex = 1;
            this.labelBulkDensity.Text = "Bulk Density:";
            this.labelBulkDensity.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTappedDensity
            // 
            this.labelTappedDensity.AutoSize = true;
            this.labelTappedDensity.Location = new System.Drawing.Point(45, 77);
            this.labelTappedDensity.Name = "labelTappedDensity";
            this.labelTappedDensity.Size = new System.Drawing.Size(85, 13);
            this.labelTappedDensity.TabIndex = 2;
            this.labelTappedDensity.Text = "Tapped Density:";
            // 
            // textBoxTappedDensity
            // 
            this.textBoxTappedDensity.Location = new System.Drawing.Point(133, 74);
            this.textBoxTappedDensity.Name = "textBoxTappedDensity";
            this.textBoxTappedDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxTappedDensity.TabIndex = 3;
            // 
            // btnCalculateParameters
            // 
            this.btnCalculateParameters.Location = new System.Drawing.Point(48, 124);
            this.btnCalculateParameters.Name = "btnCalculateParameters";
            this.btnCalculateParameters.Size = new System.Drawing.Size(123, 23);
            this.btnCalculateParameters.TabIndex = 4;
            this.btnCalculateParameters.Text = "Calculate Paramaters";
            this.btnCalculateParameters.UseVisualStyleBackColor = true;
            this.btnCalculateParameters.Click += new System.EventHandler(this.btnCalculateParameters_Click);
            // 
            // LabelInterParticlePorosity
            // 
            this.LabelInterParticlePorosity.AutoSize = true;
            this.LabelInterParticlePorosity.Location = new System.Drawing.Point(45, 183);
            this.LabelInterParticlePorosity.Name = "LabelInterParticlePorosity";
            this.LabelInterParticlePorosity.Size = new System.Drawing.Size(109, 13);
            this.LabelInterParticlePorosity.TabIndex = 5;
            this.LabelInterParticlePorosity.Text = "Inter-Particle Porosity:";
            // 
            // labelHausnerRatio
            // 
            this.labelHausnerRatio.AutoSize = true;
            this.labelHausnerRatio.Location = new System.Drawing.Point(45, 217);
            this.labelHausnerRatio.Name = "labelHausnerRatio";
            this.labelHausnerRatio.Size = new System.Drawing.Size(78, 13);
            this.labelHausnerRatio.TabIndex = 6;
            this.labelHausnerRatio.Text = "Hausner Ratio:";
            this.labelHausnerRatio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxInterParticlePorosity
            // 
            this.textBoxInterParticlePorosity.Enabled = false;
            this.textBoxInterParticlePorosity.Location = new System.Drawing.Point(184, 180);
            this.textBoxInterParticlePorosity.Name = "textBoxInterParticlePorosity";
            this.textBoxInterParticlePorosity.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterParticlePorosity.TabIndex = 7;
            // 
            // textBoxHausnerRatio
            // 
            this.textBoxHausnerRatio.Enabled = false;
            this.textBoxHausnerRatio.Location = new System.Drawing.Point(184, 214);
            this.textBoxHausnerRatio.Name = "textBoxHausnerRatio";
            this.textBoxHausnerRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxHausnerRatio.TabIndex = 8;
            // 
            // labelCarrIndex
            // 
            this.labelCarrIndex.AutoSize = true;
            this.labelCarrIndex.Location = new System.Drawing.Point(45, 253);
            this.labelCarrIndex.Name = "labelCarrIndex";
            this.labelCarrIndex.Size = new System.Drawing.Size(58, 13);
            this.labelCarrIndex.TabIndex = 9;
            this.labelCarrIndex.Text = "Carr Index:";
            // 
            // textBoxCarrIndex
            // 
            this.textBoxCarrIndex.Enabled = false;
            this.textBoxCarrIndex.Location = new System.Drawing.Point(184, 250);
            this.textBoxCarrIndex.Name = "textBoxCarrIndex";
            this.textBoxCarrIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarrIndex.TabIndex = 10;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(305, 134);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 243);
            this.dataGridView1.TabIndex = 12;
            // 
            // saveCSV
            // 
            this.saveCSV.Location = new System.Drawing.Point(504, 593);
            this.saveCSV.Name = "saveCSV";
            this.saveCSV.Size = new System.Drawing.Size(110, 23);
            this.saveCSV.TabIndex = 13;
            this.saveCSV.Text = "Export to CSV";
            this.saveCSV.UseVisualStyleBackColor = true;
            this.saveCSV.Click += new System.EventHandler(this.saveCSV_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(48, 593);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(137, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear Selected Row";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // BulkAndTappedDensity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 658);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.saveCSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxCarrIndex);
            this.Controls.Add(this.labelCarrIndex);
            this.Controls.Add(this.textBoxHausnerRatio);
            this.Controls.Add(this.textBoxInterParticlePorosity);
            this.Controls.Add(this.labelHausnerRatio);
            this.Controls.Add(this.LabelInterParticlePorosity);
            this.Controls.Add(this.btnCalculateParameters);
            this.Controls.Add(this.textBoxTappedDensity);
            this.Controls.Add(this.labelTappedDensity);
            this.Controls.Add(this.labelBulkDensity);
            this.Controls.Add(this.textBoxBulkDensity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BulkAndTappedDensity";
            this.Text = "Bulk and Tapped Density";
            this.Load += new System.EventHandler(this.BulkAndTappedDensity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBulkDensity;
        private System.Windows.Forms.Label labelBulkDensity;
        private System.Windows.Forms.Label labelTappedDensity;
        private System.Windows.Forms.TextBox textBoxTappedDensity;
        private System.Windows.Forms.Button btnCalculateParameters;
        private System.Windows.Forms.Label LabelInterParticlePorosity;
        private System.Windows.Forms.Label labelHausnerRatio;
        private System.Windows.Forms.TextBox textBoxInterParticlePorosity;
        private System.Windows.Forms.TextBox textBoxHausnerRatio;
        private System.Windows.Forms.Label labelCarrIndex;
        private System.Windows.Forms.TextBox textBoxCarrIndex;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveCSV;
        private System.Windows.Forms.Button buttonClear;
    }
}

