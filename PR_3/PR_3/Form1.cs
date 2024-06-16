using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Отключение мигания
        }
        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Exit_Click(sender, e);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ValueMatrix.Controls.Clear();
            textBoxColumns.Clear();
            textBoxLines.Clear();
            errorProvider.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeometricMeanMatrixButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> values = new List<double>();
                foreach (Control control in ValueMatrix.Controls)
                {
                    if (control is System.Windows.Forms.TextBox textBox)
                    {
                        if (double.TryParse(textBox.Text, out double value))
                        {
                            values.Add(value);
                        }
                        else
                        {
                            MessageBox.Show("Некорректные значения в одной из ячеек.", "Ошибка");
                            return;
                        }
                    }
                }

                // Вычисляем среднее геометрическое
                double geometricMean = 1; // начальное значение
                foreach (double value in values)
                {
                    geometricMean *= value;
                }
                if (geometricMean == 1) MessageBox.Show("Нет значений", "Ошибка"); // Выводим результат умножения в текстовое поле
                else
                {
                    geometricMean = Math.Pow(geometricMean, 1.0 / values.Count); // расчёт ср. геометрического*
                    MessageBox.Show($"Среднее геометрическое: {geometricMean:F3}", "Результат"); // Выводится сообщение с вычисленным средним геометрическим, округлённым до трёх знаков после запятой.
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка...", "Ошибка");
            }
        }

        private double CalculateGeometricMean<T>(T[,] matrix) where T : IConvertible // вычисление среднего геометрического значения
        {
            double product = 1.0; // Инициализация произведения положительных значений | 1.0 как нач. значение
            int count = 0; // Инициализация количества положительных значений

            for (int i = 0; i < matrix.GetLength(0); i++) // Перебор всех элементов матрицы 2x2 || строки
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Перебор всех элементов матрицы 2x2 || столбцы
                {
                    double value = Convert.ToDouble(matrix[i, j], null); // преобразование элемента матрицы в double | null - x
                    if (value > 0)
                    {
                        product *= value; // умножение на + значение
                        count++; // увеличение кол-ва + значений
                    }
                    else MessageBox.Show("Ошибка. Были введены отрицательные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // ошибка на случай отрицательных значений
                }
            }
            return count > 0 ? Math.Pow(product, 1.0 / count) : 0; // проверка кол-ва и деление на него при > 0
        }

        private void ApplicationGeometricMean_Click(object sender, EventArgs e)
        {
            GeometricMeanMatrixButton_Click(sender, e);
        }

        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
            ValueMatrix.Controls.Clear(); // при нажатии все поля очищаются в GroupBox
            int columns = Convert.ToInt32(textBoxColumns.Text);
            int lines = Convert.ToInt32(textBoxLines.Text);

            if (columns < 0 || columns > 5 || lines < 0 || lines > 5)
            {
                MessageBox.Show("Количество строк и столбцов должно быть от 0 до 5.", "Ошибка");
                return; // Прекращаем выполнение, если значения некорректны
            }

            int count = 0;

            for (int l = 0; l < lines; l++) // цикл для строк
            {
                for (int c = 0; c < columns; c++) // цикл для колонок
                {
                        count++;
                        System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox(); // экземпляр полей с названием TextBox!!!
                        textBox.Name = $"textBox{count}";
                        textBox.Location = new System.Drawing.Point(6 + c * 55, 19 + l * 25);
                        textBox.Size = new System.Drawing.Size(30, 30);
                        textBox.TabIndex = count;
                        ValueMatrix.Controls.Add(textBox);

                        textBox.Validating += (sender1, e1) => // Добавляем обработчик события Validating для проверки ввода
                        {
                            if (string.IsNullOrEmpty(textBox.Text)) // Проверка на пустое поле
                            {
                                errorProvider.SetError(textBox, "Оставлять данное поле пустым нельзя");
                                return; // Прерываем выполнение, если всё норм
                            }
                            if (!int.TryParse(textBox.Text, out int value)) // Проверка на число
                            {
                                errorProvider.SetError(textBox, "Некорректное значение");
                                return;
                            }
                            //if (value > 1000 || value < -1000) // Проверка на диапазон
                            //{
                            //    errorProvider.SetError(textBox, "Значение должно быть в диапазоне от -1000 до 1000");
                            //    return;
                            //}
                            errorProvider.Clear();
                        };

                        ValueMatrix.Controls.Add(textBox);
                    }
            }
            }
            catch
            {
                MessageBox.Show("Значения строк и столбцов должны быть корректными.", "Ошибка");
            }
        }

        private void textBoxColumns_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxColumns.Text)) // Проверка на пустое поле
            {
                errorProvider.SetError(textBoxColumns, "Оставлять данное поле пустым нельзя");
                return; // Прерываем выполнение, если всё норм
            }

            string[] numbers = textBoxColumns.Lines;

            bool isValid = true; // Проверка: все ли элементы массива numbers являются числами // isValid - переменная, которая будет хранить информацию о корректности введенных данных.
            foreach (string number in numbers) // цикл, который перебирает каждый элемент массива numbers
            {
                if (!int.TryParse(number, out int result)) // метод, который пытается преобразовать строку number в целочисленное число.
                {
                    isValid = false;
                    break;
                }

                if (result < 0 || result > 5) // на макс. и мин. значение в размер 1000.
                {
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                errorProvider.SetError(textBoxColumns, "Некорректное значение");
                return; // Прерываем выполнение, если всё норм
            }

            errorProvider.Clear(); // Если ошибок нет, очищаем сообщение об ошибке
        }

        private void textBoxLines_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLines.Text)) // Проверка на пустое поле
            {
                errorProvider.SetError(textBoxLines, "Оставлять данное поле пустым нельзя");
                return; // Прерываем выполнение, если всё норм
            }

            string[] numbers = textBoxLines.Lines;

            bool isValid = true; // Проверка: все ли элементы массива numbers являются числами // isValid - переменная, которая будет хранить информацию о корректности введенных данных.
            foreach (string number in numbers) // цикл, который перебирает каждый элемент массива numbers
            {
                if (!int.TryParse(number, out int result)) // метод, который пытается преобразовать строку number в целочисленное число.
                {
                    isValid = false;
                    break;
                }

                if (result < 0 || result > 5) // на макс. и мин. значение в размер 1000.
                {
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                errorProvider.SetError(textBoxLines, "Некорректное значение");
                return; // Прерываем выполнение, если всё норм
            }

            errorProvider.Clear(); // Если ошибок нет, очищаем сообщение об ошибке
        }
    }
}