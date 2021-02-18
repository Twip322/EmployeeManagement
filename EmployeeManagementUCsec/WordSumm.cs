using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;

namespace EmployeeManagementUCsec
{
    public partial class WordSumm : UserControl
    {
        public int columnCount;
        public int rowCount;

        private List<List<String>> data;
        public WordSumm()
        {
            InitializeComponent();
        }

        public WordSumm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public void SetData(List<List<String>> contentsColumns)
        {
            this.data = contentsColumns;
        }

        public void CreateTable(String[] columnNames, String[] rowNames, String fileName)
        {
            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                // rowCount = rowNames!=null ? rowNames.Length : 0;
                // columnCount = columnNames!=null? columnNames.Length : 0;
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                winword.Documents.Add(ref missing, ref missing, ref missing, ref
               missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();
                //создаем таблицу
                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, rowCount + (columnNames != null ? 1 : 0), columnCount + (rowNames != null ? 1 : 0), ref missing, ref missing);
                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;
                int columnOffset = 0;
                int rowOffset = 0;
                if (columnNames != null)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        table.Cell(1, i + 1 + (rowNames != null ? 1 : 0)).Range.Text = columnNames[i];
                    }
                    rowOffset = 1;
                }
                if (rowNames != null)
                {
                    for (int i = 0; i < rowCount; i++)
                    {
                        table.Cell(i + 1 + (columnNames != null ? 1 : 0), 1).Range.Text = rowNames[i];
                    }
                    columnOffset = 1;
                }
                for (int i = 0; i < rowCount; ++i)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        table.Cell(i + rowOffset + 1, j + columnOffset + 1).Range.Text = data[j][i];
                    }
                }
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(fileName, ref fileFormat, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);
                document.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                winword.Quit();
                System.Diagnostics.Process.Start(fileName);
            }

        }
       

    }
}
