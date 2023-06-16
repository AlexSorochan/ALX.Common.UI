using System;
using System.Drawing;
using System.Windows.Forms;
using ALX.Common.UI.Controls;
using ALX.Common.UI.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace ALX.Common.UI
{
    /// <summary>
    /// Перечисление типов сообщения
    /// </summary>
    public enum MessageTypes
    {
        /// <summary>
        /// Неопределенный
        /// </summary>
        None,
        /// <summary>
        /// Ошибка
        /// </summary>
        Error,
        /// <summary>
        /// Предупреждение
        /// </summary>
        Warning,
        /// <summary>
        /// Сведения
        /// </summary>
        Information
    }
    
    /// <summary>
    /// Диалоговое окно сообщения
    /// </summary>
    public static class MessageBox
    {
        #region СООБЩЕНИЯ ИНФОРМАЦИЯ / ПРЕДУПРЕЖДЕНИЕ / ОШИБКА

        /// <summary>
        /// Информационное сообщение
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        public static void Information(string caption, string title = "Сведения")
        {
            XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsOk(title, caption, Resources.information));
        }

        /// <summary>
        /// Предупреждающее сообщение
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        public static void Warning(string caption, string title = "Внимание")
        {
            ErrorControl.ErrorControlArgs args = new ErrorControl.ErrorControlArgs
            {
                MessageType = MessageTypes.Warning,
                Message = caption
            };

            ErrorControl control = new ErrorControl(args)
            {
                AutoSize = true
            };

            Dialog.CallDialogOk(control: control, title: title);
        }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        /// <param name="exception">Ошибка</param>
        public static void Error(string caption, string title = "Ошибка", Exception exception = null)
        {
            ErrorControl.ErrorControlArgs args = new ErrorControl.ErrorControlArgs
            {
                MessageType = MessageTypes.Error,
                Message = caption,
                ErrorDetails = exception?.ToString() ?? string.Empty
            };

            ErrorControl control = new ErrorControl(args)
            {
                AutoSize = true
            };

            Dialog.CallDialogOk(control: control, title: title);
        }

        #endregion

        #region ДИАЛОГ С ВОПРОСОМ

        /// <summary>
        /// Диалог-предупреждение с вопросом (ОК, Отмена)
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        /// <returns>Результат диалога</returns>
        public static DialogResult QuestionWarningOkCancel(string title, string caption)
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsOkCancel(title, caption, Resources.warning));
        }

        /// <summary>
        /// Диалог-предупреждение с вопросом (Да, Нет)
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        /// <returns>Результат диалога</returns>
        public static DialogResult QuestionWarningYesNo(string caption, string title = "Внимание")
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsYesNo(title, caption, Resources.warning));
        }

        /// <summary>
        /// Диалог с вопросом (Отправить, Отмета)
        /// </summary>
        /// <param name="caption">Вопрос</param>
        /// <param name="title">Заголовок диалога</param>
        /// <returns></returns>
        public static DialogResult QuestionSendCancel(string caption, string title = "Подтвердите отправку")
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsSendCancel(title, caption, Resources.question));
        }

        /// <summary>
        /// Диалог-ошибка с вопросом (Да, Нет)
        /// </summary>
        /// <param name="title">Заголовок диалога</param>
        /// <param name="caption">Содержимое диалога</param>
        /// <returns></returns>
        public static DialogResult QuestionErrorYesNo(string title, string caption = "Ошибка")
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsYesNo(title, caption, Resources.error));
        }

        /// <summary>
        /// Диалог с вопросом (Да, Нет)
        /// </summary>
        /// <param name="caption">Текст сообщения</param>
        /// <param name="title">Заголовок</param>
        /// <returns>Результат диалога</returns>
        public static DialogResult QuestionYesNo(string caption, string title = "Вопрос")
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsYesNo(title, caption, Resources.question));
        }

        /// <summary>
        /// Диалог с вопросом (Да, Нет, Отмена)
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="caption">Текст сообщения</param>
        /// <returns>Результат диалога</returns>
        public static DialogResult QuestionYesNoCancel(string title, string caption)
        {
            return XtraMessageBox.Show(GetXtraMsgBoxArgsBtnsYesNoCancel(title, caption, Resources.question));
        }

        #endregion

        #region PRIVATE

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsBtnsOk(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] {DialogResult.OK},
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsOk();
            return args;
        }

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsBtnsOkCancel(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.OK, DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsOkCancel();
            return args;
        }

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsBtnsYesNo(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.No },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsYesNo();
            return args;
        }

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsSendCancel(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsSendCancel();
            return args;
        }

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsBtnsTestWork(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.No },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 1,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsTestWork();
            return args;
        }

        private static XtraMessageBoxArgs GetXtraMsgBoxArgsBtnsYesNoCancel(string title, string caption, Icon icon)
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                AllowHtmlText = DefaultBoolean.True,
                Buttons = new[] { DialogResult.Yes, DialogResult.No ,DialogResult.Cancel },
                Caption = $"<size={Settings.Default.FontSize}>{title}</size>",
                DefaultButtonIndex = 0,
                Text = $"<size={Settings.Default.FontSize}>{caption}</size>",
                Icon = icon
            };

            args.Showing += PrepareMsgBtnsYesNoCancel();
            return args;
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsOk()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.OK].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.OK].Image = Resources.ok_16;
                e.Buttons[DialogResult.OK].Text = Settings.Default.OkButtonText;
                e.Buttons[DialogResult.OK].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.OK].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsOkCancel()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.OK].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.OK].Image = Resources.ok_16;
                e.Buttons[DialogResult.OK].Text = Settings.Default.OkButtonText;
                e.Buttons[DialogResult.OK].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.OK].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
                
                e.Buttons[DialogResult.Cancel].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Cancel].Image = Resources.cancel_16;
                e.Buttons[DialogResult.Cancel].Text = Settings.Default.CancelButtonText;
                e.Buttons[DialogResult.Cancel].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Cancel].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsYesNo()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.Yes].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Yes].Image = Resources.ok_16;
                e.Buttons[DialogResult.Yes].Text = Settings.Default.YesButtonText;
                e.Buttons[DialogResult.Yes].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Yes].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.No].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.No].Image = Resources.no_16;
                e.Buttons[DialogResult.No].Text = Settings.Default.NoButtonText;
                e.Buttons[DialogResult.No].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.No].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsSendCancel()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.Yes].Width += 25;
                e.Buttons[DialogResult.Yes].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Yes].Image = Resources.message_16;
                e.Buttons[DialogResult.Yes].Text = Settings.Default.SendButtonText;
                e.Buttons[DialogResult.Yes].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Yes].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.Cancel].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Cancel].Image = Resources.no_16;
                e.Buttons[DialogResult.Cancel].Text = Settings.Default.CancelButtonText;
                e.Buttons[DialogResult.Cancel].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Cancel].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsTestWork()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.Yes].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Yes].Image = Resources.ok_16;
                e.Buttons[DialogResult.Yes].AllowHtmlDraw = DefaultBoolean.True;
                e.Buttons[DialogResult.Yes].Text = @"<color=Green><b>WORK</b></color>";
                e.Buttons[DialogResult.Yes].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Yes].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.No].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.No].Image = Resources.no_16;
                e.Buttons[DialogResult.No].AllowHtmlDraw = DefaultBoolean.True;
                e.Buttons[DialogResult.No].Text = @"<color=IndianRed><b>TEST</b></color>";
                e.Buttons[DialogResult.No].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.No].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        private static EventHandler<XtraMessageShowingArgs> PrepareMsgBtnsYesNoCancel()
        {
            return (sender, e) =>
            {
                e.Buttons[DialogResult.Yes].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Yes].Image = Resources.ok_16;
                e.Buttons[DialogResult.Yes].Text = Settings.Default.YesButtonText;
                e.Buttons[DialogResult.Yes].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Yes].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.No].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.No].Image = Resources.no_16;
                e.Buttons[DialogResult.No].Text = Settings.Default.NoButtonText;
                e.Buttons[DialogResult.No].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.No].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);

                e.Buttons[DialogResult.Cancel].Cursor = Cursors.Hand;
                e.Buttons[DialogResult.Cancel].Image = Resources.cancel_16;
                e.Buttons[DialogResult.Cancel].Text = Settings.Default.CancelButtonText;
                e.Buttons[DialogResult.Cancel].ImageToTextAlignment = ImageAlignToText.LeftCenter;
                e.Buttons[DialogResult.Cancel].Font = new Font(Settings.Default.FontName, Settings.Default.FontSize);
            };
        }

        #endregion
    }
}
