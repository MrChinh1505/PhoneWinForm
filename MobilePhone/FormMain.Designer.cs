namespace MobilePhone
{
    partial class FormMain
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
            this.btnImp = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.childForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImp
            // 
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnImp.Location = new System.Drawing.Point(3, 278);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(167, 59);
            this.btnImp.TabIndex = 5;
            this.btnImp.Text = "Import";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnCus
            // 
            this.btnCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCus.Location = new System.Drawing.Point(3, 83);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(167, 59);
            this.btnCus.TabIndex = 1;
            this.btnCus.Text = "Agent";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnPro
            // 
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPro.Location = new System.Drawing.Point(4, 148);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(167, 59);
            this.btnPro.TabIndex = 2;
            this.btnPro.Text = "Product";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnOrder.Location = new System.Drawing.Point(4, 213);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(167, 59);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDash.Location = new System.Drawing.Point(3, 16);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(167, 61);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDash.UseMnemonic = false;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(3, 650);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // childForm
            // 
            this.childForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childForm.BackColor = System.Drawing.Color.LightGray;
            this.childForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childForm.Location = new System.Drawing.Point(181, 83);
            this.childForm.Name = "childForm";
            this.childForm.Size = new System.Drawing.Size(1218, 619);
            this.childForm.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabLabel);
            this.panel2.Location = new System.Drawing.Point(181, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 72);
            this.panel2.TabIndex = 7;
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLabel.Location = new System.Drawing.Point(575, 22);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(97, 25);
            this.tabLabel.TabIndex = 0;
            this.tabLabel.Text = "Dasboard";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnCus);
            this.panel1.Controls.Add(this.btnImp);
            this.panel1.Controls.Add(this.btnPro);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(175, 714);
            this.panel1.TabIndex = 8;
            // 
            // btnDelivery
            // 
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelivery.Location = new System.Drawing.Point(4, 342);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(167, 59);
            this.btnDelivery.TabIndex = 8;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1411, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.childForm);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "Mobile Phone Distributor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel childForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tabLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelivery;
    }
}

