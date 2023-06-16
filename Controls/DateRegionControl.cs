using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using Exception = System.Exception;

namespace ALX.Common.UI.Controls
{
    public enum PeriodType
    {
        Today = 0,
        LastThreeDays = 1,
        LastWeek = 2
    }

    public partial class DateRegionControl : XtraUserControl
    {
        [Browsable(true)]
        [Description("Период который загружается по умолчанию (DEfault: LastWeek)")]
        public PeriodType PeriodType { get; set; } = PeriodType.LastWeek;

        private bool _showFooter = false;

        [Browsable(true)]
        [Description("Признак отображения футера с кнопками [OK, Отмена] (Default: False)")]
        public bool ShowFooter {
            get { return _showFooter; }
            set
            {
                _showFooter = value;
                layGrFooter.Visibility = _showFooter ? LayoutVisibility.Always : LayoutVisibility.Never;
            }
        }

        /// <summary>
        /// Указанный период даты и времени
        /// </summary>
        public Range<DateTime> DateRange { get; private set; }

        /// <summary>
        /// Компонент выбора периода даты и времени
        /// </summary>
        /// <param name="periodType">Период по умолчанию (Последняя неделя)</param>
        /// <param name="showFooter">Признак отображения кнопок [OK, Отмена]</param>
        public DateRegionControl(PeriodType periodType = PeriodType.LastWeek, bool showFooter = true)
        {
            InitializeComponent();

            PeriodType = periodType;
            ShowFooter = showFooter;
        }

        public DateRegionControl()
        {
            InitializeComponent();
        }

        private void DateRegionControl_Load(object sender, EventArgs e)
        {
            switch (PeriodType)
            {
                case PeriodType.Today: SetToday(); break;
                case PeriodType.LastThreeDays: SetLastThreeDays(); break;
                case PeriodType.LastWeek: SetLastWeek(); break;
                default: break;
            }

            layGrFooter.Visibility = ShowFooter ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        /// <summary>
        /// Указать период
        /// </summary>
        /// <param name="dateRange">период (дата начала и окончания)</param>
        public void SetPeriod(Range<DateTime> dateRange)
        {
            try
            {
                dateEditStart.EditValue= dateRange.Start;
                dateEditEnd.EditValue = dateRange.End;
            }
            catch (Exception exception)
            {
                if (exception is WarningException warning) MessageBox.Warning(warning.Message);
                else MessageBox.Error(caption:
                    $"Ошибка установки периода.{Environment.NewLine}" +
                    $"{exception.Message}", exception:exception);
            }
        }

        /// <summary>
        /// Указать "Сегодня"
        /// </summary>
        private void SetToday()
        {
            SetPeriod(new Range<DateTime>(
                start: DateTime.Today.Date,
                end: DateTime.Today.AddDays(1).AddMilliseconds(-1)));
        }

        /// <summary>
        /// Указать "Последние три дня"
        /// </summary>
        private void SetLastThreeDays()
        {
            SetPeriod(new Range<DateTime>(
                start: DateTime.Today.AddDays(-3).Date,
                end: DateTime.Today.AddDays(1).AddMilliseconds(-1)));
        }

        /// <summary>
        /// Указать "Последнюю неделю"
        /// </summary>
        private void SetLastWeek()
        {
            SetPeriod(new Range<DateTime>(
                start: DateTime.Today.AddDays(-7).Date,
                end: DateTime.Today.AddDays(1).AddMilliseconds(-1)));
        }

        /// <summary>
        /// Указать "Последние 3 месяца"
        /// </summary>
        private void SetLastThreeMonth()
        {
            SetPeriod(new Range<DateTime>(
                start: DateTime.Today.AddMonths(-3).Date,
                end: DateTime.Today.AddDays(1).AddMilliseconds(-1)));
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            SetToday();
        }

        private void btnThreeDays_Click(object sender, EventArgs e)
        {
            SetLastThreeDays();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            SetLastWeek();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Parent is PopupContainerControl popupContainer &&
                popupContainer.OwnerEdit is PopupContainerEdit popupContainerEdit)
            {
                popupContainerEdit.ClosePopup();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Parent is PopupContainerControl popupContainer &&
                popupContainer.OwnerEdit is PopupContainerEdit popupContainerEdit)
            {
                popupContainerEdit.CancelPopup();
            }
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            DateRange = new Range<DateTime>(
                start: dateEditStart.DateTime.Date,
                end: dateEditEnd.DateTime.Date == DateTime.Today
                    ? DateTime.Today.AddDays(1).AddMilliseconds(-1)
                    : dateEditEnd.DateTime.Date.AddDays(1).AddMilliseconds(-1));
        }
    }
}
