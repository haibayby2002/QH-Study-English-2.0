namespace QHStudyEnglish
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabVocaSet = new System.Windows.Forms.TabPage();
            this.pnlQuickEditVocaSet = new System.Windows.Forms.Panel();
            this.btnAddByRegex = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnOpenVocaSet = new System.Windows.Forms.Button();
            this.pnlEditVocaset = new System.Windows.Forms.Panel();
            this.btnEditVocaSet = new System.Windows.Forms.Button();
            this.btnAddVocaSet = new System.Windows.Forms.Button();
            this.btnRemoveVocaSet = new System.Windows.Forms.Button();
            this.btnFoward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lsvRecommendedVocaSet = new System.Windows.Forms.ListView();
            this.recommended_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recommended_mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lblRecommended = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lblMyVocaSet = new System.Windows.Forms.Label();
            this.lsvMyVocaSet = new System.Windows.Forms.ListView();
            this.vocaSet_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vocaSet_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vocaSet_mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabVoca = new System.Windows.Forms.TabPage();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.chkCheckAllVoca = new System.Windows.Forms.CheckBox();
            this.grbVocaSet = new System.Windows.Forms.GroupBox();
            this.txtDescribeVocaSet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVocaSetName = new System.Windows.Forms.ComboBox();
            this.lblVocaSetName = new System.Windows.Forms.Label();
            this.cmbMode_Vocaset = new System.Windows.Forms.ComboBox();
            this.lblMode_VocaSet = new System.Windows.Forms.Label();
            this.lblVocaSet = new System.Windows.Forms.Label();
            this.lblDescribeVocaSet = new System.Windows.Forms.DataGridView();
            this.dgv_voca_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_voca_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_voca_practiced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_voca_ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_vocaSet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMain = new System.Windows.Forms.Label();
            this.tooltTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain.SuspendLayout();
            this.tabVocaSet.SuspendLayout();
            this.pnlQuickEditVocaSet.SuspendLayout();
            this.pnlEditVocaset.SuspendLayout();
            this.tabVoca.SuspendLayout();
            this.grbVocaSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescribeVocaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabVocaSet);
            this.tabMain.Controls.Add(this.tabVoca);
            this.tabMain.Location = new System.Drawing.Point(0, 81);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(984, 480);
            this.tabMain.TabIndex = 0;
            // 
            // tabVocaSet
            // 
            this.tabVocaSet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabVocaSet.Controls.Add(this.pnlQuickEditVocaSet);
            this.tabVocaSet.Controls.Add(this.pnlEditVocaset);
            this.tabVocaSet.Controls.Add(this.btnFoward);
            this.tabVocaSet.Controls.Add(this.btnBack);
            this.tabVocaSet.Controls.Add(this.lsvRecommendedVocaSet);
            this.tabVocaSet.Controls.Add(this.lblRecommended);
            this.tabVocaSet.Controls.Add(this.lblView);
            this.tabVocaSet.Controls.Add(this.cmbView);
            this.tabVocaSet.Controls.Add(this.lblMyVocaSet);
            this.tabVocaSet.Controls.Add(this.lsvMyVocaSet);
            this.tabVocaSet.Location = new System.Drawing.Point(4, 28);
            this.tabVocaSet.Name = "tabVocaSet";
            this.tabVocaSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabVocaSet.Size = new System.Drawing.Size(976, 448);
            this.tabVocaSet.TabIndex = 0;
            this.tabVocaSet.Text = "Bộ từ vựng";
            // 
            // pnlQuickEditVocaSet
            // 
            this.pnlQuickEditVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuickEditVocaSet.Controls.Add(this.btnAddByRegex);
            this.pnlQuickEditVocaSet.Controls.Add(this.btnCamera);
            this.pnlQuickEditVocaSet.Controls.Add(this.btnOpenVocaSet);
            this.pnlQuickEditVocaSet.Location = new System.Drawing.Point(668, 6);
            this.pnlQuickEditVocaSet.Name = "pnlQuickEditVocaSet";
            this.pnlQuickEditVocaSet.Size = new System.Drawing.Size(145, 57);
            this.pnlQuickEditVocaSet.TabIndex = 13;
            // 
            // btnAddByRegex
            // 
            this.btnAddByRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddByRegex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddByRegex.BackgroundImage")));
            this.btnAddByRegex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddByRegex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddByRegex.Location = new System.Drawing.Point(4, 7);
            this.btnAddByRegex.Name = "btnAddByRegex";
            this.btnAddByRegex.Size = new System.Drawing.Size(42, 42);
            this.btnAddByRegex.TabIndex = 15;
            this.btnAddByRegex.UseVisualStyleBackColor = true;
            // 
            // btnCamera
            // 
            this.btnCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCamera.BackgroundImage")));
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCamera.Location = new System.Drawing.Point(52, 7);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(42, 42);
            this.btnCamera.TabIndex = 14;
            this.btnCamera.UseVisualStyleBackColor = true;
            // 
            // btnOpenVocaSet
            // 
            this.btnOpenVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenVocaSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenVocaSet.BackgroundImage")));
            this.btnOpenVocaSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenVocaSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenVocaSet.Location = new System.Drawing.Point(100, 7);
            this.btnOpenVocaSet.Name = "btnOpenVocaSet";
            this.btnOpenVocaSet.Size = new System.Drawing.Size(42, 42);
            this.btnOpenVocaSet.TabIndex = 7;
            this.btnOpenVocaSet.UseVisualStyleBackColor = true;
            // 
            // pnlEditVocaset
            // 
            this.pnlEditVocaset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditVocaset.Controls.Add(this.btnEditVocaSet);
            this.pnlEditVocaset.Controls.Add(this.btnAddVocaSet);
            this.pnlEditVocaset.Controls.Add(this.btnRemoveVocaSet);
            this.pnlEditVocaset.Location = new System.Drawing.Point(816, 6);
            this.pnlEditVocaset.Name = "pnlEditVocaset";
            this.pnlEditVocaset.Size = new System.Drawing.Size(152, 57);
            this.pnlEditVocaset.TabIndex = 12;
            // 
            // btnEditVocaSet
            // 
            this.btnEditVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVocaSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditVocaSet.BackgroundImage")));
            this.btnEditVocaSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditVocaSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditVocaSet.Location = new System.Drawing.Point(99, 7);
            this.btnEditVocaSet.Name = "btnEditVocaSet";
            this.btnEditVocaSet.Size = new System.Drawing.Size(42, 42);
            this.btnEditVocaSet.TabIndex = 6;
            this.btnEditVocaSet.UseVisualStyleBackColor = true;
            // 
            // btnAddVocaSet
            // 
            this.btnAddVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVocaSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVocaSet.BackgroundImage")));
            this.btnAddVocaSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVocaSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVocaSet.Location = new System.Drawing.Point(3, 7);
            this.btnAddVocaSet.Name = "btnAddVocaSet";
            this.btnAddVocaSet.Size = new System.Drawing.Size(42, 42);
            this.btnAddVocaSet.TabIndex = 4;
            this.btnAddVocaSet.UseVisualStyleBackColor = true;
            // 
            // btnRemoveVocaSet
            // 
            this.btnRemoveVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveVocaSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveVocaSet.BackgroundImage")));
            this.btnRemoveVocaSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveVocaSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveVocaSet.Location = new System.Drawing.Point(51, 7);
            this.btnRemoveVocaSet.Name = "btnRemoveVocaSet";
            this.btnRemoveVocaSet.Size = new System.Drawing.Size(42, 42);
            this.btnRemoveVocaSet.TabIndex = 5;
            this.btnRemoveVocaSet.UseVisualStyleBackColor = true;
            // 
            // btnFoward
            // 
            this.btnFoward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoward.BackgroundImage")));
            this.btnFoward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoward.FlatAppearance.BorderSize = 0;
            this.btnFoward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoward.Location = new System.Drawing.Point(51, 40);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(35, 35);
            this.btnFoward.TabIndex = 11;
            this.btnFoward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(10, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lsvRecommendedVocaSet
            // 
            this.lsvRecommendedVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvRecommendedVocaSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recommended_name,
            this.recommended_mota});
            this.lsvRecommendedVocaSet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvRecommendedVocaSet.LargeImageList = this.imgList;
            this.lsvRecommendedVocaSet.Location = new System.Drawing.Point(10, 301);
            this.lsvRecommendedVocaSet.Name = "lsvRecommendedVocaSet";
            this.lsvRecommendedVocaSet.Size = new System.Drawing.Size(958, 139);
            this.lsvRecommendedVocaSet.SmallImageList = this.imgList;
            this.lsvRecommendedVocaSet.TabIndex = 9;
            this.lsvRecommendedVocaSet.UseCompatibleStateImageBehavior = false;
            this.lsvRecommendedVocaSet.View = System.Windows.Forms.View.Details;
            // 
            // recommended_name
            // 
            this.recommended_name.Text = "Bộ từ gợi ý";
            this.recommended_name.Width = 200;
            // 
            // recommended_mota
            // 
            this.recommended_mota.Text = "Giới thiệu";
            this.recommended_mota.Width = 800;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "icons8-compose-64 (1).png");
            // 
            // lblRecommended
            // 
            this.lblRecommended.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecommended.AutoSize = true;
            this.lblRecommended.Enabled = false;
            this.lblRecommended.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommended.Location = new System.Drawing.Point(394, 265);
            this.lblRecommended.Name = "lblRecommended";
            this.lblRecommended.Size = new System.Drawing.Size(178, 33);
            this.lblRecommended.TabIndex = 8;
            this.lblRecommended.Text = "Bộ từ đề xuất";
            this.lblRecommended.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(7, 13);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(58, 19);
            this.lblView.TabIndex = 3;
            this.lblView.Text = "Hiển thị:";
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "Large Icon",
            "Details",
            "Small Icon",
            "List",
            "Tile"});
            this.cmbView.Location = new System.Drawing.Point(71, 9);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(121, 27);
            this.cmbView.TabIndex = 2;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // lblMyVocaSet
            // 
            this.lblMyVocaSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMyVocaSet.AutoSize = true;
            this.lblMyVocaSet.Enabled = false;
            this.lblMyVocaSet.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyVocaSet.ImageList = this.imgList;
            this.lblMyVocaSet.Location = new System.Drawing.Point(407, 47);
            this.lblMyVocaSet.Name = "lblMyVocaSet";
            this.lblMyVocaSet.Size = new System.Drawing.Size(165, 33);
            this.lblMyVocaSet.TabIndex = 1;
            this.lblMyVocaSet.Text = "Bộ từ của tôi";
            this.lblMyVocaSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvMyVocaSet
            // 
            this.lsvMyVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMyVocaSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vocaSet_id,
            this.vocaSet_name,
            this.vocaSet_mota});
            this.lsvMyVocaSet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMyVocaSet.LargeImageList = this.imgList;
            this.lsvMyVocaSet.Location = new System.Drawing.Point(6, 83);
            this.lsvMyVocaSet.Name = "lsvMyVocaSet";
            this.lsvMyVocaSet.Size = new System.Drawing.Size(962, 166);
            this.lsvMyVocaSet.SmallImageList = this.imgList;
            this.lsvMyVocaSet.TabIndex = 0;
            this.lsvMyVocaSet.UseCompatibleStateImageBehavior = false;
            this.lsvMyVocaSet.View = System.Windows.Forms.View.Details;
            // 
            // vocaSet_id
            // 
            this.vocaSet_id.Text = "ID";
            // 
            // vocaSet_name
            // 
            this.vocaSet_name.Text = "Tên bộ từ";
            this.vocaSet_name.Width = 200;
            // 
            // vocaSet_mota
            // 
            this.vocaSet_mota.Text = "Mô tả";
            this.vocaSet_mota.Width = 600;
            // 
            // tabVoca
            // 
            this.tabVoca.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabVoca.Controls.Add(this.btnLearn);
            this.tabVoca.Controls.Add(this.btnPractice);
            this.tabVoca.Controls.Add(this.chkCheckAllVoca);
            this.tabVoca.Controls.Add(this.grbVocaSet);
            this.tabVoca.Controls.Add(this.cmbMode_Vocaset);
            this.tabVoca.Controls.Add(this.lblMode_VocaSet);
            this.tabVoca.Controls.Add(this.lblVocaSet);
            this.tabVoca.Controls.Add(this.lblDescribeVocaSet);
            this.tabVoca.Location = new System.Drawing.Point(4, 28);
            this.tabVoca.Name = "tabVoca";
            this.tabVoca.Padding = new System.Windows.Forms.Padding(3);
            this.tabVoca.Size = new System.Drawing.Size(976, 448);
            this.tabVoca.TabIndex = 1;
            this.tabVoca.Text = "Từ vựng";
            // 
            // btnLearn
            // 
            this.btnLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLearn.BackgroundImage")));
            this.btnLearn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearn.Location = new System.Drawing.Point(475, 95);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(42, 42);
            this.btnLearn.TabIndex = 16;
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // btnPractice
            // 
            this.btnPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPractice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPractice.BackgroundImage")));
            this.btnPractice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPractice.Location = new System.Drawing.Point(523, 95);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(42, 42);
            this.btnPractice.TabIndex = 15;
            this.btnPractice.UseVisualStyleBackColor = true;
            // 
            // chkCheckAllVoca
            // 
            this.chkCheckAllVoca.AutoSize = true;
            this.chkCheckAllVoca.Location = new System.Drawing.Point(91, 158);
            this.chkCheckAllVoca.Name = "chkCheckAllVoca";
            this.chkCheckAllVoca.Size = new System.Drawing.Size(15, 14);
            this.chkCheckAllVoca.TabIndex = 5;
            this.chkCheckAllVoca.UseVisualStyleBackColor = true;
            // 
            // grbVocaSet
            // 
            this.grbVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVocaSet.Controls.Add(this.txtDescribeVocaSet);
            this.grbVocaSet.Controls.Add(this.label1);
            this.grbVocaSet.Controls.Add(this.cmbVocaSetName);
            this.grbVocaSet.Controls.Add(this.lblVocaSetName);
            this.grbVocaSet.Location = new System.Drawing.Point(571, 6);
            this.grbVocaSet.Name = "grbVocaSet";
            this.grbVocaSet.Size = new System.Drawing.Size(397, 137);
            this.grbVocaSet.TabIndex = 4;
            this.grbVocaSet.TabStop = false;
            this.grbVocaSet.Text = "Bộ từ";
            // 
            // txtDescribeVocaSet
            // 
            this.txtDescribeVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescribeVocaSet.Location = new System.Drawing.Point(70, 53);
            this.txtDescribeVocaSet.Multiline = true;
            this.txtDescribeVocaSet.Name = "txtDescribeVocaSet";
            this.txtDescribeVocaSet.Size = new System.Drawing.Size(321, 78);
            this.txtDescribeVocaSet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mô tả:";
            // 
            // cmbVocaSetName
            // 
            this.cmbVocaSetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVocaSetName.FormattingEnabled = true;
            this.cmbVocaSetName.Location = new System.Drawing.Point(70, 20);
            this.cmbVocaSetName.Name = "cmbVocaSetName";
            this.cmbVocaSetName.Size = new System.Drawing.Size(321, 27);
            this.cmbVocaSetName.TabIndex = 1;
            // 
            // lblVocaSetName
            // 
            this.lblVocaSetName.AutoSize = true;
            this.lblVocaSetName.Location = new System.Drawing.Point(6, 23);
            this.lblVocaSetName.Name = "lblVocaSetName";
            this.lblVocaSetName.Size = new System.Drawing.Size(58, 19);
            this.lblVocaSetName.TabIndex = 0;
            this.lblVocaSetName.Text = "Tên bộ:";
            // 
            // cmbMode_Vocaset
            // 
            this.cmbMode_Vocaset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode_Vocaset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMode_Vocaset.FormattingEnabled = true;
            this.cmbMode_Vocaset.Items.AddRange(new object[] {
            "Từ vựng trong bộ từ này",
            "Từ vựng trong bộ từ này và bộ từ con"});
            this.cmbMode_Vocaset.Location = new System.Drawing.Point(64, 6);
            this.cmbMode_Vocaset.Name = "cmbMode_Vocaset";
            this.cmbMode_Vocaset.Size = new System.Drawing.Size(239, 27);
            this.cmbMode_Vocaset.TabIndex = 3;
            // 
            // lblMode_VocaSet
            // 
            this.lblMode_VocaSet.AutoSize = true;
            this.lblMode_VocaSet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode_VocaSet.Location = new System.Drawing.Point(7, 9);
            this.lblMode_VocaSet.Name = "lblMode_VocaSet";
            this.lblMode_VocaSet.Size = new System.Drawing.Size(61, 19);
            this.lblMode_VocaSet.TabIndex = 2;
            this.lblMode_VocaSet.Text = "Chế độ: ";
            // 
            // lblVocaSet
            // 
            this.lblVocaSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVocaSet.AutoSize = true;
            this.lblVocaSet.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocaSet.Location = new System.Drawing.Point(8, 113);
            this.lblVocaSet.Name = "lblVocaSet";
            this.lblVocaSet.Size = new System.Drawing.Size(188, 33);
            this.lblVocaSet.TabIndex = 1;
            this.lblVocaSet.Text = "Tên bộ từ vựng\r";
            // 
            // lblDescribeVocaSet
            // 
            this.lblDescribeVocaSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescribeVocaSet.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lblDescribeVocaSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lblDescribeVocaSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblDescribeVocaSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_voca_check,
            this.dgv_voca_name,
            this.dgv_meaning,
            this.dgv_voca_practiced,
            this.dgv_voca_ratio,
            this.dgv_vocaSet_id});
            this.lblDescribeVocaSet.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescribeVocaSet.Location = new System.Drawing.Point(6, 149);
            this.lblDescribeVocaSet.Name = "lblDescribeVocaSet";
            this.lblDescribeVocaSet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.lblDescribeVocaSet.Size = new System.Drawing.Size(962, 291);
            this.lblDescribeVocaSet.TabIndex = 0;
            // 
            // dgv_voca_check
            // 
            this.dgv_voca_check.HeaderText = "";
            this.dgv_voca_check.Name = "dgv_voca_check";
            // 
            // dgv_voca_name
            // 
            this.dgv_voca_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_voca_name.HeaderText = "Từ vựng";
            this.dgv_voca_name.Name = "dgv_voca_name";
            // 
            // dgv_meaning
            // 
            this.dgv_meaning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_meaning.HeaderText = "Nghĩa";
            this.dgv_meaning.Name = "dgv_meaning";
            // 
            // dgv_voca_practiced
            // 
            this.dgv_voca_practiced.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_voca_practiced.HeaderText = "Số lần luyện tập";
            this.dgv_voca_practiced.Name = "dgv_voca_practiced";
            this.dgv_voca_practiced.ReadOnly = true;
            // 
            // dgv_voca_ratio
            // 
            this.dgv_voca_ratio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_voca_ratio.HeaderText = "Tỉ lệ trả lời đúng";
            this.dgv_voca_ratio.Name = "dgv_voca_ratio";
            this.dgv_voca_ratio.ReadOnly = true;
            // 
            // dgv_vocaSet_id
            // 
            this.dgv_vocaSet_id.HeaderText = "Thuộc bộ từ vựng";
            this.dgv_vocaSet_id.Name = "dgv_vocaSet_id";
            this.dgv_vocaSet_id.Visible = false;
            // 
            // lblMain
            // 
            this.lblMain.AllowDrop = true;
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoEllipsis = true;
            this.lblMain.AutoSize = true;
            this.lblMain.Enabled = false;
            this.lblMain.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMain.Location = new System.Drawing.Point(348, 18);
            this.lblMain.Name = "lblMain";
            this.lblMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMain.Size = new System.Drawing.Size(270, 39);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "QH Study English";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QH StudyEnglish";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabVocaSet.ResumeLayout(false);
            this.tabVocaSet.PerformLayout();
            this.pnlQuickEditVocaSet.ResumeLayout(false);
            this.pnlEditVocaset.ResumeLayout(false);
            this.tabVoca.ResumeLayout(false);
            this.tabVoca.PerformLayout();
            this.grbVocaSet.ResumeLayout(false);
            this.grbVocaSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescribeVocaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabVocaSet;
        private System.Windows.Forms.Label lblMyVocaSet;
        private System.Windows.Forms.ListView lsvMyVocaSet;
        private System.Windows.Forms.TabPage tabVoca;
        private System.Windows.Forms.Button btnOpenVocaSet;
        private System.Windows.Forms.Button btnEditVocaSet;
        private System.Windows.Forms.Button btnRemoveVocaSet;
        private System.Windows.Forms.Button btnAddVocaSet;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ListView lsvRecommendedVocaSet;
        private System.Windows.Forms.Label lblRecommended;
        public System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ColumnHeader recommended_name;
        private System.Windows.Forms.ColumnHeader recommended_mota;
        private System.Windows.Forms.ColumnHeader vocaSet_id;
        private System.Windows.Forms.ColumnHeader vocaSet_name;
        private System.Windows.Forms.ColumnHeader vocaSet_mota;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.DataGridView lblDescribeVocaSet;
        private System.Windows.Forms.Label lblVocaSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_voca_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_voca_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_meaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_voca_practiced;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_voca_ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_vocaSet_id;
        private System.Windows.Forms.ComboBox cmbMode_Vocaset;
        private System.Windows.Forms.Label lblMode_VocaSet;
        private System.Windows.Forms.GroupBox grbVocaSet;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip tooltTip;
        private System.Windows.Forms.Panel pnlQuickEditVocaSet;
        private System.Windows.Forms.Panel pnlEditVocaset;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnAddByRegex;
        private System.Windows.Forms.CheckBox chkCheckAllVoca;
        private System.Windows.Forms.ComboBox cmbVocaSetName;
        private System.Windows.Forms.Label lblVocaSetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescribeVocaSet;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnLearn;
    }
}

