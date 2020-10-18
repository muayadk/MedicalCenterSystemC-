namespace MedicalCenterManangement.View.DrageManagament
{
    partial class XtraFrmShapeFarmacy
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.shapeFarmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsfId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsfCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsfName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldragTab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sfCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sfNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForsfName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForsfCode = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeFarmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsfName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsfCode)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "أضافة";
            this.barButtonItem1.Id = 0;
           // this.barButtonItem1.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.actions_add1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "حفظ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.saveas2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "حذف ";
            this.barButtonItem3.Id = 2;
           // this.barButtonItem3.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.deletetable2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "الغاء";
            this.barButtonItem4.Id = 3;
            //this.barButtonItem4.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.actions_deletecircled1;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1061, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 614);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1061, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 576);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1061, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 576);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataLayoutControl2);
            this.dataLayoutControl1.Controls.Add(this.sfCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.sfNameTextEdit);
            this.dataLayoutControl1.DataSource = this.shapeFarmacyBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 327, 812, 500);
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1061, 580);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.gridControl1);
            this.dataLayoutControl2.Location = new System.Drawing.Point(12, 46);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl2.Root = this.Root;
            this.dataLayoutControl2.Size = new System.Drawing.Size(1037, 522);
            this.dataLayoutControl2.TabIndex = 6;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.shapeFarmacyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1013, 498);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // shapeFarmacyBindingSource
            // 
            this.shapeFarmacyBindingSource.DataSource = typeof(MedicalCenterManangement.DataModeView.shapeFarmacy);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsfId,
            this.colsfCode,
            this.colsfName,
            this.colisDeleted,
            this.coldragTab});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colsfId
            // 
            this.colsfId.Caption = "الرقم";
            this.colsfId.FieldName = "sfId";
            this.colsfId.MinWidth = 25;
            this.colsfId.Name = "colsfId";
            this.colsfId.Visible = true;
            this.colsfId.VisibleIndex = 0;
            this.colsfId.Width = 94;
            // 
            // colsfCode
            // 
            this.colsfCode.Caption = "رقم الكود";
            this.colsfCode.FieldName = "sfCode";
            this.colsfCode.MinWidth = 25;
            this.colsfCode.Name = "colsfCode";
            this.colsfCode.Visible = true;
            this.colsfCode.VisibleIndex = 1;
            this.colsfCode.Width = 94;
            // 
            // colsfName
            // 
            this.colsfName.Caption = "اسم الشكل";
            this.colsfName.FieldName = "sfName";
            this.colsfName.MinWidth = 25;
            this.colsfName.Name = "colsfName";
            this.colsfName.Visible = true;
            this.colsfName.VisibleIndex = 2;
            this.colsfName.Width = 94;
            // 
            // colisDeleted
            // 
            this.colisDeleted.FieldName = "isDeleted";
            this.colisDeleted.MinWidth = 25;
            this.colisDeleted.Name = "colisDeleted";
            this.colisDeleted.Visible = true;
            this.colisDeleted.VisibleIndex = 3;
            this.colisDeleted.Width = 94;
            // 
            // coldragTab
            // 
            this.coldragTab.FieldName = "dragTab";
            this.coldragTab.MinWidth = 25;
            this.coldragTab.Name = "coldragTab";
            this.coldragTab.Visible = true;
            this.coldragTab.VisibleIndex = 4;
            this.coldragTab.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1037, 522);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1017, 502);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // sfCodeTextEdit
            // 
            this.sfCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shapeFarmacyBindingSource, "sfCode", true));
            this.sfCodeTextEdit.Location = new System.Drawing.Point(725, 12);
            this.sfCodeTextEdit.MenuManager = this.barManager1;
            this.sfCodeTextEdit.Name = "sfCodeTextEdit";
            this.sfCodeTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sfCodeTextEdit.Size = new System.Drawing.Size(189, 30);
            this.sfCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.sfCodeTextEdit.TabIndex = 4;
            // 
            // sfNameTextEdit
            // 
            this.sfNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shapeFarmacyBindingSource, "sfName", true));
            this.sfNameTextEdit.Location = new System.Drawing.Point(12, 12);
            this.sfNameTextEdit.MenuManager = this.barManager1;
            this.sfNameTextEdit.Name = "sfNameTextEdit";
            this.sfNameTextEdit.Size = new System.Drawing.Size(574, 30);
            this.sfNameTextEdit.StyleController = this.dataLayoutControl1;
            this.sfNameTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1061, 580);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.ItemForsfName,
            this.ItemForsfCode});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1041, 560);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1041, 526);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForsfName
            // 
            this.ItemForsfName.Control = this.sfNameTextEdit;
            this.ItemForsfName.Location = new System.Drawing.Point(0, 0);
            this.ItemForsfName.Name = "ItemForsfName";
            this.ItemForsfName.Size = new System.Drawing.Size(713, 34);
            this.ItemForsfName.Text = "اسم الشكل الصيدلاني";
            this.ItemForsfName.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForsfName.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForsfCode
            // 
            this.ItemForsfCode.Control = this.sfCodeTextEdit;
            this.ItemForsfCode.Location = new System.Drawing.Point(713, 0);
            this.ItemForsfCode.Name = "ItemForsfCode";
            this.ItemForsfCode.Size = new System.Drawing.Size(328, 34);
            this.ItemForsfCode.Text = "رقم الكود";
            this.ItemForsfCode.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForsfCode.TextSize = new System.Drawing.Size(132, 17);
            // 
            // XtraFrmShapeFarmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 645);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraFrmShapeFarmacy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "XtraFrmShapeFarmacy";
            this.Load += new System.EventHandler(this.XtraFrmShapeFarmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeFarmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsfName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsfCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource shapeFarmacyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsfId;
        private DevExpress.XtraGrid.Columns.GridColumn colsfCode;
        private DevExpress.XtraGrid.Columns.GridColumn colsfName;
        private DevExpress.XtraGrid.Columns.GridColumn colisDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn coldragTab;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit sfCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit sfNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForsfName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForsfCode;
    }
}