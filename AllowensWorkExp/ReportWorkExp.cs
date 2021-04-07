using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace AllowensWorkExp
{
    [Export(typeof(IReport))]
    public class ReportWorkExp : IReport
    {
        public string name => "приказ о надбавке за стаж";
        public void Report(IEnumerable<Employee> units)
        {
            SavePDF savePdf = new SavePDF();
            savePdf.CreatePdf(units);
        }
    }
}
