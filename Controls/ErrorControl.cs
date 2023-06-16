using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ALX.Common.UI.Properties;

namespace ALX.Common.UI.Controls
{
    public partial class ErrorControl : XtraUserControl
    {
        #region NESTED

        /// <summary>
        /// Аргументы компонента "Ошибка"
        /// </summary>
        public class ErrorControlArgs
        {
            /// <summary>
            /// Тип сообщения
            /// </summary>
            public MessageTypes MessageType { get; set; }

            /// <summary>
            /// Сообщение
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// Детали исключения
            /// </summary>
            public string ErrorDetails { get; set; }
        }

        #endregion

        /// <summary>
        /// Аргументы компонента
        /// </summary>
        private ErrorControlArgs Args { get; set; }

        /// <summary>
        /// Для DesignMode
        /// </summary>
        public ErrorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Не для DesignMode
        /// </summary>
        /// <param name="args">Аргументы компонента</param>
        public ErrorControl(ErrorControlArgs args)
        {
            InitializeComponent();

            Args = args;

            if (!DesignMode)
            {
                try
                {
                    Setup(Args);

                    int
                        defaultLinesCount = 2,
                        lineHeight = Convert.ToInt32(lblMessageCaption.Font.Size),
                        linesCount = lblMessageCaption.Height / lineHeight;

                    if (linesCount > defaultLinesCount)
                    {
                        int heightDiff = linesCount * (lineHeight - defaultLinesCount);
                        Size = new System.Drawing.Size(Width, Height + heightDiff);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Error(exception.Message);
                    ParentForm?.Close();
                }
            }
        }

        /// <summary>
        /// Установить параметры исключения
        /// </summary>
        /// <param name="args">Аргументы диалога</param>
        public void Setup(ErrorControlArgs args)
        {
            Args = args;

            #region MessageType

            switch (Args?.MessageType ?? MessageTypes.None)
            {
                case MessageTypes.None:
                    pictureEdtErr.Visible = false;
                    lblCaption.Text = @"Возникло непредвиденное исключение.";
                    break;
                case MessageTypes.Error:
                    pictureEdtErr.Visible = true;
                    pictureEdtErr.Image = Resources.error_64;
                    lblCaption.Text = @"Сообщение (<u><b>Ошибка</b></u>):";
                    break;
                case MessageTypes.Warning:
                    pictureEdtErr.Visible = true;
                    pictureEdtErr.Image = Resources.warning_64;
                    lblCaption.Text = @"Сообщение (<u><b>Предупреждение</b></u>):";
                    break;
                case MessageTypes.Information:
                    pictureEdtErr.Visible = true;
                    pictureEdtErr.Image = Resources.information_64;
                    lblCaption.Visibility = separatorCaption.Visibility = 
                        LayoutVisibility.Never;
                    break;
            }

            #endregion

            #region Message

            lblMessageCaption.Text = Args?.Message ?? string.Empty;

            #endregion

            #region ErrorDetails

            string errorDetails = Args?.ErrorDetails ?? string.Empty;

            layCtrlGrDetails.Visibility = string.IsNullOrEmpty(errorDetails)
                ? LayoutVisibility.Never
                : LayoutVisibility.Always;

            if (!string.IsNullOrEmpty(errorDetails))
                memoExEditErrorDitails.Text = errorDetails;

            #endregion
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Args?.Message ?? string.Empty))
                {
                    string 
                        message = string.IsNullOrEmpty(lblMessageCaption.PlainText)
                            ? lblMessageCaption.Text : lblMessageCaption.PlainText,
                        details = $"{Environment.NewLine}[ДЕТАЛИ]:{Environment.NewLine}{Args?.ErrorDetails ?? string.Empty}",
                        clipBoardText = 
                            $"[СООБЩЕНИЕ]:{Environment.NewLine}{message}" +
                            $"{(string.IsNullOrEmpty(Args?.ErrorDetails ?? string.Empty) ? string.Empty : $"{Environment.NewLine}{details}")}";

                    Clipboard.SetDataObject(clipBoardText);
                }
            }
            catch
            {
                // ignore
            }
        }
    }
}
