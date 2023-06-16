using System;
using System.Drawing;
using System.Windows.Forms;
using ALX.Common.UI.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace ALX.Common.UI
{
    public static class Dialog
    {
        #region Общий вызов Dialog для UI клиентских модулей

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Yes</returns>
        public static DialogResult CallDialogSaveClose(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsSaveClose(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки [Подготовить] [Отмена]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Yes</returns>
        public static DialogResult CallDialogPrepareClose(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsPrepareClose(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки диалога: [OK]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Ok</returns>
        public static DialogResult CallDialogOk(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsButtonsOk(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки диалога: [Закрыть]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Cancel</returns>
        public static DialogResult CallDialogClose(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsButtonsClose(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки диалога: [OK] [Отмена]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Ok</returns>
        public static DialogResult CallDialogOkCancel(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsButtonsOkCancel(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки диалога: [Да] [Нет]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Ok</returns>
        public static DialogResult CallDialogYesNo(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsButtonsYesNo(control, title));
            return dialogResult;
        }

        /// <summary>
        /// Dialog для UI клиентских модулей
        /// <para>Кнопки диалога: [Отправить] [Отмена]</para>
        /// </summary>
        /// <param name="control">Пользовательский компонент для отображения в диалоге</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns>DialogResult.Ok</returns>
        public static DialogResult CallDialogSendCancel(Control control, string title)
        {
            DialogResult dialogResult = XtraDialog.Show(GetXtraDialogArgsButtonsSendCancel(control, title));
            return dialogResult;
        }

        #endregion

        #region PRIVATE

        #region [OK]

        private static XtraDialogArgs GetXtraDialogArgsButtonsOk(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.OK }
            };

            args.Showing += PrepareDialogButtonsOk();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsOk()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.OK].Image = Resources.ok_16;
                e.Buttons[DialogResult.OK].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.OK].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion

        #region [Close]

        private static XtraDialogArgs GetXtraDialogArgsButtonsClose(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                DefaultButtonIndex = 0, // DialogResult.Cancel => AcceptButton
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>"
            };

            args.Showing += PrepareDialogButtonsClose();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsClose()
        {
            return (sender, e) =>
            {
                e.Form.AcceptButton = null;

                SimpleButton closeButton = e.Buttons[DialogResult.Cancel];
                closeButton.Image = Resources.close_16;
                closeButton.Width += 25;
                closeButton.Text = Settings.Default.CloseButtonText;
                closeButton.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                closeButton.Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion

        #region [Да] [Нет]

        private static XtraDialogArgs GetXtraDialogArgsButtonsYesNo(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.No }
            };

            args.Showing += PrepareDialogButtonsYesNo();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsYesNo()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.Yes].Image = Resources.ok_16;
                e.Buttons[DialogResult.Yes].Text = Settings.Default.YesButtonText;
                e.Buttons[DialogResult.Yes].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Yes].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.No].Image = Resources.cancel_16;
                e.Buttons[DialogResult.No].Text = Settings.Default.NoButtonText;
                e.Buttons[DialogResult.No].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.No].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion

        #region [OK] [Отмена]

        private static XtraDialogArgs GetXtraDialogArgsButtonsOkCancel(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.OK, DialogResult.Cancel }
            };

            args.Showing += PrepareDialogButtonsOkCancel();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsOkCancel()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.OK].Image = Resources.ok_16;
                e.Buttons[DialogResult.OK].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.OK].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
                e.Buttons[DialogResult.Cancel].Image = Resources.cancel_16;
                e.Buttons[DialogResult.Cancel].Text = Settings.Default.CancelButtonText;
                e.Buttons[DialogResult.Cancel].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Cancel].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion

        #region [Сохранить] [Закрыть]

        private static XtraDialogArgs GetXtraDialogArgsSaveClose(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                DefaultButtonIndex = 1,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new [] { DialogResult.Yes, DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>"
            };

            args.Showing += PrepareDialogButtonsSaveClose();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsSaveClose()
        {
            return (sender, e) =>
            {
                // Настроить кнопку [Сохранить]
                SimpleButton saveButton = e.Buttons[DialogResult.Yes];
                saveButton.Image = Resources.Save_16;
                saveButton.Width += 25;
                saveButton.Text = Settings.Default.SaveButtonText;
                saveButton.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                saveButton.Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                // Настроить кнопку [Закрыть]
                SimpleButton closeButton = e.Buttons[DialogResult.Cancel];
                closeButton.Image = Resources.close_16;
                closeButton.Width += 25;
                closeButton.Text = Settings.Default.CloseButtonText;
                closeButton.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                closeButton.Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                // Переопределить AcceptButton на кнопку [Сохранить]
                e.Form.AcceptButton = saveButton;
            };
        }

        #endregion

        #region [Подготовить] [Отмена]

        private static XtraDialogArgs GetXtraDialogArgsPrepareClose(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                DefaultButtonIndex = 1,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>"
            };

            args.Showing += PrepareDialogButtonsPrepareClose();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsPrepareClose()
        {
            return (sender, e) =>
            {
                // Настроить кнопку [Подготовить]
                SimpleButton saveButton = e.Buttons[DialogResult.Yes];
                saveButton.Image = Resources.ok_16;
                saveButton.Width += 30;
                saveButton.Text = Settings.Default.PrepareButtonText;
                saveButton.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                saveButton.Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                // Настроить кнопку [Закрыть]
                SimpleButton closeButton = e.Buttons[DialogResult.Cancel];
                closeButton.Image = Resources.close_16;
                closeButton.Width += 25;
                closeButton.Text = Settings.Default.CloseButtonText;
                closeButton.ImageToTextAlignment = ImageAlignToText.LeftCenter;
                closeButton.Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                // Переопределить AcceptButton на кнопку [Сохранить]
                e.Form.AcceptButton = saveButton;
            };
        }

        #endregion

        #region [Отправить] [Отмена]

        private static XtraDialogArgs GetXtraDialogArgsButtonsSendCancel(Control control, string title)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraDialogArgs args = new XtraDialogArgs
            {
                Content = control,
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.OK, DialogResult.Cancel }
            };

            args.Showing += PrepareDialogButtonsSendCancel();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareDialogButtonsSendCancel()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.OK].Width += 25;
                e.Buttons[DialogResult.OK].Image = Resources.message_16;
                e.Buttons[DialogResult.OK].Text = Settings.Default.SendButtonText;
                e.Buttons[DialogResult.OK].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.OK].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.Cancel].Width += 25;
                e.Buttons[DialogResult.Cancel].Image = Resources.cancel_16;
                e.Buttons[DialogResult.Cancel].Text = Settings.Default.CancelButtonText;
                e.Buttons[DialogResult.Cancel].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Cancel].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion

        #endregion
    }
}
