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

        private void SetOne(int iStart, int jStart, int length, int width) // Установка единиц по размеру детали
        {
            for (int i = iStart; i < iStart + width; i++)
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
                for (int j = 0; j < baseL; j++)
                {
                    if (field[i, j] == 1) count = 0;
                    if (field[i, j] == 0) count++;
                    if (count == length)
                    {
                        for (int k = i + 1; k < i + width; k++)
                        {
                            for (int l = j + 1; l < j + length; l++)
                            {
                                if (field[i, j] == 1)
                                {
                                    count = -1;
                                    break;
                                }
                            }
                            if (count == -1) break;
                        }
                        if (count != -1)
                        {
                            details[index].Decrement();
                            SetOne(i, j-length+1, length, width);
                            return true;
                        }
                    }
                }
            }
            length = details[index].GetWidth();
            width = details[index].GetLength();
            for (int i = 0; i < baseW; i++)
            {
                int count = 0;
                for (int j = 0; j < baseL; j++)
                {
                    if (field[i, j] == 1) count = 0;
                    if (field[i, j] == 0) count++;
                    if (count == length)
                    {
                        for (int k = i + 1; k < i + width; k++)
                        {
                            for (int l = j + 1; l < j + length; l++)
                            {
                                if (field[i, j] == 1)
                                {
                                    count = -1;
                                    break;
                                }
                            }
                            if (count == -1) break;
                        }
                        if (count != -1)
                        {
                            details[index].Decrement();
                            SetOne(i, j, length, width);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Compute(int _length, int _width, int _edge) // метод для рассчёта (на вход размеры базовой доски)
        {
            baseDetail = new Detail(_length, _width, 1);
            field = new int[_width, _length];
            edge = _edge;
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
            count = 0;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(detailLengthInput.Text);
                int width = Convert.ToInt32(detailWidthInput.Text);
                int count = Convert.ToInt32(detailCountInput.Text);
                details.Add(new Detail(length, width, count));
                detailLengthInput.Clear();
                detailWidthInput.Clear();
                detailCountInput.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число.", "Ошибка ввода", MessageBoxButtons.OK);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(baseDetailLengthInput.Text);
                int width = Convert.ToInt32(baseDetailWidthInput.Text);
                int edge = Convert.ToInt32(edgeInput.Text);
                Compute(length, width, edge);
                baseDetailLengthInput.Clear();
                baseDetailWidthInput.Clear();
                edgeInput.Clear();
                MessageBox.Show("Вам понадобится " + count + "ДСП.", "Результат", MessageBoxButtons.OK);
                details.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите число.", "Ошибка ввода", MessageBoxButtons.OK);
            }
        }
    }
}
