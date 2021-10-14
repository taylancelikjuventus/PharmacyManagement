namespace PharmacyManagementSystem.AdministratorControlForms
{
    partial class ViewUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViewName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridViewView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnViewDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "View User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name";
            // 
            // txtViewName
            // 
            this.txtViewName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewName.DefaultText = "";
            this.txtViewName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtViewName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtViewName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtViewName.DisabledState.Parent = this.txtViewName;
            this.txtViewName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtViewName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtViewName.FocusedState.Parent = this.txtViewName;
            this.txtViewName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtViewName.HoverState.Parent = this.txtViewName;
            this.txtViewName.Location = new System.Drawing.Point(308, 91);
            this.txtViewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.PasswordChar = '\0';
            this.txtViewName.PlaceholderText = "";
            this.txtViewName.SelectedText = "";
            this.txtViewName.ShadowDecoration.Parent = this.txtViewName;
            this.txtViewName.Size = new System.Drawing.Size(298, 46);
            this.txtViewName.TabIndex = 11;
            this.txtViewName.TextChanged += new System.EventHandler(this.txtViewName_TextChanged);
            // 
            // guna2DataGridViewView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewView.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridViewView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewView.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridViewView.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewView.Location = new System.Drawing.Point(31, 165);
            this.guna2DataGridViewView.Name = "guna2DataGridViewView";
            this.guna2DataGridViewView.RowHeadersVisible = false;
            this.guna2DataGridViewView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewView.Size = new System.Drawing.Size(898, 366);
            this.guna2DataGridViewView.TabIndex = 12;
            this.guna2DataGridViewView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridViewView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridViewView.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridViewView.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewView_CellClick);
            // 
            // btnViewDelete
            // 
            this.btnViewDelete.BorderRadius = 15;
            this.btnViewDelete.CheckedState.Parent = this.btnViewDelete;
            this.btnViewDelete.CustomImages.Parent = this.btnViewDelete;
            this.btnViewDelete.FillColor = System.Drawing.Color.SteelBlue;
            this.btnViewDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDelete.ForeColor = System.Drawing.Color.White;
            this.btnViewDelete.HoverState.Parent = this.btnViewDelete;
            this.btnViewDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDelete.Image")));
            this.btnViewDelete.Location = new System.Drawing.Point(801, 548);
            this.btnViewDelete.Name = "btnViewDelete";
            this.btnViewDelete.ShadowDecoration.Parent = this.btnViewDelete;
            this.btnViewDelete.Size = new System.Drawing.Size(128, 31);
            this.btnViewDelete.TabIndex = 17;
            this.btnViewDelete.Text = "Delete";
            this.btnViewDelete.Click += new System.EventHandler(this.btnViewDelete_Click);
            // 
            // btnDashRefresh
            // 
            this.btnDashRefresh.BorderRadius = 15;
            this.btnDashRefresh.CheckedState.Parent = this.btnDashRefresh;
            this.btnDashRefresh.CustomImages.Parent = this.btnDashRefresh;
            this.btnDashRefresh.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDashRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashRefresh.ForeColor = System.Drawing.Color.White;
            this.btnDashRefresh.HoverState.Parent = this.btnDashRefresh;
            this.btnDashRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnDashRefresh.Image")));
            this.btnDashRefresh.Location = new System.Drawing.Point(643, 91);
            this.btnDashRefresh.Name = "btnDashRefresh";
            this.btnDashRefresh.ShadowDecoration.Parent = this.btnDashRefresh;
            this.btnDashRefresh.Size = new System.Drawing.Size(128, 31);
            this.btnDashRefresh.TabIndex = 18;
            this.btnDashRefresh.Text = "Refresh";
            this.btnDashRefresh.Click += new System.EventHandler(this.btnViewRefresh_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(953, 600);
            this.Controls.Add(this.btnDashRefresh);
            this.Controls.Add(this.btnViewDelete);
            this.Controls.Add(this.guna2DataGridViewView);
            this.Controls.Add(this.txtViewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtViewName;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewView;
        private Guna.UI2.WinForms.Guna2Button btnViewDelete;
        private Guna.UI2.WinForms.Guna2Button btnDashRefresh;
    }
}