﻿namespace Tarea1P2.Forms
{
    partial class FrmCircle
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSourceTitle = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtInRadius = new System.Windows.Forms.TextBox();
            this.grbProcessTitle = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.trbVel = new System.Windows.Forms.TrackBar();
            this.dgvPoints = new System.Windows.Forms.DataGridView();
            this.lblPointsTitle = new System.Windows.Forms.Label();
            this.grbVel = new System.Windows.Forms.GroupBox();
            this.lblVelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbSourceTitle.SuspendLayout();
            this.grbProcessTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).BeginInit();
            this.grbVel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(430, 26);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(631, 518);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(62, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Circulo Bresenham";
            // 
            // grbSourceTitle
            // 
            this.grbSourceTitle.Controls.Add(this.lblRadius);
            this.grbSourceTitle.Controls.Add(this.txtInRadius);
            this.grbSourceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSourceTitle.Location = new System.Drawing.Point(83, 66);
            this.grbSourceTitle.Name = "grbSourceTitle";
            this.grbSourceTitle.Size = new System.Drawing.Size(241, 79);
            this.grbSourceTitle.TabIndex = 2;
            this.grbSourceTitle.TabStop = false;
            this.grbSourceTitle.Text = "Entrada";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 37);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(63, 20);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radio:";
            // 
            // txtInRadius
            // 
            this.txtInRadius.Location = new System.Drawing.Point(81, 34);
            this.txtInRadius.Name = "txtInRadius";
            this.txtInRadius.Size = new System.Drawing.Size(137, 27);
            this.txtInRadius.TabIndex = 0;
            // 
            // grbProcessTitle
            // 
            this.grbProcessTitle.Controls.Add(this.btnReset);
            this.grbProcessTitle.Controls.Add(this.btnCalculate);
            this.grbProcessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcessTitle.Location = new System.Drawing.Point(12, 151);
            this.grbProcessTitle.Name = "grbProcessTitle";
            this.grbProcessTitle.Size = new System.Drawing.Size(139, 118);
            this.grbProcessTitle.TabIndex = 4;
            this.grbProcessTitle.TabStop = false;
            this.grbProcessTitle.Text = "Proceso";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(16, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(16, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 36);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // trbVel
            // 
            this.trbVel.Location = new System.Drawing.Point(17, 36);
            this.trbVel.Minimum = 5;
            this.trbVel.Name = "trbVel";
            this.trbVel.Size = new System.Drawing.Size(202, 56);
            this.trbVel.TabIndex = 2;
            this.trbVel.Value = 5;
            this.trbVel.Scroll += new System.EventHandler(this.velocityScroll);
            // 
            // dgvPoints
            // 
            this.dgvPoints.AllowUserToAddRows = false;
            this.dgvPoints.AllowUserToDeleteRows = false;
            this.dgvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoints.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPoints.Location = new System.Drawing.Point(12, 335);
            this.dgvPoints.Name = "dgvPoints";
            this.dgvPoints.ReadOnly = true;
            this.dgvPoints.RowHeadersWidth = 51;
            this.dgvPoints.RowTemplate.Height = 24;
            this.dgvPoints.Size = new System.Drawing.Size(395, 209);
            this.dgvPoints.TabIndex = 5;
            // 
            // lblPointsTitle
            // 
            this.lblPointsTitle.AutoSize = true;
            this.lblPointsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTitle.Location = new System.Drawing.Point(12, 295);
            this.lblPointsTitle.Name = "lblPointsTitle";
            this.lblPointsTitle.Size = new System.Drawing.Size(187, 25);
            this.lblPointsTitle.TabIndex = 6;
            this.lblPointsTitle.Text = "Puntos generados";
            // 
            // grbVel
            // 
            this.grbVel.Controls.Add(this.lblVelValue);
            this.grbVel.Controls.Add(this.trbVel);
            this.grbVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVel.Location = new System.Drawing.Point(170, 151);
            this.grbVel.Name = "grbVel";
            this.grbVel.Size = new System.Drawing.Size(237, 118);
            this.grbVel.TabIndex = 5;
            this.grbVel.TabStop = false;
            this.grbVel.Text = "Retraso";
            // 
            // lblVelValue
            // 
            this.lblVelValue.AutoSize = true;
            this.lblVelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelValue.Location = new System.Drawing.Point(84, 84);
            this.lblVelValue.Name = "lblVelValue";
            this.lblVelValue.Size = new System.Drawing.Size(46, 20);
            this.lblVelValue.TabIndex = 3;
            this.lblVelValue.Text = "5 ms";
            // 
            // FrmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.grbVel);
            this.Controls.Add(this.lblPointsTitle);
            this.Controls.Add(this.dgvPoints);
            this.Controls.Add(this.grbProcessTitle);
            this.Controls.Add(this.grbSourceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCircle";
            this.Text = "FrmDDA";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbSourceTitle.ResumeLayout(false);
            this.grbSourceTitle.PerformLayout();
            this.grbProcessTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).EndInit();
            this.grbVel.ResumeLayout(false);
            this.grbVel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSourceTitle;
        private System.Windows.Forms.TextBox txtInRadius;
        private System.Windows.Forms.GroupBox grbProcessTitle;
        private System.Windows.Forms.TrackBar trbVel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvPoints;
        private System.Windows.Forms.Label lblPointsTitle;
        private System.Windows.Forms.GroupBox grbVel;
        private System.Windows.Forms.Label lblVelValue;
        private System.Windows.Forms.Label lblRadius;
    }
}