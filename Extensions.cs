using System;
using System.Linq;
using System.ComponentModel;

namespace ALX.Common.UI
{
    public static class Extensions
    {
        /// <summary>
        /// Значение атрибута
        /// </summary>
        /// <typeparam name="TAttribute">Класс атрибута</typeparam>
        /// <param name="value">Член перечисления</param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            return type.GetField(name).GetCustomAttributes(false)
                .OfType<TAttribute>().SingleOrDefault();
        }

        /// <summary>
        /// Значение атрибута Description
        /// </summary>
        /// <param name="member">Член перечисления</param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum member)
        {
            DescriptionAttribute attr = member.GetAttribute<DescriptionAttribute>();
            return attr?.Description ?? member.ToString();
        }
    }

    /// <summary>
    /// Режим отображения пользовательского компонена в диалоге
    /// </summary>
    public enum ControlDisplayMode
    {
        [Description("Просмотр")] View = 0,
        [Description("Создание")] Add = 1,
        [Description("Изменение")] Edit = 2,
        [Description("Удаление")] Delete = 3,
    }

    /// <summary>
    /// Структура диапазона
    /// </summary>
    /// <typeparam name="T">Тип структуры</typeparam>
    public struct Range<T> where T : IComparable<T>
    {
        /// <summary>
        /// Создать новый диапазон
        /// </summary>
        /// <param name="start">Начало диапазона</param>
        /// <param name="end">Конец диапазона</param>
        public Range(T start, T end)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Начало диапазона
        /// </summary>
        public T Start { get; }

        /// <summary>
        /// Конец диапазона
        /// </summary>
        public T End { get; }

        /// <summary>
        /// Проверка на вхождение в диапазон одиночного значения
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public bool Includes(T value) => Start.CompareTo(value) <= 0 && End.CompareTo(value) >= 0;

        /// <summary>
        /// Проверка на вхождение в диапазон другого диапазона
        /// </summary>
        /// <param name="range">Диапазон</param>
        /// <returns></returns>
        public bool Includes(Range<T> range) => Start.CompareTo(range.Start) <= 0 && End.CompareTo(range.End) >= 0;

        public override string ToString()
        {
            try
            {
                string
                    result = $"{Start} - {End}",
                    typeName = typeof(T).Name;

                const string
                    dateTimeType = nameof(DateTime);

                switch (typeName)
                {
                    case dateTimeType:
                        return $"{Start:dd.MM.yyyy г.} - {End:dd.MM.yyyy г.}";
                    default:
                        return result;
                }
            }
            catch
            {
                return base.ToString();
            }
        }
    }

    /// <summary>
    /// Класс для отображения процесса загрузки
    /// </summary>
    public static class SplashScreenLoader
    {
        /// <summary>
        /// Отобразить процесс загрузки
        /// </summary>
        /// <param name="loadingAction">Действие загрузки</param>
        /// <param name="owner">Родительское окно</param>
        /// <param name="caption">Заголовок</param>
        /// <param name="description">Описание</param>
        public static void Load(Action loadingAction, object owner = null, string caption = "Пожалуйста подождите", string description = "Загрузка данных")
        {
            try
            {
                SplashScreen.ShowWaitForm(owner: owner, caption: caption, description: description);
                loadingAction.Invoke();
            }
            finally
            {
                SplashScreen.CloseWaitForm();
            }
        }
    }
}
