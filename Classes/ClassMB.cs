using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Classes
{
	class ClassMB
	{
        public static void ErrorMB(Exception exception)
        {
            MessageBox.Show(exception.Message, "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void ErrorMB(string text)
        {
            MessageBox.Show(text, "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void InformationMB(string text)
        {
            MessageBox.Show(text, "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void ExitMessageBox()
        {
            MessageBoxResult messageBoxResult =
                MessageBox.Show("Вы действительно желаете выйти?",
                "Вопрос", MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (MessageBoxResult.Yes == messageBoxResult)
            {
                App.Current.Shutdown()
;
            }
        }
        public static bool QuestionMessageBox(string question)
        {
            return MessageBoxResult.Yes == MessageBox.Show(question,
                "Вопрос", MessageBoxButton.YesNo,
                MessageBoxImage.Question);
        }
    }
}
