using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedLineProject.Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using Markdig;

namespace RedLineProject
{
    public partial class Form1 : MaterialForm
    {
        List<Detail> details; // Лист деталей
        int[,] field; // Двумерный массив для базовой доски
        Detail baseDetail; // Основа
        int edge; // Кромка
        int count; // Счётчик

        private void SetZero() // Обнуление поля
        {
            int length = baseDetail.GetLength(); // Количество столбцов
            int width = baseDetail.GetWidth(); // Количество строк

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    field[i, j] = 0;
                }
            }
        }

        private void SetOne(int iStart, int jStart, int length, int width) // Установка единиц по размеру детали и фреза
        {
            if (edge > 0)
            {
                int k = iStart - 1; // Верхняя граница
                while (k >= 0 && k != iStart - edge)
                {
                    for (int j = jStart; j < jStart + length; j++)
                    {
                        field[k, j] = 1;
                    }
                    k--;
                }

                k = iStart + width; // Нижняя граница
                while (k < baseDetail.GetWidth() && k != iStart + edge + width - 1)
                {
                    for (int j = jStart; j < jStart + length; j++)
                    {
                        field[k, j] = 1;
                    }
                    k++;
                }

                k = jStart - 1; // Граница слева
                while (k >= 0 && k != jStart - edge)
                {
                    for (int i = iStart; i < iStart + width; i++)
                    {
                        field[i, k] = 1;
                    }
                    k--;
                }

                k = jStart + length; // Граница справа
                while (k < baseDetail.GetLength() && k != jStart + edge + length - 1)
                {
                    for (int i = iStart; i < iStart + width; i++)
                    {
                        field[i, k] = 1;
                    }
                    k++;
                }
            }
            
            for (int i = iStart; i < iStart + width; i++) // Деталь
            {
                for (int j = jStart; j < jStart + length; j++)
                {
                    field[i, j] = 1;
                }
            }
        }

        private bool SetDetail(int index) // Попытка установки детали
        {
            int length = details[index].GetLength();
            int width = details[index].GetWidth();

            int baseL = baseDetail.GetLength();
            int baseW = baseDetail.GetWidth();

            for (int i = 0; i < baseW; i++)
            {
                int count = 0;
                if (i + width <= baseW)
                {
                    for (int j = 0; j < baseL; j++)
                    {
                        if (field[i, j] == 1) count = 0;
                        if (field[i, j] == 0) count++;
                        if (count == length)
                        {
                            for (int k = i + 1; k < i + width; k++)
                            {
                                for (int l = j - length + 1; l <= j; l++)
                                {
                                    if (field[k, l] == 1)
                                    {
                                        count = -1;
                                        break;
                                    }
                                    else count++;
                                }
                                if (count == -1) break;
                            }
                            if (count == length * width)
                            {
                                details[index].Decrement();
                                SetOne(i, j - length + 1, length, width);
                                return true;
                            }
                        }
                    }
                }
            }
            // Разворот детали
            length = details[index].GetWidth();
            width = details[index].GetLength();
            for (int i = 0; i < baseW; i++)
            {
                int count = 0;
                if (i + width <= baseW)
                {
                    for (int j = 0; j < baseL; j++)
                    {
                        if (field[i, j] == 1) count = 0;
                        if (field[i, j] == 0) count++;
                        if (count == length)
                        {
                            for (int k = i + 1; k < i + width; k++)
                            {
                                for (int l = j - length + 1; l <= j; l++)
                                {
                                    if (field[k, l] == 1)
                                    {
                                        count = -1;
                                        break;
                                    }
                                    else count++;
                                }
                                if (count == -1) break;
                            }
                            if (count == length * width)
                            {
                                details[index].Decrement();
                                SetOne(i, j - length + 1, length, width);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void Compute() // метод для рассчёта (на вход размеры базовой доски)
        {
            details.Sort(Detail.CompareDetails);

            while (details.Count > 0)
            {
                count++;
                SetZero();
                for (int i = 0; i < details.Count; i++)
                {
                    while (SetDetail(i))
                    {
                        if (details[i].GetCount() == 0)
                        {
                            details.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange50, Primary.Brown300,
                Primary.Orange200, Accent.Orange200,
                TextShade.BLACK
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            details = new List<Detail>();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(detailLengthInput.Text);
                int width = Convert.ToInt32(detailWidthInput.Text);
                int count = Convert.ToInt32(detailCountInput.Text);

                if (length <= 0 || width <= 0 || count < 1)
                    MessageBox.Show("Введите размеры детали и количество.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    details.Add(new Detail(length, width, count));

                    detailLengthInput.Clear();
                    detailWidthInput.Clear();
                    detailCountInput.Clear();

                    detailListView.Items.Clear();

                    foreach (var d in details)
                    {
                        detailListView.Items.Add(new ListViewItem(new string[]
                        { d.GetLength().ToString() + " * " + d.GetWidth().ToString(), d.GetCount().ToString() }));
                    }
                        
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(baseDetailLengthInput.Text) - 20;
                int width = Convert.ToInt32(baseDetailWidthInput.Text) - 20;
                int ed = Convert.ToInt32(edgeInput.Text);

                if (length <= 0 || width <= 0 || ed < 0)
                    MessageBox.Show("Введите размеры ДСП.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    edge = ed;
                    baseDetail = new Detail(length, width, 1);

                    if (CheckDetails())
                    {
                        field = new int[width, length];
                        count = 0;

                        Compute();

                        baseDetailLengthInput.Clear();
                        baseDetailWidthInput.Clear();
                        edgeInput.Clear();

                        MessageBox.Show("Вам понадобится " + count + " ДСП.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Размеры детали не могут превышать размеры ДСП.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    details.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDetails()
        {
            int length = baseDetail.GetLength();
            int width = baseDetail.GetWidth();

            foreach (Detail d in details)
            {
                int l = d.GetLength();
                int w = d.GetWidth();

                if (!(l <= length && w <= width || l <= width && w <= length)) return false;
            }

            return true;
        }

        private string GetDocs()
        {
            string text = System.IO.File.ReadAllText(Environment.CurrentDirectory.Remove(
                Environment.CurrentDirectory.IndexOf("RedLineProject")) + @"RedLineProject\docs\for_users.md");
            var result = Markdown.ToHtml(text);

            return result;
        }

        private void helpLabel_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm(GetDocs());

            helpForm.Show();
        }
    }
}
