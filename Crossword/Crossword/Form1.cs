using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Text;
using System.Runtime.Serialization.Formatters.Binary;
using CrosswordCall;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace Crossword
{
    public partial class crosswordForm : Form
    {
        Dictionary<string, string> dictionary;
        List<List<Call>> listCall;
        List<DataWord> listDataWord;
        List<LetterCall> listLetterCall;
        Dictionary<char, char> engToRus;
        Bitmap polePrint;
        bool modeGame;

        public crosswordForm()
        {
            InitializeComponent();

            dictionary = new Dictionary<string, string>();
            listDataWord = new List<DataWord>();
            listCall = new List<List<Call>>();
            listLetterCall = new List<LetterCall>();
            modeGame = false;

            LoadWords();
            AddCrosswodCall();
            crosswordForm_Resize(null, null);
            LoadFontsToComboBox();
            LoadAlphabetKeys();
        }

        private void LoadAlphabetKeys()
        {
            engToRus = new Dictionary<char, char>();
            string eng = "QWERTYUIOP" + (char)219 + (char)221 + "ASDFGHJKL" + (char)186 + (char)222 + "ZXCVBNM" + (char)188 + (char)190 + " ";
            string rus = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ ";

            for (int i = 0; i < rus.Length; i++)
                engToRus.Add(eng[i], rus[i]);
        }

        private void AddCrosswodCall()
        {
            for (int i = 0; i < (int)numericHeight.Value; i++)
            {
                listCall.Add(new List<Call>());

                for (int j = 0; j < (int)numericWidth.Value; j++)
                    listCall[i].Add(NewCall(j, i));
            }

            pictureBoxField.Width = 35 * (int)numericWidth.Value;
            pictureBoxField.Height = 35 * (int)numericHeight.Value;
        }

        private Call NewCall(int x, int y)
        {
            Call call = new Call();
            call.Parent = pictureBoxField;
            call.Location = new Point(35 * x, 35 * y);
            call.LetterCall.MouseDown += call_MouseDown;
            call.NumberTop.MouseDown += call_MouseDown;
            call.NumberBottom.MouseDown += call_MouseDown;
            pictureBoxField.Controls.Add(call);
            return call;
        }

        private void LoadFontsToComboBox()
        {
            InstalledFontCollection fontList = new InstalledFontCollection();

            for (int i = 0; i < fontList.Families.Length; i++)
            {
                comboBoxFonts.Items.Add(fontList.Families[i].Name);

                if (fontList.Families[i].Name == listCall[0][0].LetterCall.Font.FontFamily.Name)
                    comboBoxFonts.SelectedIndex = i;
            }
        }

        private void AddLineCall(bool horizontal)
        {
            if (horizontal)
            {
                for (int i = 0; i < (int)numericHeight.Value; i++)
                    for (int j = listCall[i].Count; j < (int)numericWidth.Value; j++)
                        listCall[i].Add(NewCall(j, i));
            }
            else
            {
                for (int i = listCall.Count; i < (int)numericHeight.Value; i++)
                {
                    listCall.Add(new List<Call>());

                    for (int j = 0; j < (int)numericWidth.Value; j++)
                        listCall[i].Add(NewCall(j, i));
                }
            }

            pictureBoxField.Width = 35 * (int)numericWidth.Value;
            pictureBoxField.Height = 35 * (int)numericHeight.Value;
        }

        private void DelLineCall(bool horizontal)
        {
            if (horizontal)
            {
                for (int i = 0; i < (int)numericHeight.Value; i++)
                    for (int j = listCall[i].Count; j > (int)numericWidth.Value; j--)
                        listCall[i].RemoveAt(j - 1);
            }
            else
            {
                for (int i = listCall.Count; i > (int)numericHeight.Value; i--)
                    listCall.RemoveAt(i - 1);
            }

            pictureBoxField.Width = 35 * (int)numericWidth.Value;
            pictureBoxField.Height = 35 * (int)numericHeight.Value;
        }

        private void LoadWords()
        {
            try
            {
                using (StreamReader streamRead = new StreamReader("dictionary.txt", Encoding.Default))
                {
                    string str;
                    Regex regex = new Regex("[А-Я]{3,}");
                    Match match;

                    while (!streamRead.EndOfStream)
                    {
                        str = streamRead.ReadLine();
                        match = regex.Match(str);

                        if (!dictionary.ContainsKey(match.Value) && str != "")
                            dictionary.Add(match.Value, str.Substring(match.Value.Length, str.Length - match.Value.Length));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AnalysisField()
        {
            for (int i = 0; i < listCall.Count; i++)
                for (int j = 0; j < listCall[0].Count; j++)
                    if (listCall[i][j].BackColor == Color.White)
                    {
                        // Слово по горизонтали

                        if (j > 0 && j < listCall[0].Count - 1)
                        {
                            if (listCall[i][j - 1].BackColor == Color.Transparent && listCall[i][j + 1].BackColor == Color.White)
                                NewDataWord(j, i, PositionType.Hozizontal);

                        }
                        else if(j == 0)
                        {
                            if (listCall[i][j + 1].BackColor == Color.White)
                                NewDataWord(j, i, PositionType.Hozizontal);
                        }

                        // Слово по вертикали

                        if (i > 0 && i < listCall.Count - 1)
                        {
                            if (listCall[i - 1][j].BackColor == Color.Transparent && listCall[i + 1][j].BackColor == Color.White)
                                NewDataWord(j, i, PositionType.Vetrical);
                        }
                        else if (i == 0)
                        {
                            if (listCall[i + 1][j].BackColor == Color.White)
                                NewDataWord(j, i, PositionType.Vetrical);
                        }
                    }
        }

        private void NewDataWord(int x, int y, PositionType pt)
        {
            int count = 0;

            if (pt == PositionType.Vetrical)
                for (int i = y; i < listCall.Count; i++)
                {
                    if (listCall[i][x].BackColor == Color.White)
                        count++;
                    else
                        break;
                }
            else if (pt == PositionType.Hozizontal)
                for (int i = x; i < listCall[0].Count; i++)
                {
                    if (listCall[y][i].BackColor == Color.White)
                        count++;
                    else
                        break;
                }
            else
                return;

            listDataWord.Add(new DataWord(x, y, count, pt));
        }

        private void EnterLettersCalls(DataWord dw)
        {
            if (dw.word == null || dw.word == "")
                return;

            for (int i = 0; i < dw.length; i++)
            {
                if (dw.type == PositionType.Hozizontal)
                    listCall[dw.y][dw.x + i].LetterCall.Text = dw.word[i].ToString();
                else if (dw.type == PositionType.Vetrical)
                    listCall[dw.y + i][dw.x].LetterCall.Text = dw.word[i].ToString();
            }  
        }

        private void NewQuestionsToPanel(int i, string str)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Margin = new Padding(25, 0, 0, 0);
            label.Width = 300;
            label.Height = 50;
            label.Font = new Font("Verdana", 10);
            label.Text = (i + 1).ToString() + ". " + str;
            questionsPanel.Controls.Add(label);
        }

        private void FillCallsWords()
        {
            panelImageScroll.Invalidate();
            panelImageScroll.SuspendLayout();
            Cursor = Cursors.WaitCursor;

            DataWord dw;
            string pattern;
            bool unique, found;
            DateTime timeStart = DateTime.Now;

            if (listDataWord.Count == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Заполните пожалуйста, поле кроссворда.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < listDataWord.Count; i++)
            {
                dw = listDataWord[i];
                pattern = "";

                if (dw.length < 3)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Количество букв в слове должно быть больше 2-х.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Отобажение номера вопроса

                if (listDataWord[i].type == PositionType.Hozizontal)
                    listCall[dw.y][dw.x].NumberTop.Text = (i + 1).ToString();
                else
                    listCall[dw.y][dw.x].NumberBottom.Text = (i + 1).ToString();

                // Составление шаблона поиска

                for (int j = 0; j < dw.length; j++)
                {
                    if (dw.type == PositionType.Hozizontal)
                    {
                        if (listCall[dw.y][dw.x + j].LetterCall.Text == "")
                            pattern += "[А-Я]";
                        else
                            pattern += "[" + listCall[dw.y][dw.x + j].LetterCall.Text + "]";
                    }
                    else if (dw.type == PositionType.Vetrical)
                    {
                        if (listCall[dw.y + j][dw.x].LetterCall.Text == "")
                            pattern += "[А-Я]";
                        else
                            pattern += "[" + listCall[dw.y + j][dw.x].LetterCall.Text + "]";
                    }
                }

                // Поиск слова

                Regex regex = new Regex(pattern);
                found = false;

                for (int j = 0; j < dictionary.Count; j++)
                    if (dictionary.Keys.ElementAt(j).Length == dw.length)
                    {
                        unique = true;

                        for (int k = 0; k < listDataWord.Count; k++)
                            if (dictionary.Keys.ElementAt(j) == listDataWord[k].word)
                            {
                                unique = false;
                                break;
                            }

                        if (unique)
                            if (regex.Match(dictionary.Keys.ElementAt(j)).Success)
                            {
                                dw.word = dictionary.Keys.ElementAt(j);
                                NewQuestionsToPanel(i, dictionary.Values.ElementAt(j));
                                EnterLettersCalls(dw);
                                found = true;
                                break;
                            }
                    }

                if (found == false)
                {
                    TimeSpan timeSpan = DateTime.Now - timeStart;

                    if (timeSpan.TotalSeconds > 60)
                    {
                        if (MessageBox.Show("Прошло больше 60 секунд, вы хотите продолжить поиск?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            panelImageScroll.ResumeLayout(false);
                            return;
                        }
                        else
                            timeStart = DateTime.Now;
                    }

                    Random rand = new Random();
                    dictionary = dictionary.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);

                    ClearCalls(false);
                    ClearDataWords();
                    questionsPanel.Controls.Clear();
                    i = -1;
                }
            }

            Cursor = Cursors.Default;
            panelImageScroll.ResumeLayout(false);
        }

        private void ClearCalls(bool bg = false, bool num = true)
        {
            for (int i = 0; i < listCall.Count; i++)
                for (int j = 0; j < listCall[0].Count; j++)
                {
                    listCall[i][j].LetterCall.Text = "";

                    if (num)
                    {
                        listCall[i][j].NumberTop.Text = "";
                        listCall[i][j].NumberBottom.Text = "";
                    }

                    if (bg)
                        listCall[i][j].BackColor = Color.Transparent;
                }
        }

        private void EditCalls()
        {
            Cursor = Cursors.WaitCursor;
            FontStyle fs = FontStyle.Regular;

            if (buttonBold.BackColor == Color.LightSteelBlue)
                fs = FontStyle.Bold;

            if (buttonItalic.BackColor == Color.LightSteelBlue)
                fs = fs | FontStyle.Italic;

            if (buttonUnderline.BackColor == Color.LightSteelBlue)
                fs = fs | FontStyle.Underline;

            for (int i = 0; i < listCall.Count; i++)
                for (int j = 0; j < listCall[0].Count; j++)
                {
                    listCall[i][j].LetterCall.ForeColor = buttonColor.BackColor;
                    listCall[i][j].LetterCall.Font = new Font(comboBoxFonts.SelectedItem.ToString(), (int)numericSizeFont.Value, fs);
                }

            Cursor = Cursors.Default;
        }

        private void SerializableCrossword(string fileName)
        {
            try
            {
                MediatorSerializableData msd = new MediatorSerializableData(dictionary, listDataWord, listLetterCall, pictureBoxField.Image, listCall[0][0].LetterCall.Font, buttonColor.BackColor, (int)numericWidth.Value, (int)numericHeight.Value);
                BinaryFormatter binFormat = new BinaryFormatter();

                using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    binFormat.Serialize(fStream, msd);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void DeserializeCrossword(string fileName)
        {
            try
            {
                MediatorSerializableData msd;
                BinaryFormatter binFormat = new BinaryFormatter();

                using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    msd = (MediatorSerializableData)binFormat.Deserialize(fStream);
                }

                toolStripNew_Click(null, null);

                dictionary = msd.dictionary;
                listDataWord = msd.listDataWord;
                listLetterCall = msd.listLetterCall;
                pictureBoxField.Image = msd.image;
                pictureBoxBg.Image = msd.image;
                numericWidth.Value = msd.width;
                numericHeight.Value = msd.height;

                numericSizeFont.Value = (int)msd.font.Size;
                buttonColor.BackColor = msd.color;
                buttonBold.BackColor = (msd.font.Bold) ? Color.LightSteelBlue : Color.White;
                buttonItalic.BackColor = (msd.font.Italic) ? Color.LightSteelBlue : Color.White;
                buttonUnderline.BackColor = (msd.font.Underline) ? Color.LightSteelBlue : Color.White;

                for (int i = 0; i < comboBoxFonts.Items.Count; i++)
                    if (comboBoxFonts.Items[i].ToString() == msd.font.FontFamily.Name)
                        comboBoxFonts.SelectedIndex = i;

                List<DataWord> ldw = msd.listDataWord;

                for (int i = 0; i < ldw.Count; i++)
                {
                    // Отображаем номер вопроса

                    if (listDataWord[i].type == PositionType.Hozizontal)
                        listCall[ldw[i].y][ldw[i].x].NumberTop.Text = (i + 1).ToString();
                    else
                        listCall[ldw[i].y][ldw[i].x].NumberBottom.Text = (i + 1).ToString();

                    Call call;

                    for (int j = 0; j < ldw[i].length; j++)
                    {

                        if (ldw[i].type == PositionType.Hozizontal)
                            call = listCall[ldw[i].y][ldw[i].x + j];
                        else
                            call = listCall[ldw[i].y + j][ldw[i].x];

                        call.BackColor = Color.White;
                        call.LetterCall.Font = msd.font;
                        call.LetterCall.ForeColor = msd.color;
                        call.LetterCall.BackColor = Color.Transparent;

                        EnterLettersCalls(ldw[i]);
                    }

                    NewQuestionsToPanel(i, dictionary[ldw[i].word]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearCallAfterClick()
        {
            for (int i = 0; i < listCall.Count; i++)
                for (int j = 0; j < listCall[0].Count; j++)
                    if (listCall[i][j].BackColor == Color.LightSteelBlue || listCall[i][j].BackColor == Color.Red)
                        listCall[i][j].BackColor = Color.White;
        }

        private void ClearDataWords()
        {
            for (int i = 0; i < listDataWord.Count; i++)
                listDataWord[i].word = "";
        }

        private void ScreenCrossword()
        {
            if (polePrint != null)
                polePrint.Dispose();

            polePrint = new Bitmap(panelImageScroll.Width, panelImageScroll.Height, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(polePrint);
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = panelImageScroll.RectangleToScreen(panelImageScroll.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, panelImageScroll.Size);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Crossword", panelImageScroll.Width, panelImageScroll.Height);
        }

        // События...

        private void call_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Label label = (Label)sender;
                Call parent;

                if (label.Parent.GetType() == typeof(Call))
                    parent = (Call)label.Parent;
                else
                    parent = (Call)label.Parent.Parent;

                if (!modeGame)
                {
                    if (parent.BackColor == Color.Transparent)
                        parent.BackColor = Color.White;
                    else
                    {
                        parent.BackColor = Color.Transparent;
                        parent.LetterCall.Text = "";
                        parent.NumberTop.Text = "";
                        parent.NumberBottom.Text = "";
                    }
                }
                else
                {
                    ClearCallAfterClick();

                    if (parent.BackColor == Color.White)
                        parent.BackColor = Color.LightSteelBlue;

                    toolStripСheck.CheckState = CheckState.Unchecked;

                    pictureBoxField.Focus();
                }

                parent.LetterCall.BackColor = Color.Transparent;
            }
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            if (listCall[0].Count < (int)numericWidth.Value)
                AddLineCall(true);
            else if (listCall[0].Count > (int)numericWidth.Value)
                DelLineCall(true);

            crosswordForm_Resize(null, null);
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            if (listCall.Count < (int)numericHeight.Value)
                AddLineCall(false);
            else if (listCall.Count > (int)numericHeight.Value)
                DelLineCall(false);

            crosswordForm_Resize(null, null);
        }

        private void crosswordForm_Resize(object sender, EventArgs e)
        {
            panelImageScroll.SuspendLayout();

            if (tableLayoutPanel.Size.Width - 250 > (35 * (int)numericWidth.Value))
                pictureBoxField.Location = new Point((tableLayoutPanel.Size.Width - 250 - (35 * (int)numericWidth.Value)) / 2, pictureBoxField.Location.Y);
            else
                pictureBoxField.Location = new Point(0, pictureBoxField.Location.Y);

            if (tableLayoutPanel.Size.Height - questionsPanel.Height > (35 * (int)numericHeight.Value))
                pictureBoxField.Location = new Point(pictureBoxField.Location.X, (tableLayoutPanel.Size.Height - questionsPanel.Height - (35 * (int)numericHeight.Value)) / 2);
            else
                pictureBoxField.Location = new Point(pictureBoxField.Location.X, 0);

            questionsPanel.Location = new Point(0, panelImageScroll.Height - questionsPanel.Height);
            questionsPanel.Width = panelImageScroll.Width;
        }

        private void crosswordForm_ResizeEnd(object sender, EventArgs e)
        {
            panelImageScroll.ResumeLayout(false);
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            listDataWord.Clear();
            ClearCalls(true);
            questionsPanel.Controls.Clear();
            listLetterCall.Clear();
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                DeserializeCrossword(openFileDialog1.FileName);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                SerializableCrossword(saveFileDialog1.FileName);
        }

        private void toolStripPrint_ButtonClick(object sender, EventArgs e)
        {
            ScreenCrossword();

            if(printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScreenCrossword();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripGeneration_Click(object sender, EventArgs e)
        {
            listDataWord.Clear();
            ClearCalls();
            questionsPanel.Controls.Clear();
            listLetterCall.Clear();
            AnalysisField();

            Random rand = new Random();
            dictionary = dictionary.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
        
            FillCallsWords();
        }

        private void toolStripHideWord_Click(object sender, EventArgs e)
        {
            if (toolStripHideWord.CheckState == CheckState.Checked)
            {
                ClearCalls(false, false);
                toolStripHideWord.Text = "Показать слова";
            }
            else
            {
                toolStripHideWord.Text = "Скрыть слова";

                for (int i = 0; i < listDataWord.Count; i++)
                    EnterLettersCalls(listDataWord[i]);
            }
        }

        private void toolStripPlay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStripMenu.Items.Count; i++)
                if (i != toolStripMenu.Items.Count - 2 && i != 2)
                    toolStripMenu.Items[i].Enabled = !toolStripMenu.Items[i].Enabled;

            panelParameters.Enabled = !panelParameters.Enabled;
            modeGame = !modeGame;

            if (toolStripPlay.CheckState == CheckState.Checked)
            {
                ClearCalls(false, false);
                for (int i = 0; i < listLetterCall.Count; i++)
                    listCall[listLetterCall[i].y][listLetterCall[i].x].LetterCall.Text = listLetterCall[i].symbol.ToString();
            }
            else
            {
                ClearCallAfterClick();

                for (int i = 0; i < listDataWord.Count; i++)
                    EnterLettersCalls(listDataWord[i]);
            }
        }

        private void toolStripСheck_Click(object sender, EventArgs e)
        {
            ClearCallAfterClick();

            if (toolStripСheck.CheckState == CheckState.Checked)
                for (int i = 0; i < listDataWord.Count; i++)
			    {
                    if (listDataWord[i].word != null && listDataWord[i].word != "")
                    {
                        if (listDataWord[i].type == PositionType.Hozizontal)
                        {
                            for (int j = 0; j < listLetterCall.Count; j++)
                                if (listDataWord[i].x <= listLetterCall[j].x && listDataWord[i].x + listDataWord[i].length >= listLetterCall[j].x && listDataWord[i].y == listLetterCall[j].y)
                                {
                                    if (listLetterCall[j].symbol.ToString() != "" && listLetterCall[j].symbol.ToString() != " ")
                                        if (listLetterCall[j].symbol.ToString() != listDataWord[i].word[listLetterCall[j].x - listDataWord[i].x].ToString())
                                            listCall[listLetterCall[j].y][listLetterCall[j].x].BackColor = Color.Red;
                                }
                        }
                        else if (listDataWord[i].type == PositionType.Vetrical)
                        {
                            for (int j = 0; j < listLetterCall.Count; j++)
                                if (listDataWord[i].y <= listLetterCall[j].y && listDataWord[i].y + listDataWord[i].length >= listLetterCall[j].y && listDataWord[i].x == listLetterCall[j].x)
                                {
                                    if (listLetterCall[j].symbol.ToString() != "" && listLetterCall[j].symbol.ToString() != " ")
                                        if (listLetterCall[j].symbol.ToString() != listDataWord[i].word[listLetterCall[j].y - listDataWord[i].y].ToString())
                                            listCall[listLetterCall[j].y][listLetterCall[j].x].BackColor = Color.Red;
                                }
                        }
                    }
			    }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog1.Color;
                EditCalls();
            }
        }

        private void numericSizeFont_ValueChanged(object sender, EventArgs e)
        {
            EditCalls();
        }

        private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditCalls();
        }

        private void pictureBoxBg_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBg.Image = new Bitmap(openFileDialogImage.FileName);
                pictureBoxField.Image = pictureBoxBg.Image;
            }
        }

        private void fontStyle_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == SystemColors.Control)
                button.BackColor = Color.LightSteelBlue;
            else
                button.BackColor = SystemColors.Control;

            EditCalls();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (polePrint != null)
                e.Graphics.DrawImage(polePrint, new Point(0, 0));
        }

        private void pictureBoxField_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            char symbol = Convert.ToChar(e.KeyCode);
            
            if (engToRus.ContainsKey(symbol))
                if (Regex.Match(engToRus[symbol].ToString(), "[А-Я ]").Success)
                {
                    for (int i = 0; i < listCall.Count; i++)
                        for (int j = 0; j < listCall[0].Count; j++)
                            if (listCall[i][j].BackColor == Color.LightSteelBlue)
                            {
                                for (int k = 0; k < listLetterCall.Count; k++)
                                    if (listLetterCall[k].x == j && listLetterCall[k].y == i)
                                    {
                                        listLetterCall.RemoveAt(k);
                                        break;
                                    }

                                listLetterCall.Add(new LetterCall(j, i, engToRus[symbol]));
                                listCall[i][j].LetterCall.Text = engToRus[symbol].ToString();

                                return;
                            }
                }
        }

    }

    [Serializable]
    enum PositionType { Vetrical, Hozizontal }

    [Serializable]
    class DataWord
    {
        public string word { get; set; }
        public int x { get; private set; }
        public int y { get; private set; }
        public int length { get; private set; }
        public PositionType type { get; private set; }

        public DataWord(int x, int y, int l, PositionType t)
        {
            this.x = x;
            this.y = y;
            length = l;
            type = t;
        }
    }

    [Serializable]
    class LetterCall
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public char symbol { get; private set; }

        public LetterCall(int x, int y, char s)
        {
            this.x = x;
            this.y = y;
            symbol = s;
        }
    }

    [Serializable]
    class MediatorSerializableData
    {
        public Dictionary<string, string> dictionary { get; private set; }
        public List<DataWord> listDataWord { get; private set; }
        public List<LetterCall> listLetterCall { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        public Image image { get; private set; }
        public Font font { get; private set; }
        public Color color { get; private set; }

        public MediatorSerializableData(Dictionary<string, string> d, List<DataWord> ldw, List<LetterCall> llc, Image img, Font f, Color c, int w, int h)
        {
            dictionary = d;
            listDataWord = ldw;
            listLetterCall = llc;
            image = img;
            font = f;
            color = c;
            width = w;
            height = h;
        }

        public MediatorSerializableData() { }
    }
}
