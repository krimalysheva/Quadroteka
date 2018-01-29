using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsUtils;
using ProgramLogicUtilits;

namespace Att_3
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            this.saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            DataGridViewUtils.InitGridForArr(inputGridView, 40, false, true, true, true, false);
            DataGridViewUtils.InitGridForArr(outputGridView, 40, false, true, true, true, false);
        }
        List<Tablets> answerTablets = new List<Tablets>();

        private void StartButtom_Click(object sender, EventArgs e)
        {
            try
            {
                int tabletsCount = int.Parse(this.Col.Text);
                int minMemory = int.Parse(this.M.Text);
                int minRating = int.Parse(this.R.Text);
                int minCoast = int.Parse(this.K.Text);

                ListClassUtils utils = new ListClassUtils(DGVUtils.DGVToTabletsList(inputGridView));
                List<Tablets> sortedList = utils.SortTabletsByPrice(
                    utils.SelectTablesByMemoryAndRating(minMemory, minRating)
                );
                List<Tablets> result = utils.SelectFirstTablets(sortedList, tabletsCount);

                DGVUtils.TabletsListToOutputDGV(outputGridView, result);
            }
            catch (Exception)
            {
                MessagesUtils.ShowError("Ошибка");
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

             if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog1.FileName;

                    List<Tablets> studentsList = DGVUtils.OutDGVToTabletsList(outputGridView);
                    string answer = TabletsFileUtils.TabletsListToStr(studentsList);
                    FileUtils.WriteStringToFile(path, answer);
                    MessagesUtils.Show("Данные сохранены в файл");
                }
                catch (Exception exp)
                {
                    MessagesUtils.Show("Произошла ошибка сохранения");
                }
            }
              
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string answerText = FileUtils.ReadStringFromFile(openFileDialog1.FileName);
                    List<Tablets> answer = TabletsFileUtils.StrToTabletsList(answerText);
                   DGVUtils.TabletsListToInputDGV(inputGridView, answer);
                    MessagesUtils.Show("Готово");
                }
                catch (Exception exp)
                {
                    MessagesUtils.Show("Произошла ошибка загрузки");
                }

            }
        }
    }
}
