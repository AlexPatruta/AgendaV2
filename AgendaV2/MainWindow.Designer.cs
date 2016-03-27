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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.indicateFilter = new System.Windows.Forms.Label();
            this.visualizeAgenda = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.applyFilter = new System.Windows.Forms.Button();
            this.inputFilter = new System.Windows.Forms.TextBox();
            this.updateAgendaTools = new System.Windows.Forms.GroupBox();
            this.nameTag = new System.Windows.Forms.Label();
            this.telephoneTag = new System.Windows.Forms.Label();
            this.emailTag = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.telephoneInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.addEntry = new System.Windows.Forms.Button();
            this.removeEntry = new System.Windows.Forms.Button();
            this.updateEntry = new System.Windows.Forms.Button();
            this.nameErrorDisplay = new System.Windows.Forms.Label();
            this.telErrorDisplay = new System.Windows.Forms.Label();
            this.emailErrorDisplay = new System.Windows.Forms.Label();
            this.visualizeAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updateAgendaTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // indicateFilter
            // 
            this.indicateFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicateFilter.AutoSize = true;
            this.indicateFilter.Location = new System.Drawing.Point(6, 18);
            this.indicateFilter.Name = "indicateFilter";
            this.indicateFilter.Size = new System.Drawing.Size(29, 17);
            this.indicateFilter.TabIndex = 0;
            this.indicateFilter.Text = "Filter";
            this.indicateFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.indicateFilter.UseCompatibleTextRendering = true;
            // 
            // visualizeAgenda
            // 
            this.visualizeAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visualizeAgenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visualizeAgenda.Controls.Add(this.dataGridView1);
            this.visualizeAgenda.Controls.Add(this.applyFilter);
            this.visualizeAgenda.Controls.Add(this.inputFilter);
            this.visualizeAgenda.Controls.Add(this.indicateFilter);
            this.visualizeAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visualizeAgenda.Location = new System.Drawing.Point(8, 9);
            this.visualizeAgenda.Name = "visualizeAgenda";
            this.visualizeAgenda.Size = new System.Drawing.Size(295, 344);
            this.visualizeAgenda.TabIndex = 1;
            this.visualizeAgenda.TabStop = false;
            this.visualizeAgenda.Text = "People List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(283, 297);
            this.dataGridView1.TabIndex = 3;
            // 
            // applyFilter
            // 
            this.applyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilter.AutoSize = true;
            this.applyFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyFilter.FlatAppearance.BorderSize = 0;
            this.applyFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.applyFilter.Location = new System.Drawing.Point(217, 13);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(72, 22);
            this.applyFilter.TabIndex = 2;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = true;
            // 
            // inputFilter
            // 
            this.inputFilter.AccessibleDescription = "Input filter in the agenda";
            this.inputFilter.AccessibleName = "Filter Input text box";
            this.inputFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.inputFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilter.Location = new System.Drawing.Point(54, 16);
            this.inputFilter.Name = "inputFilter";
            this.inputFilter.Size = new System.Drawing.Size(153, 19);
            this.inputFilter.TabIndex = 1;
            this.inputFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateAgendaTools
            // 
            this.updateAgendaTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateAgendaTools.Controls.Add(this.emailErrorDisplay);
            this.updateAgendaTools.Controls.Add(this.telErrorDisplay);
            this.updateAgendaTools.Controls.Add(this.nameErrorDisplay);
            this.updateAgendaTools.Controls.Add(this.updateEntry);
            this.updateAgendaTools.Controls.Add(this.removeEntry);
            this.updateAgendaTools.Controls.Add(this.addEntry);
            this.updateAgendaTools.Controls.Add(this.emailInput);
            this.updateAgendaTools.Controls.Add(this.telephoneInput);
            this.updateAgendaTools.Controls.Add(this.nameInput);
            this.updateAgendaTools.Controls.Add(this.emailTag);
            this.updateAgendaTools.Controls.Add(this.telephoneTag);
            this.updateAgendaTools.Controls.Add(this.nameTag);
            this.updateAgendaTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAgendaTools.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateAgendaTools.Location = new System.Drawing.Point(311, 9);
            this.updateAgendaTools.Name = "updateAgendaTools";
            this.updateAgendaTools.Size = new System.Drawing.Size(266, 344);
            this.updateAgendaTools.TabIndex = 2;
            this.updateAgendaTools.TabStop = false;
            this.updateAgendaTools.Text = "Manage Agenda";
            // 
            // nameTag
            // 
            this.nameTag.AutoSize = true;
            this.nameTag.Location = new System.Drawing.Point(3, 19);
            this.nameTag.Name = "nameTag";
            this.nameTag.Size = new System.Drawing.Size(35, 13);
            this.nameTag.TabIndex = 0;
            this.nameTag.Text = "Name";
            // 
            // telephoneTag
            // 
            this.telephoneTag.AutoSize = true;
            this.telephoneTag.Location = new System.Drawing.Point(3, 81);
            this.telephoneTag.Name = "telephoneTag";
            this.telephoneTag.Size = new System.Drawing.Size(58, 13);
            this.telephoneTag.TabIndex = 1;
            this.telephoneTag.Text = "Telephone";
            // 
            // emailTag
            // 
            this.emailTag.AutoSize = true;
            this.emailTag.Location = new System.Drawing.Point(3, 143);
            this.emailTag.Name = "emailTag";
            this.emailTag.Size = new System.Drawing.Size(32, 13);
            this.emailTag.TabIndex = 2;
            this.emailTag.Text = "Email";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(6, 35);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(254, 20);
            this.nameInput.TabIndex = 3;
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // telephoneInput
            // 
            this.telephoneInput.Location = new System.Drawing.Point(6, 97);
            this.telephoneInput.Name = "telephoneInput";
            this.telephoneInput.Size = new System.Drawing.Size(254, 20);
            this.telephoneInput.TabIndex = 4;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(6, 159);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(254, 20);
            this.emailInput.TabIndex = 5;
            // 
            // addEntry
            // 
            this.addEntry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addEntry.Location = new System.Drawing.Point(10, 314);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(74, 24);
            this.addEntry.TabIndex = 6;
            this.addEntry.Text = "Add";
            this.addEntry.UseVisualStyleBackColor = true;
            // 
            // removeEntry
            // 
            this.removeEntry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeEntry.Location = new System.Drawing.Point(90, 314);
            this.removeEntry.Name = "removeEntry";
            this.removeEntry.Size = new System.Drawing.Size(90, 24);
            this.removeEntry.TabIndex = 7;
            this.removeEntry.Text = "Remove";
            this.removeEntry.UseVisualStyleBackColor = true;
            // 
            // updateEntry
            // 
            this.updateEntry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateEntry.Location = new System.Drawing.Point(186, 314);
            this.updateEntry.Name = "updateEntry";
            this.updateEntry.Size = new System.Drawing.Size(74, 24);
            this.updateEntry.TabIndex = 8;
            this.updateEntry.Text = "Update";
            this.updateEntry.UseVisualStyleBackColor = true;
            // 
            // nameErrorDisplay
            // 
            this.nameErrorDisplay.ForeColor = System.Drawing.Color.Red;
            this.nameErrorDisplay.Location = new System.Drawing.Point(10, 58);
            this.nameErrorDisplay.Name = "nameErrorDisplay";
            this.nameErrorDisplay.Size = new System.Drawing.Size(250, 23);
            this.nameErrorDisplay.TabIndex = 9;
            // 
            // telErrorDisplay
            // 
            this.telErrorDisplay.ForeColor = System.Drawing.Color.Red;
            this.telErrorDisplay.Location = new System.Drawing.Point(10, 120);
            this.telErrorDisplay.Name = "telErrorDisplay";
            this.telErrorDisplay.Size = new System.Drawing.Size(250, 23);
            this.telErrorDisplay.TabIndex = 10;
            // 
            // emailErrorDisplay
            // 
            this.emailErrorDisplay.ForeColor = System.Drawing.Color.Red;
            this.emailErrorDisplay.Location = new System.Drawing.Point(6, 182);
            this.emailErrorDisplay.Name = "emailErrorDisplay";
            this.emailErrorDisplay.Size = new System.Drawing.Size(254, 23);
            this.emailErrorDisplay.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.updateAgendaTools);
            this.Controls.Add(this.visualizeAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.visualizeAgenda.ResumeLayout(false);
            this.visualizeAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updateAgendaTools.ResumeLayout(false);
            this.updateAgendaTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label indicateFilter;
        private System.Windows.Forms.GroupBox visualizeAgenda;
        private System.Windows.Forms.TextBox inputFilter;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox updateAgendaTools;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox telephoneInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label emailTag;
        private System.Windows.Forms.Label telephoneTag;
        private System.Windows.Forms.Label nameTag;
        private System.Windows.Forms.Button updateEntry;
        private System.Windows.Forms.Button removeEntry;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.Label emailErrorDisplay;
        private System.Windows.Forms.Label telErrorDisplay;
        private System.Windows.Forms.Label nameErrorDisplay;
    }
}

