using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ALX.Common.UI.Validation
{
    /// <summary>
    /// Правило валидации. Проверка на пустую строку
    /// </summary>
    public class EmptyStringValidationRule : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            bool result = false;
            if (control is BaseEdit editor)
                result = !string.IsNullOrEmpty(editor.EditValue?.ToString() ?? string.Empty);
            return result;
        }
    }

    /// <summary>
    /// Правило валидации. Проверка стоимости
    /// </summary>
    public class CostValidationRule : ValidationRule
    {
        private readonly decimal _minValue;

        /// <summary>
        /// Валидатор поля типа "Стоимость"
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        public CostValidationRule(decimal minValue)
        {
            _minValue = minValue;
        }

        public override bool Validate(Control control, object value)
        {
            bool result = false;
            if (control is BaseEdit editor)
            {
                string stringVal = (editor.EditValue?.ToString() ?? string.Empty).Replace('.', ',');
                if (decimal.TryParse(s: stringVal, out decimal decimalVal))
                    result = decimalVal > _minValue;
            }
            return result;
        }
    }
}
