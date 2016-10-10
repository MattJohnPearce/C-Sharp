namespace MiningSimulator
{
    partial class frmMinSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMinSim));
            this.lvAllTrucks = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTruckID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoadCapacity = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbService = new System.Windows.Forms.RadioButton();
            this.rbCrusher = new System.Windows.Forms.RadioButton();
            this.rbLoading = new System.Windows.Forms.RadioButton();
            this.rbTransCrush = new System.Windows.Forms.RadioButton();
            this.rbTranLoad = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.lbTransLoad = new System.Windows.Forms.ListBox();
            this.lbLoadQue = new System.Windows.Forms.ListBox();
            this.lbTransCrush = new System.Windows.Forms.ListBox();
            this.lbCrushQue = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnService = new System.Windows.Forms.Button();
            this.lbInService = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInactive = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAllTrucks
            // 
            this.lvAllTrucks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chStatus});
            this.lvAllTrucks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvAllTrucks.FullRowSelect = true;
            this.lvAllTrucks.GridLines = true;
            this.lvAllTrucks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAllTrucks.Location = new System.Drawing.Point(9, 24);
            this.lvAllTrucks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvAllTrucks.MultiSelect = false;
            this.lvAllTrucks.Name = "lvAllTrucks";
            this.lvAllTrucks.Size = new System.Drawing.Size(83, 369);
            this.lvAllTrucks.TabIndex = 10;
            this.toolTip1.SetToolTip(this.lvAllTrucks, "Displays all the trucks ID and current statuses\r\nClick a truck for more details\r\n" +
        "Double click on a truckto put into Transfer to Loading\r\n");
            this.lvAllTrucks.UseCompatibleStateImageBehavior = false;
            this.lvAllTrucks.View = System.Windows.Forms.View.Details;
            this.lvAllTrucks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAllTrucks_MouseClick);
            this.lvAllTrucks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAllTrucks_MouseDoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 42;
            // 
            // tbTruckID
            // 
            this.tbTruckID.Location = new System.Drawing.Point(20, 41);
            this.tbTruckID.Name = "tbTruckID";
            this.tbTruckID.ReadOnly = true;
            this.tbTruckID.Size = new System.Drawing.Size(47, 20);
            this.tbTruckID.TabIndex = 11;
            this.toolTip1.SetToolTip(this.tbTruckID, "The trucks unique identifier");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Truck ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Load Capacity";
            // 
            // tbLoadCapacity
            // 
            this.tbLoadCapacity.Location = new System.Drawing.Point(20, 93);
            this.tbLoadCapacity.Name = "tbLoadCapacity";
            this.tbLoadCapacity.ReadOnly = true;
            this.tbLoadCapacity.Size = new System.Drawing.Size(48, 20);
            this.tbLoadCapacity.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tbLoadCapacity, "The maximum load the truck can carry at once");
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(20, 146);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(73, 20);
            this.tbTotal.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tbTotal, "The amount of loads the truck has carried");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbService);
            this.groupBox1.Controls.Add(this.rbCrusher);
            this.groupBox1.Controls.Add(this.rbLoading);
            this.groupBox1.Controls.Add(this.rbTransCrush);
            this.groupBox1.Controls.Add(this.rbTranLoad);
            this.groupBox1.Controls.Add(this.rbInactive);
            this.groupBox1.Location = new System.Drawing.Point(260, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 188);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truck Status";
            this.toolTip1.SetToolTip(this.groupBox1, "Statuses for each truck");
            // 
            // rbService
            // 
            this.rbService.AutoSize = true;
            this.rbService.Location = new System.Drawing.Point(21, 147);
            this.rbService.Name = "rbService";
            this.rbService.Size = new System.Drawing.Size(61, 17);
            this.rbService.TabIndex = 5;
            this.rbService.TabStop = true;
            this.rbService.Text = "Service";
            this.rbService.UseVisualStyleBackColor = true;
            // 
            // rbCrusher
            // 
            this.rbCrusher.AutoSize = true;
            this.rbCrusher.Location = new System.Drawing.Point(21, 124);
            this.rbCrusher.Name = "rbCrusher";
            this.rbCrusher.Size = new System.Drawing.Size(61, 17);
            this.rbCrusher.TabIndex = 4;
            this.rbCrusher.TabStop = true;
            this.rbCrusher.Text = "Crusher";
            this.rbCrusher.UseVisualStyleBackColor = true;
            // 
            // rbLoading
            // 
            this.rbLoading.AutoSize = true;
            this.rbLoading.Location = new System.Drawing.Point(21, 78);
            this.rbLoading.Name = "rbLoading";
            this.rbLoading.Size = new System.Drawing.Size(63, 17);
            this.rbLoading.TabIndex = 3;
            this.rbLoading.TabStop = true;
            this.rbLoading.Text = "Loading";
            this.rbLoading.UseVisualStyleBackColor = true;
            // 
            // rbTransCrush
            // 
            this.rbTransCrush.AutoSize = true;
            this.rbTransCrush.Location = new System.Drawing.Point(21, 102);
            this.rbTransCrush.Name = "rbTransCrush";
            this.rbTransCrush.Size = new System.Drawing.Size(108, 17);
            this.rbTransCrush.TabIndex = 2;
            this.rbTransCrush.TabStop = true;
            this.rbTransCrush.Text = "Transit to Crusher";
            this.rbTransCrush.UseVisualStyleBackColor = true;
            // 
            // rbTranLoad
            // 
            this.rbTranLoad.AutoSize = true;
            this.rbTranLoad.Location = new System.Drawing.Point(21, 55);
            this.rbTranLoad.Name = "rbTranLoad";
            this.rbTranLoad.Size = new System.Drawing.Size(110, 17);
            this.rbTranLoad.TabIndex = 1;
            this.rbTranLoad.TabStop = true;
            this.rbTranLoad.Text = "Transit to Loading";
            this.rbTranLoad.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(21, 32);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 0;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // lbTransLoad
            // 
            this.lbTransLoad.FormattingEnabled = true;
            this.lbTransLoad.Location = new System.Drawing.Point(125, 261);
            this.lbTransLoad.Name = "lbTransLoad";
            this.lbTransLoad.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTransLoad.Size = new System.Drawing.Size(74, 134);
            this.lbTransLoad.TabIndex = 18;
            this.toolTip1.SetToolTip(this.lbTransLoad, "Moves truck into next queue");
            this.lbTransLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbTransLoad_MouseClick);
            // 
            // lbLoadQue
            // 
            this.lbLoadQue.FormattingEnabled = true;
            this.lbLoadQue.Location = new System.Drawing.Point(251, 261);
            this.lbLoadQue.Name = "lbLoadQue";
            this.lbLoadQue.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLoadQue.Size = new System.Drawing.Size(74, 134);
            this.lbLoadQue.TabIndex = 19;
            this.toolTip1.SetToolTip(this.lbLoadQue, "Moves truck into next queue");
            this.lbLoadQue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbLoadQue_MouseClick);
            // 
            // lbTransCrush
            // 
            this.lbTransCrush.FormattingEnabled = true;
            this.lbTransCrush.Location = new System.Drawing.Point(367, 261);
            this.lbTransCrush.Name = "lbTransCrush";
            this.lbTransCrush.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTransCrush.Size = new System.Drawing.Size(74, 134);
            this.lbTransCrush.TabIndex = 20;
            this.toolTip1.SetToolTip(this.lbTransCrush, "Moves truck into next queue");
            this.lbTransCrush.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbTransCrush_MouseClick);
            // 
            // lbCrushQue
            // 
            this.lbCrushQue.FormattingEnabled = true;
            this.lbCrushQue.Location = new System.Drawing.Point(486, 261);
            this.lbCrushQue.Name = "lbCrushQue";
            this.lbCrushQue.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbCrushQue.Size = new System.Drawing.Size(74, 134);
            this.lbCrushQue.TabIndex = 21;
            this.toolTip1.SetToolTip(this.lbCrushQue, "Moves truck into next queue");
            this.lbCrushQue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCrushQue_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Transfer to Loading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Loading Queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Transit to Crusher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Crusher Queue";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(425, 48);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 26;
            this.btnService.Text = "Service";
            this.toolTip1.SetToolTip(this.btnService, "Puts selected truck into servicing");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lbInService
            // 
            this.lbInService.FormattingEnabled = true;
            this.lbInService.Location = new System.Drawing.Point(425, 77);
            this.lbInService.Name = "lbInService";
            this.lbInService.Size = new System.Drawing.Size(134, 160);
            this.lbInService.TabIndex = 27;
            this.toolTip1.SetToolTip(this.lbInService, "Double click the truck to remove it from the list");
            this.lbInService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInService_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.tbTruckID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbLoadCapacity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(105, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 188);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck Details";
            // 
            // btnInactive
            // 
            this.btnInactive.Location = new System.Drawing.Point(105, 24);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(75, 24);
            this.btnInactive.TabIndex = 30;
            this.btnInactive.Text = "Inactive";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // frmMinSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 404);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbInService);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCrushQue);
            this.Controls.Add(this.lbTransCrush);
            this.Controls.Add(this.lbLoadQue);
            this.Controls.Add(this.lbTransLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvAllTrucks);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMinSim";
            this.Text = "Mining Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMinSim_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAllTrucks;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.TextBox tbTruckID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLoadCapacity;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbService;
        private System.Windows.Forms.RadioButton rbCrusher;
        private System.Windows.Forms.RadioButton rbLoading;
        private System.Windows.Forms.RadioButton rbTransCrush;
        private System.Windows.Forms.RadioButton rbTranLoad;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.ListBox lbTransLoad;
        private System.Windows.Forms.ListBox lbLoadQue;
        private System.Windows.Forms.ListBox lbTransCrush;
        private System.Windows.Forms.ListBox lbCrushQue;
        private System.Windows.Forms.ListBox lbInService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInactive;
    }
}

