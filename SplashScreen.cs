using System;
using System.Threading;
using System.Windows.Forms;
using ALX.Common.UI.Forms;
using ALX.Common.UI.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace ALX.Common.UI
{
    public static class SplashScreen
    {
        private static volatile MessageWindow _owner;
        // ReSharper disable once NotAccessedField.Local
        private static volatile IntPtr _hwnd;
        private static readonly ManualResetEvent WindowReadyEvent = new ManualResetEvent(false);

        /// <summary>
        /// Показать форму загрузки
        /// </summary>
        /// <param name="owner">Форма родитель</param>
        /// <param name="caption">Заголовок</param>
        /// <param name="description">Описание</param>
        public static void ShowWaitForm(object owner = null, string caption = "Пожалуйста подождите", string description = "Загрузка данных")
        {
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = Settings.Default.SkinName;

            if (!(owner is XtraForm ownerForm))
            {
                Thread messageLoop = new Thread(delegate ()
                {
                    Application.Run(new MessageWindow());
                });
                messageLoop.SetApartmentState(ApartmentState.STA);
                messageLoop.Name = "MessageLoopThread";
                messageLoop.IsBackground = true;
                messageLoop.Start();

                SplashScreenManager.ShowForm(_owner, typeof(LoadingForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption(caption);
                SplashScreenManager.Default.SetWaitFormDescription($"{description} ...");
            }
            else
            {
                SplashScreenManager.ShowForm(ownerForm, typeof(LoadingForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption(caption);
                SplashScreenManager.Default.SetWaitFormDescription($"{description} ...");
            }
        }

        /// <summary>
        /// Установить заголовок
        /// </summary>
        /// <param name="caption"></param>
        public static void SetWaitFormCaption(string caption)
        {
            SplashScreenManager.Default.SetWaitFormCaption(caption);
        }

        /// <summary>
        /// Установить описание
        /// </summary>
        /// <param name="description"></param>
        public static void SetWaitFormDescription(string description)
        {
            SplashScreenManager.Default?.SetWaitFormDescription(description);
        }

        /// <summary>
        /// Закрыть форму загрузки
        /// </summary>
        public static void CloseWaitForm()
        {
            SplashScreenManager.CloseForm(throwExceptionIfAlreadyClosed:false);
        }

        private class MessageWindow : Form
        {
            public MessageWindow()
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                _owner = this;
                _hwnd = this.Handle;
                WindowReadyEvent.Set();
            }

            protected override void SetVisibleCore(bool value)
            {
                // Ensure the window never becomes visible
                base.SetVisibleCore(false);
            }
        }
    }
}
