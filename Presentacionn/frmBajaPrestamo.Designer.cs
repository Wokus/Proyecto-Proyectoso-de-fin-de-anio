﻿namespace Presentacionn
{
    partial class frmBajaPrestamo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdPrestamoBaja = new System.Windows.Forms.Label();
            this.txtIdPrestamoBaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.Location = new System.Drawing.Point(170, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 55);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdPrestamoBaja
            // 
            this.lblIdPrestamoBaja.AutoSize = true;
            this.lblIdPrestamoBaja.Location = new System.Drawing.Point(125, 150);
            this.lblIdPrestamoBaja.Name = "lblIdPrestamoBaja";
            this.lblIdPrestamoBaja.Size = new System.Drawing.Size(63, 13);
            this.lblIdPrestamoBaja.TabIndex = 2;
            this.lblIdPrestamoBaja.Text = "Id Prestamo";
            // 
            // txtIdPrestamoBaja
            // 
            this.txtIdPrestamoBaja.Location = new System.Drawing.Point(194, 143);
            this.txtIdPrestamoBaja.Name = "txtIdPrestamoBaja";
            this.txtIdPrestamoBaja.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamoBaja.TabIndex = 1;
            // 
            // frmBajaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.lblIdPrestamoBaja);
            this.Controls.Add(this.txtIdPrestamoBaja);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmBajaPrestamo";
            this.Text = "frmBajaPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdPrestamoBaja;
        private System.Windows.Forms.TextBox txtIdPrestamoBaja;
    }
}