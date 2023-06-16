namespace ALX.Common.UI.Controls
{
    partial class ErrorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layCtrlError = new DevExpress.XtraLayout.LayoutControl();
            this.btnCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.scrollCtrl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lblMessageCaption = new DevExpress.XtraEditors.LabelControl();
            this.memoExEditErrorDitails = new DevExpress.XtraEditors.MemoExEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layCtrlGrDetails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layItemDetails = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layCtrlItemMessageCaption = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCaption = new DevExpress.XtraLayout.SimpleLabelItem();
            this.separatorCaption = new DevExpress.XtraLayout.SimpleSeparator();
            this.layItemClipboard = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureEdtErr = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlError)).BeginInit();
            this.layCtrlError.SuspendLayout();
            this.scrollCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditErrorDitails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlGrDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlItemMessageCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layItemClipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdtErr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layCtrlError
            // 
            this.layCtrlError.Controls.Add(this.btnCopyToClipboard);
            this.layCtrlError.Controls.Add(this.scrollCtrl);
            this.layCtrlError.Controls.Add(this.memoExEditErrorDitails);
            this.layCtrlError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layCtrlError.Location = new System.Drawing.Point(96, 0);
            this.layCtrlError.Name = "layCtrlError";
            this.layCtrlError.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(635, 496, 650, 400);
            this.layCtrlError.Root = this.Root;
            this.layCtrlError.Size = new System.Drawing.Size(404, 110);
            this.layCtrlError.TabIndex = 0;
            this.layCtrlError.Text = "layoutControl1";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCopyToClipboard.Appearance.Options.UseFont = true;
            this.btnCopyToClipboard.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCopyToClipboard.AppearanceDisabled.Options.UseFont = true;
            this.btnCopyToClipboard.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCopyToClipboard.AppearanceHovered.Options.UseFont = true;
            this.btnCopyToClipboard.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCopyToClipboard.AppearancePressed.Options.UseFont = true;
            this.btnCopyToClipboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyToClipboard.ImageOptions.Image")));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(283, 4);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(117, 23);
            this.btnCopyToClipboard.StyleController = this.layCtrlError;
            this.btnCopyToClipboard.TabIndex = 28;
            this.btnCopyToClipboard.Text = "Копировать";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // scrollCtrl
            // 
            this.scrollCtrl.Controls.Add(this.lblMessageCaption);
            this.scrollCtrl.Location = new System.Drawing.Point(4, 33);
            this.scrollCtrl.MaximumSize = new System.Drawing.Size(390, 185);
            this.scrollCtrl.Name = "scrollCtrl";
            this.scrollCtrl.Size = new System.Drawing.Size(390, 45);
            this.scrollCtrl.TabIndex = 27;
            // 
            // lblMessageCaption
            // 
            this.lblMessageCaption.AllowHtmlString = true;
            this.lblMessageCaption.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.lblMessageCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMessageCaption.Appearance.Options.UseFont = true;
            this.lblMessageCaption.Appearance.Options.UseTextOptions = true;
            this.lblMessageCaption.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.lblMessageCaption.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMessageCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessageCaption.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMessageCaption.AppearanceDisabled.Options.UseFont = true;
            this.lblMessageCaption.AppearanceDisabled.Options.UseTextOptions = true;
            this.lblMessageCaption.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.lblMessageCaption.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMessageCaption.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessageCaption.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMessageCaption.AppearanceHovered.Options.UseFont = true;
            this.lblMessageCaption.AppearanceHovered.Options.UseTextOptions = true;
            this.lblMessageCaption.AppearanceHovered.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.lblMessageCaption.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMessageCaption.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessageCaption.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMessageCaption.AppearancePressed.Options.UseFont = true;
            this.lblMessageCaption.AppearancePressed.Options.UseTextOptions = true;
            this.lblMessageCaption.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.lblMessageCaption.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMessageCaption.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessageCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblMessageCaption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblMessageCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessageCaption.Location = new System.Drawing.Point(0, 0);
            this.lblMessageCaption.Name = "lblMessageCaption";
            this.lblMessageCaption.Size = new System.Drawing.Size(390, 16);
            this.lblMessageCaption.TabIndex = 26;
            this.lblMessageCaption.Text = "Непредвиденное исключение";
            // 
            // memoExEditErrorDitails
            // 
            this.memoExEditErrorDitails.Location = new System.Drawing.Point(63, 84);
            this.memoExEditErrorDitails.Name = "memoExEditErrorDitails";
            this.memoExEditErrorDitails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoExEditErrorDitails.Properties.Appearance.Options.UseFont = true;
            this.memoExEditErrorDitails.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoExEditErrorDitails.Properties.AppearanceDisabled.Options.UseFont = true;
            this.memoExEditErrorDitails.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoExEditErrorDitails.Properties.AppearanceDropDown.Options.UseFont = true;
            this.memoExEditErrorDitails.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoExEditErrorDitails.Properties.AppearanceFocused.Options.UseFont = true;
            this.memoExEditErrorDitails.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoExEditErrorDitails.Properties.AppearanceReadOnly.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::ALX.Common.UI.Properties.Resources.arrow_down_16;
            this.memoExEditErrorDitails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.memoExEditErrorDitails.Properties.ReadOnly = true;
            this.memoExEditErrorDitails.Properties.ShowIcon = false;
            this.memoExEditErrorDitails.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.memoExEditErrorDitails.Size = new System.Drawing.Size(337, 22);
            this.memoExEditErrorDitails.StyleController = this.layCtrlError;
            this.memoExEditErrorDitails.TabIndex = 25;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(404, 110);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layCtrlGrDetails,
            this.layCtrlItemMessageCaption,
            this.lblCaption,
            this.separatorCaption,
            this.layItemClipboard});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 106);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layCtrlGrDetails
            // 
            this.layCtrlGrDetails.GroupBordersVisible = false;
            this.layCtrlGrDetails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layItemDetails,
            this.simpleSeparator1});
            this.layCtrlGrDetails.Location = new System.Drawing.Point(0, 78);
            this.layCtrlGrDetails.Name = "layCtrlGrDetails";
            this.layCtrlGrDetails.Size = new System.Drawing.Size(400, 28);
            // 
            // layItemDetails
            // 
            this.layItemDetails.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layItemDetails.AppearanceItemCaption.Options.UseFont = true;
            this.layItemDetails.Control = this.memoExEditErrorDitails;
            this.layItemDetails.Location = new System.Drawing.Point(0, 2);
            this.layItemDetails.Name = "layItemDetails";
            this.layItemDetails.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layItemDetails.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layItemDetails.Size = new System.Drawing.Size(400, 26);
            this.layItemDetails.Text = "Детали:";
            this.layItemDetails.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layItemDetails.TextLocation = DevExpress.Utils.Locations.Left;
            this.layItemDetails.TextSize = new System.Drawing.Size(54, 16);
            this.layItemDetails.TextToControlDistance = 5;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(400, 2);
            // 
            // layCtrlItemMessageCaption
            // 
            this.layCtrlItemMessageCaption.AllowHtmlStringInCaption = true;
            this.layCtrlItemMessageCaption.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layCtrlItemMessageCaption.AppearanceItemCaption.Options.UseFont = true;
            this.layCtrlItemMessageCaption.Control = this.scrollCtrl;
            this.layCtrlItemMessageCaption.Location = new System.Drawing.Point(0, 29);
            this.layCtrlItemMessageCaption.Name = "layCtrlItemMessageCaption";
            this.layCtrlItemMessageCaption.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layCtrlItemMessageCaption.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layCtrlItemMessageCaption.Size = new System.Drawing.Size(400, 49);
            this.layCtrlItemMessageCaption.Text = "Произошла ошибка";
            this.layCtrlItemMessageCaption.TextLocation = DevExpress.Utils.Locations.Top;
            this.layCtrlItemMessageCaption.TextSize = new System.Drawing.Size(0, 0);
            this.layCtrlItemMessageCaption.TextVisible = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AllowHotTrack = false;
            this.lblCaption.AllowHtmlStringInCaption = true;
            this.lblCaption.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCaption.AppearanceItemCaption.Options.UseFont = true;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCaption.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.lblCaption.OptionsToolTip.AllowHtmlString = DevExpress.Utils.DefaultBoolean.True;
            this.lblCaption.Size = new System.Drawing.Size(279, 27);
            this.lblCaption.Text = "Произошла ошибка";
            this.lblCaption.TextSize = new System.Drawing.Size(114, 16);
            // 
            // separatorCaption
            // 
            this.separatorCaption.AllowHotTrack = false;
            this.separatorCaption.Location = new System.Drawing.Point(0, 27);
            this.separatorCaption.Name = "separatorCaption";
            this.separatorCaption.Size = new System.Drawing.Size(400, 2);
            // 
            // layItemClipboard
            // 
            this.layItemClipboard.Control = this.btnCopyToClipboard;
            this.layItemClipboard.Location = new System.Drawing.Point(279, 0);
            this.layItemClipboard.MaxSize = new System.Drawing.Size(121, 27);
            this.layItemClipboard.MinSize = new System.Drawing.Size(121, 27);
            this.layItemClipboard.Name = "layItemClipboard";
            this.layItemClipboard.Size = new System.Drawing.Size(121, 27);
            this.layItemClipboard.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layItemClipboard.TextSize = new System.Drawing.Size(0, 0);
            this.layItemClipboard.TextVisible = false;
            // 
            // pictureEdtErr
            // 
            this.pictureEdtErr.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdtErr.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdtErr.EditValue = global::ALX.Common.UI.Properties.Resources.error_64;
            this.pictureEdtErr.Location = new System.Drawing.Point(0, 0);
            this.pictureEdtErr.MaximumSize = new System.Drawing.Size(96, 0);
            this.pictureEdtErr.Name = "pictureEdtErr";
            this.pictureEdtErr.Properties.AllowFocused = false;
            this.pictureEdtErr.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdtErr.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdtErr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdtErr.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.pictureEdtErr.Properties.ReadOnly = true;
            this.pictureEdtErr.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdtErr.Properties.ShowMenu = false;
            this.pictureEdtErr.Size = new System.Drawing.Size(96, 110);
            this.pictureEdtErr.TabIndex = 21;
            // 
            // ErrorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.layCtrlError);
            this.Controls.Add(this.pictureEdtErr);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 110);
            this.Name = "ErrorControl";
            this.Size = new System.Drawing.Size(500, 110);
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlError)).EndInit();
            this.layCtrlError.ResumeLayout(false);
            this.scrollCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditErrorDitails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlGrDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCtrlItemMessageCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layItemClipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdtErr.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layCtrlError;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PictureEdit pictureEdtErr;
        private DevExpress.XtraEditors.MemoExEdit memoExEditErrorDitails;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layItemDetails;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlGroup layCtrlGrDetails;
        private DevExpress.XtraEditors.XtraScrollableControl scrollCtrl;
        private DevExpress.XtraEditors.LabelControl lblMessageCaption;
        private DevExpress.XtraLayout.LayoutControlItem layCtrlItemMessageCaption;
        private DevExpress.XtraLayout.SimpleLabelItem lblCaption;
        private DevExpress.XtraLayout.SimpleSeparator separatorCaption;
        private DevExpress.XtraEditors.SimpleButton btnCopyToClipboard;
        private DevExpress.XtraLayout.LayoutControlItem layItemClipboard;
    }
}
