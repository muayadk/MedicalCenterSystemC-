namespace MedicalCenterManangement.View.PatientTeartment
{
    partial class FrmPreview
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
            this.getNameDoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.ln = new DevExpress.XtraEditors.LabelControl();
            this.txtprNote = new DevExpress.XtraEditors.TextEdit();
            this.txtviId = new DevExpress.XtraEditors.TextEdit();
            this.txtprName = new DevExpress.XtraEditors.TextEdit();
            this.txtprCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtpaName = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl46 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl47 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.datepreview = new DevExpress.XtraEditors.DateEdit();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timepreview = new DevExpress.XtraEditors.TimeSpanEdit();
            ((System.ComponentModel.ISupportInitialize)(this.getNameDoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtviId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datepreview.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datepreview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepreview.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // getNameDoctorsBindingSource
            // 
            this.getNameDoctorsBindingSource.DataMember = "getNameDoctors";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BorderColor = System.Drawing.Color.Teal;
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.Controls.Add(this.btnClose);
            this.groupControl4.Controls.Add(this.btnsave);
            this.groupControl4.Location = new System.Drawing.Point(3, 325);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(540, 96);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "الاجراءات";
            this.groupControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl4_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.redo;
            this.btnClose.Location = new System.Drawing.Point(22, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(248, 62);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "تراجع للخلف";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Appearance.Options.UseForeColor = true;
            this.btnsave.ImageOptions.SvgImage = global::MedicalCenterManangement.Properties.Resources.colors;
            this.btnsave.Location = new System.Drawing.Point(301, 31);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(239, 62);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "حـــــــفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(111, 0);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(0, 16);
            this.ln.TabIndex = 39;
            // 
            // txtprNote
            // 
            this.txtprNote.Location = new System.Drawing.Point(22, 272);
            this.txtprNote.Name = "txtprNote";
            this.txtprNote.Properties.AutoHeight = false;
            this.txtprNote.Size = new System.Drawing.Size(273, 30);
            this.txtprNote.TabIndex = 37;
            // 
            // txtviId
            // 
            this.txtviId.Location = new System.Drawing.Point(22, 82);
            this.txtviId.Name = "txtviId";
            this.txtviId.Properties.AutoHeight = false;
            this.txtviId.Properties.ReadOnly = true;
            this.txtviId.Size = new System.Drawing.Size(273, 30);
            this.txtviId.TabIndex = 36;
            // 
            // txtprName
            // 
            this.txtprName.Location = new System.Drawing.Point(22, 159);
            this.txtprName.Name = "txtprName";
            this.txtprName.Properties.AutoHeight = false;
            this.txtprName.Size = new System.Drawing.Size(273, 30);
            this.txtprName.TabIndex = 33;
            // 
            // txtprCode
            // 
            this.txtprCode.Location = new System.Drawing.Point(22, 118);
            this.txtprCode.Name = "txtprCode";
            this.txtprCode.Properties.AutoHeight = false;
            this.txtprCode.Size = new System.Drawing.Size(273, 30);
            this.txtprCode.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(401, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 25);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "المريض";
            // 
            // txtpaName
            // 
            this.txtpaName.Location = new System.Drawing.Point(22, 40);
            this.txtpaName.Name = "txtpaName";
            this.txtpaName.Properties.AutoHeight = false;
            this.txtpaName.Properties.ReadOnly = true;
            this.txtpaName.Size = new System.Drawing.Size(273, 30);
            this.txtpaName.TabIndex = 1;
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl43.Appearance.Options.UseFont = true;
            this.labelControl43.Location = new System.Drawing.Point(390, 277);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(53, 25);
            this.labelControl43.TabIndex = 25;
            this.labelControl43.Text = "ملاحظات";
            // 
            // labelControl45
            // 
            this.labelControl45.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl45.Appearance.Options.UseFont = true;
            this.labelControl45.Location = new System.Drawing.Point(371, 194);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(72, 25);
            this.labelControl45.TabIndex = 21;
            this.labelControl45.Text = "وقت المعاينة";
            // 
            // labelControl46
            // 
            this.labelControl46.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl46.Appearance.Options.UseFont = true;
            this.labelControl46.Location = new System.Drawing.Point(401, 163);
            this.labelControl46.Name = "labelControl46";
            this.labelControl46.Size = new System.Drawing.Size(42, 25);
            this.labelControl46.TabIndex = 19;
            this.labelControl46.Text = "المعاينة";
            // 
            // labelControl47
            // 
            this.labelControl47.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl47.Appearance.Options.UseFont = true;
            this.labelControl47.Location = new System.Drawing.Point(371, 247);
            this.labelControl47.Name = "labelControl47";
            this.labelControl47.Size = new System.Drawing.Size(72, 25);
            this.labelControl47.TabIndex = 17;
            this.labelControl47.Text = "تاريخ المعاينة";
            // 
            // labelControl48
            // 
            this.labelControl48.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl48.Appearance.Options.UseFont = true;
            this.labelControl48.Location = new System.Drawing.Point(385, 122);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(58, 25);
            this.labelControl48.TabIndex = 15;
            this.labelControl48.Text = "رقم الكود";
            // 
            // datepreview
            // 
            this.datepreview.EditValue = null;
            this.datepreview.Location = new System.Drawing.Point(22, 236);
            this.datepreview.Name = "datepreview";
            this.datepreview.Properties.AutoHeight = false;
            this.datepreview.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datepreview.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datepreview.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.datepreview.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datepreview.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.datepreview.Size = new System.Drawing.Size(273, 30);
            this.datepreview.TabIndex = 34;
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl44.Appearance.Options.UseFont = true;
            this.labelControl44.Location = new System.Drawing.Point(418, 237);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(0, 25);
            this.labelControl44.TabIndex = 23;
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.Teal;
            this.groupControl5.Appearance.BorderColor = System.Drawing.Color.Teal;
            this.groupControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.Appearance.Options.UseBorderColor = true;
            this.groupControl5.Appearance.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl5.Controls.Add(this.labelControl2);
            this.groupControl5.Controls.Add(this.ln);
            this.groupControl5.Controls.Add(this.txtprNote);
            this.groupControl5.Controls.Add(this.txtviId);
            this.groupControl5.Controls.Add(this.txtprName);
            this.groupControl5.Controls.Add(this.txtprCode);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Controls.Add(this.txtpaName);
            this.groupControl5.Controls.Add(this.labelControl43);
            this.groupControl5.Controls.Add(this.labelControl44);
            this.groupControl5.Controls.Add(this.labelControl45);
            this.groupControl5.Controls.Add(this.labelControl46);
            this.groupControl5.Controls.Add(this.labelControl47);
            this.groupControl5.Controls.Add(this.labelControl48);
            this.groupControl5.Controls.Add(this.datepreview);
            this.groupControl5.Controls.Add(this.timepreview);
            this.groupControl5.Location = new System.Drawing.Point(3, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl5.Size = new System.Drawing.Size(540, 314);
            this.groupControl5.TabIndex = 7;
            this.groupControl5.Text = "معاينة المريض";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(383, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 25);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "رقم الزيارة";
            // 
            // timepreview
            // 
            this.timepreview.EditValue = null;
            this.timepreview.Location = new System.Drawing.Point(22, 194);
            this.timepreview.Name = "timepreview";
            this.timepreview.Properties.AllowEditDays = false;
            this.timepreview.Properties.AllowEditSeconds = false;
            this.timepreview.Properties.AutoHeight = false;
            this.timepreview.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timepreview.Properties.DisplayFormat.FormatString = "d";
            this.timepreview.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timepreview.Properties.EditFormat.FormatString = "d";
            this.timepreview.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timepreview.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.timepreview.Properties.Mask.EditMask = "";
            this.timepreview.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.timepreview.Properties.MaxHours = 12;
            this.timepreview.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.timepreview.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons;
            this.timepreview.Size = new System.Drawing.Size(273, 30);
            this.timepreview.TabIndex = 6;
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 421);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl5);
            this.Name = "FrmPreview";
            this.Text = "FrmPreview";
            this.Load += new System.EventHandler(this.FrmPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getNameDoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtprNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtviId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datepreview.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datepreview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepreview.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource getNameDoctorsBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.LabelControl ln;
        private DevExpress.XtraEditors.TextEdit txtprNote;
        private DevExpress.XtraEditors.TextEdit txtviId;
        private DevExpress.XtraEditors.TextEdit txtprName;
        private DevExpress.XtraEditors.TextEdit txtprCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtpaName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.LabelControl labelControl46;
        private DevExpress.XtraEditors.LabelControl labelControl47;
        private DevExpress.XtraEditors.LabelControl labelControl48;
        private DevExpress.XtraEditors.DateEdit datepreview;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TimeSpanEdit timepreview;
    }
}