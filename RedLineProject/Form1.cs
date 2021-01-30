using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RedLineProject.Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RedLineProject
{
    public partial class Form1 : MaterialForm
    {
        Computations computations = new Computations();
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
            computations.details = new List<Detail>();
            FileWorker.ClearData();
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
                    computations.details.Add(new Detail(length, width, count));

                    detailLengthInput.Clear();
                    detailWidthInput.Clear();
                    detailCountInput.Clear();

                    detailListView.Items.Clear();

                    foreach (var d in computations.details)
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
                    computations.edge = ed;
                    computations.baseDetail = new Detail(length, width, 0);

                    if (CheckDetails())
                    {
                        computations.field = new int[width, length];
                        computations.baseDetail.ResetCountToZero();

                        computations.Compute();

                        baseDetailLengthInput.Clear();
                        baseDetailWidthInput.Clear();
                        edgeInput.Clear();

                        MessageBox.Show("Вам понадобится " + computations.baseDetail.GetCount() + " ДСП.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Размеры детали не могут превышать размеры ДСП.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    computations.details.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDetails()
        {
            int length = computations.baseDetail.GetLength();
            int width = computations.baseDetail.GetWidth();

            foreach (Detail d in computations.details)
            {
                int l = d.GetLength();
                int w = d.GetWidth();

                if (!(l <= length && w <= width || l <= width && w <= length)) return false;
            }

            return true;
        }

        private void helpLabel_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm(FileWorker.GetDocs());

            helpForm.Show();
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            string myStr = "Это приложение абсолютно бесплатное и держится лишь на нашем энтузиазме и любви к людям. " +
                "В данный момент мы активно работает над новой версией приложения с расширенным функционалом," +
                " чтобы вам было удобнее и приятней с ним работать." +
                "\n" +
                "\n" +
                "Поблагодарить разработчиков можно, используя следующие данные:" +
                "\n" +
                "\n" +
                "Большакова Екатерина Дмитриевна  +7 (905) 530 48 87" +
                "\n" +
                "Кравцов Иван Константинович  +7 (953) 213 88 75" +
                "\n" +
                "\n" +
                "Ваши пожертвования помогут нам развиваться!";
            MessageBox.Show( myStr, "RedLine", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
