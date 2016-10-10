namespace MyBikes_Project
{
    partial class frmMyBikes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyBikes));
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.grpBikeDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvwBikeDetails = new System.Windows.Forms.ListView();
            this.lvwMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMotorBikeList = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBikeDetails.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMake
            // 
            this.tbMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMake.ForeColor = System.Drawing.Color.Gray;
            this.tbMake.Location = new System.Drawing.Point(100, 69);
            this.tbMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(128, 23);
            this.tbMake.TabIndex = 1;
            this.tbMake.Text = "Compulsory";
            this.tbMake.Click += new System.EventHandler(this.tbMake_Click);
            this.tbMake.TextChanged += new System.EventHandler(this.tbMake_TextChanged);
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.ForeColor = System.Drawing.Color.Gray;
            this.tbModel.Location = new System.Drawing.Point(100, 97);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(128, 23);
            this.tbModel.TabIndex = 2;
            this.tbModel.Text = "Compulsory";
            this.tbModel.Click += new System.EventHandler(this.tbModel_Click);
            this.tbModel.TextChanged += new System.EventHandler(this.tbModel_TextChanged);
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.ForeColor = System.Drawing.Color.Gray;
            this.tbSize.Location = new System.Drawing.Point(100, 126);
            this.tbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(128, 23);
            this.tbSize.TabIndex = 3;
            this.tbSize.Text = "Optional";
            this.tbSize.Click += new System.EventHandler(this.tbSize_Click);
            this.tbSize.TextChanged += new System.EventHandler(this.tbSize_TextChanged);
            this.tbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.ForeColor = System.Drawing.Color.Gray;
            this.tbYear.Location = new System.Drawing.Point(100, 153);
            this.tbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(128, 23);
            this.tbYear.TabIndex = 4;
            this.tbYear.Text = "Optional";
            this.tbYear.Click += new System.EventHandler(this.tbYear_Click);
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.ForeColor = System.Drawing.Color.Gray;
            this.tbCost.Location = new System.Drawing.Point(100, 181);
            this.tbCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(128, 23);
            this.tbCost.TabIndex = 5;
            this.tbCost.Text = "Optional";
            this.tbCost.Click += new System.EventHandler(this.tbCost_Click);
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 266);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 222);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(565, 398);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(33, 71);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 10;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(29, 100);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(39, 128);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "Size:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(37, 156);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(39, 183);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "Cost:";
            // 
            // grpBikeDetails
            // 
            this.grpBikeDetails.Controls.Add(this.btnClear);
            this.grpBikeDetails.Controls.Add(this.lblCost);
            this.grpBikeDetails.Controls.Add(this.lblYear);
            this.grpBikeDetails.Controls.Add(this.btnUpdate);
            this.grpBikeDetails.Controls.Add(this.btnAdd);
            this.grpBikeDetails.Controls.Add(this.lblSize);
            this.grpBikeDetails.Controls.Add(this.lblModel);
            this.grpBikeDetails.Controls.Add(this.lblMake);
            this.grpBikeDetails.Controls.Add(this.tbCost);
            this.grpBikeDetails.Controls.Add(this.tbYear);
            this.grpBikeDetails.Controls.Add(this.tbSize);
            this.grpBikeDetails.Controls.Add(this.tbModel);
            this.grpBikeDetails.Controls.Add(this.tbMake);
            this.grpBikeDetails.Location = new System.Drawing.Point(465, 32);
            this.grpBikeDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBikeDetails.Name = "grpBikeDetails";
            this.grpBikeDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBikeDetails.Size = new System.Drawing.Size(256, 312);
            this.grpBikeDetails.TabIndex = 0;
            this.grpBikeDetails.TabStop = false;
            this.grpBikeDetails.Text = "Enter Bike Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvwBikeDetails
            // 
            this.lvwBikeDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwMake,
            this.lvwModel,
            this.lvwSize,
            this.lvwYear,
            this.lvwCost});
            this.lvwBikeDetails.FullRowSelect = true;
            this.lvwBikeDetails.GridLines = true;
            this.lvwBikeDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwBikeDetails.Location = new System.Drawing.Point(13, 62);
            this.lvwBikeDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwBikeDetails.MultiSelect = false;
            this.lvwBikeDetails.Name = "lvwBikeDetails";
            this.lvwBikeDetails.Size = new System.Drawing.Size(444, 362);
            this.lvwBikeDetails.TabIndex = 9;
            this.lvwBikeDetails.UseCompatibleStateImageBehavior = false;
            this.lvwBikeDetails.View = System.Windows.Forms.View.Details;
            this.lvwBikeDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwBikeDetails_MouseClick);
            // 
            // lvwMake
            // 
            this.lvwMake.Text = "Make";
            this.lvwMake.Width = 80;
            // 
            // lvwModel
            // 
            this.lvwModel.Text = "Model";
            // 
            // lvwSize
            // 
            this.lvwSize.Text = "Size";
            // 
            // lvwYear
            // 
            this.lvwYear.Text = "Year";
            // 
            // lvwCost
            // 
            this.lvwCost.Text = "Cost";
            // 
            // lblMotorBikeList
            // 
            this.lblMotorBikeList.AutoSize = true;
            this.lblMotorBikeList.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorBikeList.Location = new System.Drawing.Point(115, 32);
            this.lblMotorBikeList.Name = "lblMotorBikeList";
            this.lblMotorBikeList.Size = new System.Drawing.Size(148, 27);
            this.lblMotorBikeList.TabIndex = 17;
            this.lblMotorBikeList.Text = "Motorbike List";
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(736, 28);
            this.mnuMain.TabIndex = 18;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(115, 26);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(115, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserGuide});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuUserGuide
            // 
            this.mnuUserGuide.Name = "mnuUserGuide";
            this.mnuUserGuide.Size = new System.Drawing.Size(156, 26);
            this.mnuUserGuide.Text = "User Guide";
            this.mnuUserGuide.Click += new System.EventHandler(this.mnuUserGuide_Click);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsMessage});
            this.stsMain.Location = new System.Drawing.Point(0, 430);
            this.stsMain.Name = "stsMain";
            this.stsMain.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.stsMain.Size = new System.Drawing.Size(736, 25);
            this.stsMain.TabIndex = 19;
            this.stsMain.Text = "Warining";
            // 
            // stsMessage
            // 
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(84, 20);
            this.stsMessage.Text = "stsMessage";
            // 
            // frmMyBikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.lblMotorBikeList);
            this.Controls.Add(this.lvwBikeDetails);
            this.Controls.Add(this.grpBikeDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMyBikes";
            this.Text = "My Bike Collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMyBikes_FormClosing);
            this.Load += new System.EventHandler(this.frmMyBikes_Load);
            this.grpBikeDetails.ResumeLayout(false);
            this.grpBikeDetails.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.GroupBox grpBikeDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvwBikeDetails;
        private System.Windows.Forms.ColumnHeader lvwMake;
        private System.Windows.Forms.ColumnHeader lvwModel;
        private System.Windows.Forms.ColumnHeader lvwSize;
        private System.Windows.Forms.ColumnHeader lvwYear;
        private System.Windows.Forms.ColumnHeader lvwCost;
        private System.Windows.Forms.Label lblMotorBikeList;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuUserGuide;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsMessage;
    }
}

