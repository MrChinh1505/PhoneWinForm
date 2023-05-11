namespace MobilePhone.GUI
{
    partial class FormAgent
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableAgent = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inforGroup = new System.Windows.Forms.GroupBox();
            this.txtAdd = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.RichTextBox();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAgent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.inforGroup.SuspendLayout();
            this.actionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableAgent);
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer list";
            // 
            // tableAgent
            // 
            this.tableAgent.AllowUserToAddRows = false;
            this.tableAgent.AllowUserToDeleteRows = false;
            this.tableAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableAgent.AutoGenerateColumns = false;
            this.tableAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableAgent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableAgent.ColumnHeadersHeight = 30;
            this.tableAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.tableAgent.DataSource = this.agentBindingSource;
            this.tableAgent.Location = new System.Drawing.Point(10, 25);
            this.tableAgent.Name = "tableAgent";
            this.tableAgent.RowHeadersWidth = 51;
            this.tableAgent.RowTemplate.Height = 24;
            this.tableAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAgent.Size = new System.Drawing.Size(1158, 350);
            this.tableAgent.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.21368F));
            this.tableLayoutPanel1.Controls.Add(this.inforGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.actionGroup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 282);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // inforGroup
            // 
            this.inforGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inforGroup.Controls.Add(this.txtAdd);
            this.inforGroup.Controls.Add(this.label5);
            this.inforGroup.Controls.Add(this.txtPass);
            this.inforGroup.Controls.Add(this.label4);
            this.inforGroup.Controls.Add(this.txtContact);
            this.inforGroup.Controls.Add(this.label3);
            this.inforGroup.Controls.Add(this.label2);
            this.inforGroup.Controls.Add(this.txtName);
            this.inforGroup.Controls.Add(this.label1);
            this.inforGroup.Controls.Add(this.txtID);
            this.inforGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforGroup.Location = new System.Drawing.Point(8, 8);
            this.inforGroup.Name = "inforGroup";
            this.inforGroup.Size = new System.Drawing.Size(400, 266);
            this.inforGroup.TabIndex = 0;
            this.inforGroup.TabStop = false;
            this.inforGroup.Text = "Infomation";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(124, 117);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtAdd.Size = new System.Drawing.Size(183, 30);
            this.txtAdd.TabIndex = 3;
            this.txtAdd.Text = "";
            this.txtAdd.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 203);
            this.txtPass.Name = "txtPass";
            this.txtPass.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPass.Size = new System.Drawing.Size(183, 30);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact :";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(124, 160);
            this.txtContact.Name = "txtContact";
            this.txtContact.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtContact.Size = new System.Drawing.Size(183, 30);
            this.txtContact.TabIndex = 4;
            this.txtContact.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 73);
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtName.Size = new System.Drawing.Size(183, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 28);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtID.Size = new System.Drawing.Size(183, 30);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "";
            // 
            // actionGroup
            // 
            this.actionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionGroup.Controls.Add(this.btnSave);
            this.actionGroup.Controls.Add(this.button4);
            this.actionGroup.Controls.Add(this.txtSearch);
            this.actionGroup.Controls.Add(this.label6);
            this.actionGroup.Controls.Add(this.btnAll);
            this.actionGroup.Controls.Add(this.btnDelete);
            this.actionGroup.Controls.Add(this.btnAdd);
            this.actionGroup.Location = new System.Drawing.Point(414, 8);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Padding = new System.Windows.Forms.Padding(4);
            this.actionGroup.Size = new System.Drawing.Size(758, 266);
            this.actionGroup.TabIndex = 1;
            this.actionGroup.TabStop = false;
            this.actionGroup.Text = "Action";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 118);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtSearch.Size = new System.Drawing.Size(222, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search :";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(462, 28);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(84, 38);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "View all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(DTO.Agent);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AgentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AgentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AgentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "AgentName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 108;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 87;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 81;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 96;
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 675);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAgent";
            this.Text = "Agent";
            this.Load += new System.EventHandler(this.FormAgent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableAgent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.inforGroup.ResumeLayout(false);
            this.inforGroup.PerformLayout();
            this.actionGroup.ResumeLayout(false);
            this.actionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tableAgent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox inforGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPass;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}