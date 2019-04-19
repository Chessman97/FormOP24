using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Application = Microsoft.Office.Interop.Excel.Application;

namespace InterfaceTable
{
    public partial class MainForm : Form
    {
        private List<Record> records = new List<Record>();
        private int INDEX = 0;
        private int fillFlag = 0;
        private List<Worker> employees;

        //export to Excel
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;

        private Record findRecord(int number)
        {
            for (int i = 0; i < records.Count; i++)
                if (records[i].Number == number)
                    return records[i];
            return null;
        }

        private int nextIndex()
        {
            return ++INDEX;
        }

        public MainForm()
        {
            InitializeComponent();
            Title.DataSource = Enum.GetNames(typeof(InterfaceTable.enums.ProductNames));
            EdSystem.DataSource = Enum.GetNames(typeof(InterfaceTable.enums.UnitIzmerenia));
            Title1.DataSource = Enum.GetNames(typeof(InterfaceTable.enums.ProductNames));
        }

        private void signature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignaturesFrom signForm = new SignaturesFrom();
            signForm.Owner = this;
            signForm.ShowDialog();
        }

        public void setSignatures(List<Worker> employees)
        {
            this.employees = employees;
        }

        private void addRow(DataGridView table, int rowIndex)
        {
            if (table.Rows[rowIndex - 1].Cells[0].Value == null)
                table.Rows[rowIndex - 1].Cells[0].Value = nextIndex();

            Record record = new Record((int)table.Rows[rowIndex - 1].Cells[0].Value);
            records.Add(record);
        }

