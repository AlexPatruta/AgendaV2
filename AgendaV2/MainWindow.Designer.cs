namespace AgendaV2
{
    partial class MainWindow
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
            this.indicateFilter = new System.Windows.Forms.Label();
            this.visualizeAgenda = new System.Windows.Forms.GroupBox();
            this.applyFilter = new System.Windows.Forms.Button();
            this.inputFilter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visualizeAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // indicateFilter
            // 
            this.indicateFilter.Location = new System.Drawing.Point(6, 16);
            this.indicateFilter.Name = "indicateFilter";
            this.indicateFilter.Size = new System.Drawing.Size(42, 23);
            this.indicateFilter.TabIndex = 0;
            this.indicateFilter.Text = "Filter";
            this.indicateFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.indicateFilter.UseCompatibleTextRendering = true;
            // 
            // visualizeAgenda
            // 
            this.visualizeAgenda.Controls.Add(this.dataGridView1);
            this.visualizeAgenda.Controls.Add(this.applyFilter);
            this.visualizeAgenda.Controls.Add(this.inputFilter);
            this.visualizeAgenda.Controls.Add(this.indicateFilter);
            this.visualizeAgenda.Location = new System.Drawing.Point(8, 8);
            this.visualizeAgenda.Name = "visualizeAgenda";
            this.visualizeAgenda.Size = new System.Drawing.Size(320, 344);
            this.visualizeAgenda.TabIndex = 1;
            this.visualizeAgenda.TabStop = false;
            this.visualizeAgenda.Text = "People List";
            // 
            // applyFilter
            // 
            this.applyFilter.FlatAppearance.BorderSize = 0;
            this.applyFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.applyFilter.Location = new System.Drawing.Point(238, 16);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(76, 23);
            this.applyFilter.TabIndex = 2;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = true;
            // 
            // inputFilter
            // 
            this.inputFilter.AccessibleDescription = "Input filter in the agenda";
            this.inputFilter.AccessibleName = "Filter Input text box";
            this.inputFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.inputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilter.Location = new System.Drawing.Point(54, 16);
            this.inputFilter.Name = "inputFilter";
            this.inputFilter.Size = new System.Drawing.Size(178, 19);
            this.inputFilter.TabIndex = 1;
            this.inputFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(308, 297);
            this.dataGridView1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.visualizeAgenda);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.visualizeAgenda.ResumeLayout(false);
            this.visualizeAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label indicateFilter;
        private System.Windows.Forms.GroupBox visualizeAgenda;
        private System.Windows.Forms.TextBox inputFilter;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

