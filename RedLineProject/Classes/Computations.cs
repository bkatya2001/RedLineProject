using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLineProject.Classes
{
    public class Computations
    {
        public List<Detail> details; // Лист деталей
        public int[,] field; // Двумерный массив для базовой доски
        public Detail baseDetail; // Основа
        public int edge; // Кромка

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
            int up = 0;
            int down = 0;
            if (edge > 0)
            {
                int k = iStart - 1; // Верхняя граница
                while (k >= 0 && k >= iStart - edge)
                {
                    up++;
                    for (int j = jStart; j < jStart + length; j++)
                    {
                        field[k, j] = 9;
                    }
                    k--;
                }

                k = iStart + width; // Нижняя граница
                while (k < baseDetail.GetWidth() && k <= iStart + edge + width - 1)
                {
                    down++;
                    for (int j = jStart; j < jStart + length; j++)
                    {
                        field[k, j] = 9;
                    }
                    k++;
                }

                k = jStart - 1; // Граница слева
                while (k >= 0 && k >= jStart - edge)
                {
                    for (int i = iStart - up; i < iStart + width + down; i++)
                    {
                        field[i, k] = 9;
                    }
                    k--;
                }

                k = jStart + length; // Граница справа
                while (k < baseDetail.GetLength() && k <= jStart + edge + length - 1)
                {
                    for (int i = iStart - up; i < iStart + width + down; i++)
                    {
                        field[i, k] = 9;
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
                        if (field[i, j] != 0) count = 0;
                        if (field[i, j] == 0) count++;
                        if (count == length)
                        {
                            for (int k = i + 1; k < i + width; k++)
                            {
                                for (int l = j - length + 1; l <= j; l++)
                                {
                                    if (field[k, l] != 0)
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
                        if (field[i, j] != 0) count = 0;
                        if (field[i, j] == 0) count++;
                        if (count == length)
                        {
                            for (int k = i + 1; k < i + width; k++)
                            {
                                for (int l = j - length + 1; l <= j; l++)
                                {
                                    if (field[k, l] != 0)
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

        public void Compute() // метод для рассчёта
        {
            details.Sort(Detail.CompareDetails);

            while (details.Count > 0)
            {
                baseDetail.Increment();
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
                //FileWorker.WriteFile(baseDetail.GetLength(), baseDetail.GetWidth(), ref field);
            }
        }
    }
}
