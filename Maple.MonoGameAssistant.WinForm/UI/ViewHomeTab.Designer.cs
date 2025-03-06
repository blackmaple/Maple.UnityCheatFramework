namespace Maple.MonoGameAssistant.WinForm
{
    partial class ViewHomeTab
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
            components = new System.ComponentModel.Container();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gcProcess = new DevExpress.XtraGrid.GridControl();
            gvProcess = new DevExpress.XtraGrid.Views.Grid.GridView();
            colProcessIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            RepItemProcessIcon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            colProcessId = new DevExpress.XtraGrid.Columns.GridColumn();
            colProcessName = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            BarMgr = new DevExpress.XtraBars.BarManager(components);
            BarTop = new DevExpress.XtraBars.Bar();
            BtnLoadProcess = new DevExpress.XtraBars.BarButtonItem();
            BtnShowJsonCode = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcProcess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvProcess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepItemProcessIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gcProcess);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 30);
            layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(809, 462);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gcProcess
            // 
            gcProcess.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            gcProcess.Location = new System.Drawing.Point(12, 12);
            gcProcess.MainView = gvProcess;
            gcProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gcProcess.Name = "gcProcess";
            gcProcess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { RepItemProcessIcon });
            gcProcess.Size = new System.Drawing.Size(785, 438);
            gcProcess.TabIndex = 4;
            gcProcess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvProcess });
            // 
            // gvProcess
            // 
            gvProcess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colProcessIcon, colProcessId, colProcessName });
            gvProcess.GridControl = gcProcess;
            gvProcess.Name = "gvProcess";
            gvProcess.OptionsFind.AlwaysVisible = true;
            gvProcess.OptionsView.EnableAppearanceEvenRow = true;
            gvProcess.OptionsView.ShowColumnHeaders = false;
            gvProcess.OptionsView.ShowGroupPanel = false;
            gvProcess.OptionsView.ShowViewCaption = true;
            gvProcess.ViewCaption = "ProcessView";
            // 
            // colProcessIcon
            // 
            colProcessIcon.AppearanceHeader.Options.UseTextOptions = true;
            colProcessIcon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colProcessIcon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colProcessIcon.Caption = "ProcessIcon";
            colProcessIcon.ColumnEdit = RepItemProcessIcon;
            colProcessIcon.FieldName = "ProcessIcon";
            colProcessIcon.MinWidth = 23;
            colProcessIcon.Name = "colProcessIcon";
            colProcessIcon.OptionsColumn.AllowEdit = false;
            colProcessIcon.OptionsColumn.ReadOnly = true;
            colProcessIcon.Visible = true;
            colProcessIcon.VisibleIndex = 0;
            colProcessIcon.Width = 86;
            // 
            // RepItemProcessIcon
            // 
            RepItemProcessIcon.Name = "RepItemProcessIcon";
            RepItemProcessIcon.NullText = " ";
            RepItemProcessIcon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // colProcessId
            // 
            colProcessId.AppearanceHeader.Options.UseTextOptions = true;
            colProcessId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colProcessId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colProcessId.Caption = "ProcessId";
            colProcessId.DisplayFormat.FormatString = "0x{0:X8}";
            colProcessId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colProcessId.FieldName = "ProcessId";
            colProcessId.MinWidth = 23;
            colProcessId.Name = "colProcessId";
            colProcessId.OptionsColumn.AllowEdit = false;
            colProcessId.OptionsColumn.ReadOnly = true;
            colProcessId.Visible = true;
            colProcessId.VisibleIndex = 1;
            colProcessId.Width = 86;
            // 
            // colProcessName
            // 
            colProcessName.AppearanceHeader.Options.UseTextOptions = true;
            colProcessName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colProcessName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colProcessName.Caption = "ProcessName";
            colProcessName.FieldName = "ProcessName";
            colProcessName.MinWidth = 23;
            colProcessName.Name = "colProcessName";
            colProcessName.OptionsColumn.AllowEdit = false;
            colProcessName.OptionsColumn.ReadOnly = true;
            colProcessName.Visible = true;
            colProcessName.VisibleIndex = 2;
            colProcessName.Width = 86;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(809, 462);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gcProcess;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(789, 442);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // BarMgr
            // 
            BarMgr.Bars.AddRange(new DevExpress.XtraBars.Bar[] { BarTop });
            BarMgr.DockControls.Add(barDockControlTop);
            BarMgr.DockControls.Add(barDockControlBottom);
            BarMgr.DockControls.Add(barDockControlLeft);
            BarMgr.DockControls.Add(barDockControlRight);
            BarMgr.Form = this;
            BarMgr.Items.AddRange(new DevExpress.XtraBars.BarItem[] { BtnLoadProcess, BtnShowJsonCode });
            BarMgr.MaxItemId = 4;
            // 
            // BarTop
            // 
            BarTop.BarName = "Custom 2";
            BarTop.DockCol = 0;
            BarTop.DockRow = 0;
            BarTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            BarTop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(BtnLoadProcess), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, BtnShowJsonCode, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            BarTop.OptionsBar.AllowQuickCustomization = false;
            BarTop.OptionsBar.DisableClose = true;
            BarTop.OptionsBar.DisableCustomization = true;
            BarTop.OptionsBar.DrawBorder = false;
            BarTop.OptionsBar.DrawDragBorder = false;
            BarTop.OptionsBar.UseWholeRow = true;
            BarTop.Text = "Custom 2";
            // 
            // BtnLoadProcess
            // 
            BtnLoadProcess.Id = 2;
            BtnLoadProcess.ImageOptions.SvgImage = Properties.Resources.Component;
            BtnLoadProcess.Name = "BtnLoadProcess";
            BtnLoadProcess.ItemClick += BtnLoadProcess_ItemClick;
            // 
            // BtnShowJsonCode
            // 
            BtnShowJsonCode.Caption = "Json2C#";
            BtnShowJsonCode.Id = 3;
            BtnShowJsonCode.Name = "BtnShowJsonCode";
            BtnShowJsonCode.ItemClick += BtnShowJsonCode_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarMgr;
            barDockControlTop.Size = new System.Drawing.Size(809, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            barDockControlBottom.Manager = BarMgr;
            barDockControlBottom.Size = new System.Drawing.Size(809, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            barDockControlLeft.Manager = BarMgr;
            barDockControlLeft.Size = new System.Drawing.Size(0, 462);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(809, 30);
            barDockControlRight.Manager = BarMgr;
            barDockControlRight.Size = new System.Drawing.Size(0, 462);
            // 
            // ViewHomeTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(809, 492);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ViewHomeTab";
            Text = "Process";
            Load += ViewHomeTab_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcProcess).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvProcess).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepItemProcessIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarMgr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcProcess;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessIcon;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessId;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit RepItemProcessIcon;
        private DevExpress.XtraBars.BarManager BarMgr;
        private DevExpress.XtraBars.Bar BarTop;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnLoadProcess;
        private DevExpress.XtraBars.BarButtonItem BtnShowJsonCode;
    }
}