using System;
using System.Drawing;
using ALX.Common.UI.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraWaitForm;

namespace ALX.Common.UI.Forms
{
    public partial class LoadingForm : WaitForm
    {
        public LoadingForm()
        {
            InitializeComponent();
            ChangeLoadingPicture();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void ChangeLoadingPicture()
        {
            Skin commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            var loadingBig = commonSkin["LoadingBig"];
            loadingBig.Image.SetImage(Resources.loading_logo_1_transparent, Color.Empty);
            progressPanel1.LookAndFeel.Style = LookAndFeelStyle.Office2003;
            progressPanel1.LookAndFeel.SkinName = commonSkin.Name;
        }
    }
}