        private void accountTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (fillFlag == 1)
                return;
            addRow((DataGridView)sender, e.RowIndex);
        }

        private Record cellChange(DataGridView table, int rowIndex, int columnIndex)
        {
            int number = (int)table.Rows[rowIndex].Cells[0].Value;
            Record current = findRecord(number);
            if (current == null)
                return null;
            String val = (String)table.Rows[rowIndex].Cells[columnIndex].Value;
            switch (columnIndex)
            {
                case 1:
                    {
                        current.Recname = val;
                        current.setRec(val);                   
                        fillAccountTable();
                        fillConditionTable();
                    }break;
                case 3:
                    {
                        if (table.Columns[columnIndex].Name == "EdSystem")
                        {
                            current.NameSystem = val;
                            current.setEdSys(val);
                            fillAccountTable();
                            fillConditionTable();
                        }
                        else
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.ColExp = result;
                                current.calc();
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                    } break;
                case 5:
                    {
                        if (table.Columns[columnIndex].Name == "LostNum")
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.Massa = result;
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                        else
                        {
                            int result;
                            bool correct = int.TryParse(val, out result);
                            if (correct)
                            {
                                current.ColDop = result;
                                current.calc();
                                fillAccountTable();
                                fillConditionTable();
                            }
                            else
                            {
                                MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                table.Rows[rowIndex].Cells[columnIndex].Value = "";
                            }
                        }
                    } break;
                case 6:
                    {
                        int result;
                        bool correct = int.TryParse(val, out result);
                        if (correct)
                        {
                            current.Cost = result;
                            current.calc();
                            fillAccountTable();
                            fillConditionTable();
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            table.Rows[rowIndex].Cells[columnIndex].Value = "";
                        }
                    } break;
                case 7:
                    {
                        int result;
                        bool correct = int.TryParse(val, out result);
                        if (correct)
                        {
                            current.ColEnter = result;
                            current.calc();
                            fillAccountTable();
                            fillConditionTable();
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение", "Вы ввели некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            table.Rows[rowIndex].Cells[columnIndex].Value = "";
                        }
                    } break;
                
            }
            return current;
        }

        private void accountTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (fillFlag == 1)
                return;
            if (e.RowIndex < 0)
                return;
            Record current = cellChange((DataGridView)sender, e.RowIndex, e.ColumnIndex);
            if (current == null)
                return;

            countTotal();
        }

        private void conditionsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (fillFlag == 1)
                return;
            addRow((DataGridView)sender, e.RowIndex);
        }

        private void conditionsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || fillFlag == 1)
                return;
            cellChange((DataGridView)sender, e.RowIndex, e.ColumnIndex);

            countTotal();
        }

        private void countTotal()
        {
            int totalCol = 0;
            int totalSum1 = 0;
            int totalSumExp = 0;
            int totalColExp = 0, totalColDop = 0, totalSumDop = 0;
            for (int i = 0; i < accountTable.Rows.Count; i++)
            {              
                if (accountTable.Rows[i].Cells[7].Value != null)
                    totalCol += int.Parse(accountTable.Rows[i].Cells[7].Value.ToString());
                if (accountTable.Rows[i].Cells[8].Value != null)
                    totalSum1 += int.Parse(accountTable.Rows[i].Cells[8].Value.ToString());     
            }

            for (int i = 0; i < conditionsTable.Rows.Count; i++)
            {
                if (conditionsTable.Rows[i].Cells[3].Value != null)
                    totalColExp += int.Parse(conditionsTable.Rows[i].Cells[3].Value.ToString());
                if (conditionsTable.Rows[i].Cells[4].Value != null)
                    totalSumExp += int.Parse(conditionsTable.Rows[i].Cells[4].Value.ToString());
                if (conditionsTable.Rows[i].Cells[5].Value != null)
                    totalColDop += int.Parse(conditionsTable.Rows[i].Cells[5].Value.ToString());
                if (conditionsTable.Rows[i].Cells[6].Value != null)
                    totalSumDop += int.Parse(conditionsTable.Rows[i].Cells[6].Value.ToString());
            }

            total.Text = totalCol.ToString();
            textBox3.Text = totalSum1.ToString();
            textBox2.Text = totalColExp.ToString();
            textBox1.Text = totalSumExp.ToString();
            textBox5.Text = totalColDop.ToString();
            textBox4.Text = totalSumDop.ToString();
            //textBox1.Text = text;
        }

        private void AccountingTab_Selected(object sender, TabControlEventArgs e)
        {
            if (records.Count == 0)
                return;
            int selectedTab = ((TabControl)sender).SelectedIndex;
            if (selectedTab == 0)
                fillAccountTable();
            else fillConditionTable();
        }

        private void fillAccountTable()
        {
            fillFlag = 1;
            accountTable.Rows.Clear();
            accountTable.Rows.Add(records.Count);
            for (int i = 0 ; i < records.Count; i++)
            {
                accountTable.Rows[i].Cells[0].Value = records[i].Number;
                accountTable.Rows[i].Cells[1].Value = records[i].Recname;
                accountTable.Rows[i].Cells[2].Value = records[i].Code;
                accountTable.Rows[i].Cells[3].Value = records[i].NameSystem;
                accountTable.Rows[i].Cells[4].Value = records[i].CodeOkei.ToString();
                accountTable.Rows[i].Cells[5].Value = records[i].Massa.ToString();
                accountTable.Rows[i].Cells[6].Value = records[i].Cost.ToString();
                accountTable.Rows[i].Cells[7].Value = records[i].ColEnter.ToString();
                accountTable.Rows[i].Cells[8].Value = records[i].SumEnter.ToString();
            }
            fillFlag = 0;
        }

        private void fillConditionTable()
        {
            fillFlag = 1;
            conditionsTable.Rows.Clear();
            conditionsTable.Rows.Add(records.Count);
            for (int i = 0; i < records.Count; i++)
            {
                conditionsTable.Rows[i].Cells[0].Value = records[i].Number;
                conditionsTable.Rows[i].Cells[1].Value = records[i].Recname;
                conditionsTable.Rows[i].Cells[2].Value = records[i].Code;
                conditionsTable.Rows[i].Cells[3].Value = records[i].ColExp.ToString();
                conditionsTable.Rows[i].Cells[4].Value = records[i].SumExp.ToString();
                conditionsTable.Rows[i].Cells[5].Value = records[i].ColDop.ToString();
                conditionsTable.Rows[i].Cells[6].Value = records[i].SumDop.ToString();
            }
            fillFlag = 0;
        }


        private void deleteRecord(DataGridViewRow row)
        {
            if (fillFlag == 1)
                return;
            int number = (int)row.Cells[0].Value;
            Record current = findRecord(number);
            records.Remove(current);
        }

        private void conditionsTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteRecord(e.Row);
        }

        private void accountTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteRecord(e.Row);
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            // Открываем приложение
            application = new Application
            {
                DisplayAlerts = false
            };

            // Файл шаблона
            const string template = "templ.xlsx";

            // Открываем книгу
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            worksheet = workBook.ActiveSheet as Worksheet;

            // Записываем данные
            worksheet.Range["A7"].Value = organName.SelectedItem;
            worksheet.Range["A9"].Value = organStruct.SelectedItem;
            worksheet.Range["BA13"].Value = numberDocument.Text;
            worksheet.Range["BL13"].Value = dateDocument.Value.Date;
            worksheet.Range["CA7"].Value = formOKPO.Text;
            worksheet.Range["CA10"].Value = viewOKPD.Text;
            worksheet.Range["CA11"].Value = viewOperation.Text;
            worksheet.Range["BX32"].Value = dopDocument.Text;


            if (employees != null)
            {
                worksheet.Range["R32"].Value = employees[0].FullName;
                worksheet.Range["BC32"].Value = employees[2].FullName;
                worksheet.Range["S34"].Value = employees[1].Post;
                worksheet.Range["AX34"].Value = employees[1].FullName;
            }
            else
            {
                MessageBox.Show("Ошибка", "Подписи не расшифрованы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int pivot = 23;
            for (int i = 0; i < records.Count; i++)
            {
                if (pivot == 31)
                    break;
                worksheet.Cells[pivot, "A"].Value = records[i].Number;
                worksheet.Cells[pivot, "D"].Value = records[i].Recname;
                worksheet.Cells[pivot, "N"].Value = records[i].Code;
                worksheet.Cells[pivot, "Q"].Value = records[i].NameSystem;
                worksheet.Cells[pivot, "U"].Value = records[i].CodeOkei;
                worksheet.Cells[pivot, "Y"].Value = records[i].Massa;
                worksheet.Cells[pivot, "AC"].Value = records[i].Cost;
                worksheet.Cells[pivot, "AX"].Value = records[i].ColEnter;
                worksheet.Cells[pivot, "BB"].Value = records[i].SumEnter;
                worksheet.Cells[pivot, "BH"].Value = records[i].ColExp;
                worksheet.Cells[pivot, "BL"].Value = records[i].SumExp;
                worksheet.Cells[pivot, "BQ"].Value = records[i].ColDop;
                worksheet.Cells[pivot, "BU"].Value = records[i].SumDop;
                pivot++;
            }

            worksheet.Cells[31, "AX"].Value = total.Text;
            worksheet.Cells[31, "BB"].Value = textBox3.Text;
            worksheet.Cells[31, "BH"].Value = textBox2.Text;
            worksheet.Cells[31, "BL"].Value = textBox1.Text;
            worksheet.Cells[31, "BQ"].Value = textBox5.Text;
            worksheet.Cells[31, "BU"].Value = textBox4.Text;

            // Показываем приложение
            application.Visible = true;
            //TopMost = true;

            string savedFileName = "ОП-24.xlsx";
            workBook.SaveAs(Path.Combine(Environment.CurrentDirectory, savedFileName));
            CloseExcel();
        }

        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);

                Marshal.ReleaseComObject(worksheet);
                workBook.Close();
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);

                application = null;
                // Прибиваем висящий процесс
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);

        private void button1_Click(object sender, EventArgs e)
        {
            SignaturesFrom signForm = new SignaturesFrom();
            signForm.Owner = this;
            signForm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void accountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignaturesFrom signForm = new SignaturesFrom();
            signForm.Owner = this;
            signForm.ShowDialog();
        }
    }
}
