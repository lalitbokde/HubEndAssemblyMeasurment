namespace HubEndAssemblyMeasurment
{
    partial class ModelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelMaster));
            this.bttn_close = new System.Windows.Forms.Button();
            this.dgv_ModelMaster = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master_value_of_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master_value_of_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shim_verification_tolerence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_update = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_shim = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_ModelMaster = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_masterValueofX = new System.Windows.Forms.TextBox();
            this.lbl_shimM_DGR_Driven = new System.Windows.Forms.Label();
            this.txt_masterValueofY = new System.Windows.Forms.TextBox();
            this.lbl_tolerence_value_driven = new System.Windows.Forms.Label();
            this.txt_tolerence_value = new System.Windows.Forms.TextBox();
            this.lbl_shim_verification_tolerence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_close
            // 
            this.bttn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_close.BackgroundImage")));
            this.bttn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_close.FlatAppearance.BorderSize = 0;
            this.bttn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.ForeColor = System.Drawing.Color.White;
            this.bttn_close.Location = new System.Drawing.Point(423, 284);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(83, 36);
            this.bttn_close.TabIndex = 16;
            this.bttn_close.Text = "Close";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // dgv_ModelMaster
            // 
            this.dgv_ModelMaster.AllowUserToAddRows = false;
            this.dgv_ModelMaster.AllowUserToDeleteRows = false;
            this.dgv_ModelMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ModelMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ModelMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ModelMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModelMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ID,
            this.Model,
            this.master_value_of_X,
            this.master_value_of_Y,
            this.shim_verification_tolerence});
            this.dgv_ModelMaster.Location = new System.Drawing.Point(12, 326);
            this.dgv_ModelMaster.Name = "dgv_ModelMaster";
            this.dgv_ModelMaster.ReadOnly = true;
            this.dgv_ModelMaster.Size = new System.Drawing.Size(494, 266);
            this.dgv_ModelMaster.TabIndex = 15;
            this.dgv_ModelMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ModelMaster_CellClick);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // master_value_of_X
            // 
            this.master_value_of_X.HeaderText = "Master Value of X";
            this.master_value_of_X.Name = "master_value_of_X";
            this.master_value_of_X.ReadOnly = true;
            // 
            // master_value_of_Y
            // 
            this.master_value_of_Y.HeaderText = "Master Value of Y";
            this.master_value_of_Y.Name = "master_value_of_Y";
            this.master_value_of_Y.ReadOnly = true;
            // 
            // shim_verification_tolerence
            // 
            this.shim_verification_tolerence.HeaderText = "Shim Verification Tolerence value";
            this.shim_verification_tolerence.Name = "shim_verification_tolerence";
            this.shim_verification_tolerence.ReadOnly = true;
            // 
            // bttn_delete
            // 
            this.bttn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_delete.BackgroundImage")));
            this.bttn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_delete.FlatAppearance.BorderSize = 0;
            this.bttn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.ForeColor = System.Drawing.Color.White;
            this.bttn_delete.Location = new System.Drawing.Point(248, 284);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(83, 36);
            this.bttn_delete.TabIndex = 14;
            this.bttn_delete.Text = "Detete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_update
            // 
            this.bttn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_update.BackgroundImage")));
            this.bttn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_update.FlatAppearance.BorderSize = 0;
            this.bttn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_update.ForeColor = System.Drawing.Color.White;
            this.bttn_update.Location = new System.Drawing.Point(160, 284);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(83, 36);
            this.bttn_update.TabIndex = 13;
            this.bttn_update.Text = "Update";
            this.bttn_update.UseVisualStyleBackColor = true;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.AutoEllipsis = true;
            this.bttn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_save.BackgroundImage")));
            this.bttn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_save.FlatAppearance.BorderSize = 0;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.ForeColor = System.Drawing.Color.White;
            this.bttn_save.Location = new System.Drawing.Point(71, 284);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(83, 36);
            this.bttn_save.TabIndex = 12;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(402, 68);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(115, 20);
            this.dtp_date.TabIndex = 11;
            // 
            // txt_shim
            // 
            this.txt_shim.Location = new System.Drawing.Point(259, 103);
            this.txt_shim.Name = "txt_shim";
            this.txt_shim.Size = new System.Drawing.Size(181, 20);
            this.txt_shim.TabIndex = 10;
            this.txt_shim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_shim_KeyDown);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(359, 68);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(37, 15);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "Date";
            // 
            // lbl_ModelMaster
            // 
            this.lbl_ModelMaster.AutoSize = true;
            this.lbl_ModelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModelMaster.Location = new System.Drawing.Point(81, 105);
            this.lbl_ModelMaster.Name = "lbl_ModelMaster";
            this.lbl_ModelMaster.Size = new System.Drawing.Size(104, 16);
            this.lbl_ModelMaster.TabIndex = 17;
            this.lbl_ModelMaster.Text = "Model Name :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(336, 169);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 15);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(259, 229);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(181, 20);
            this.txt_id.TabIndex = 18;
            this.txt_id.Visible = false;
            // 
            // bttn_reset
            // 
            this.bttn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_reset.BackgroundImage")));
            this.bttn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_reset.FlatAppearance.BorderSize = 0;
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.ForeColor = System.Drawing.Color.White;
            this.bttn_reset.Location = new System.Drawing.Point(336, 284);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(83, 36);
            this.bttn_reset.TabIndex = 20;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HubEndAssemblyMeasurment.Properties.Resources.mahindra_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 65);
            this.panel1.TabIndex = 21;
            // 
            // txt_masterValueofX
            // 
            this.txt_masterValueofX.Location = new System.Drawing.Point(259, 134);
            this.txt_masterValueofX.Name = "txt_masterValueofX";
            this.txt_masterValueofX.Size = new System.Drawing.Size(181, 20);
            this.txt_masterValueofX.TabIndex = 34;
            this.txt_masterValueofX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_masterValue_KeyDown);
            this.txt_masterValueofX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_masterValue_KeyPress);
            // 
            // lbl_shimM_DGR_Driven
            // 
            this.lbl_shimM_DGR_Driven.AutoSize = true;
            this.lbl_shimM_DGR_Driven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shimM_DGR_Driven.Location = new System.Drawing.Point(81, 136);
            this.lbl_shimM_DGR_Driven.Name = "lbl_shimM_DGR_Driven";
            this.lbl_shimM_DGR_Driven.Size = new System.Drawing.Size(137, 16);
            this.lbl_shimM_DGR_Driven.TabIndex = 33;
            this.lbl_shimM_DGR_Driven.Text = "Master Value of X :";
            // 
            // txt_masterValueofY
            // 
            this.txt_masterValueofY.Location = new System.Drawing.Point(259, 166);
            this.txt_masterValueofY.Name = "txt_masterValueofY";
            this.txt_masterValueofY.Size = new System.Drawing.Size(181, 20);
            this.txt_masterValueofY.TabIndex = 36;
            this.txt_masterValueofY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_masterValueofY_KeyDown);
            this.txt_masterValueofY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tolerence_value_KeyPress);
            // 
            // lbl_tolerence_value_driven
            // 
            this.lbl_tolerence_value_driven.AutoSize = true;
            this.lbl_tolerence_value_driven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tolerence_value_driven.Location = new System.Drawing.Point(81, 168);
            this.lbl_tolerence_value_driven.Name = "lbl_tolerence_value_driven";
            this.lbl_tolerence_value_driven.Size = new System.Drawing.Size(138, 16);
            this.lbl_tolerence_value_driven.TabIndex = 35;
            this.lbl_tolerence_value_driven.Text = "Master Value of Y :";
            // 
            // txt_tolerence_value
            // 
            this.txt_tolerence_value.Location = new System.Drawing.Point(259, 198);
            this.txt_tolerence_value.Name = "txt_tolerence_value";
            this.txt_tolerence_value.Size = new System.Drawing.Size(181, 20);
            this.txt_tolerence_value.TabIndex = 38;
            this.txt_tolerence_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_shim_verification_tolerence_KeyDown);
            // 
            // lbl_shim_verification_tolerence
            // 
            this.lbl_shim_verification_tolerence.AutoSize = true;
            this.lbl_shim_verification_tolerence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shim_verification_tolerence.Location = new System.Drawing.Point(81, 200);
            this.lbl_shim_verification_tolerence.Name = "lbl_shim_verification_tolerence";
            this.lbl_shim_verification_tolerence.Size = new System.Drawing.Size(173, 16);
            this.lbl_shim_verification_tolerence.TabIndex = 37;
            this.lbl_shim_verification_tolerence.Text = "Shim Verify  Tolerence :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID :";
            this.label1.Visible = false;
            // 
            // ModelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tolerence_value);
            this.Controls.Add(this.lbl_shim_verification_tolerence);
            this.Controls.Add(this.txt_masterValueofY);
            this.Controls.Add(this.lbl_tolerence_value_driven);
            this.Controls.Add(this.txt_masterValueofX);
            this.Controls.Add(this.lbl_shimM_DGR_Driven);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_ModelMaster);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.dgv_ModelMaster);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_shim);
            this.Controls.Add(this.lbl_date);
            this.Name = "ModelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelMaster";
            this.Load += new System.EventHandler(this.ModelMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.DataGridView dgv_ModelMaster;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_update;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_shim;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_ModelMaster;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_masterValueofX;
        private System.Windows.Forms.Label lbl_shimM_DGR_Driven;
        private System.Windows.Forms.TextBox txt_masterValueofY;
        private System.Windows.Forms.Label lbl_tolerence_value_driven;
        private System.Windows.Forms.TextBox txt_tolerence_value;
        private System.Windows.Forms.Label lbl_shim_verification_tolerence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn master_value_of_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn master_value_of_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn shim_verification_tolerence;
    }
}