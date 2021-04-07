using Database;
using EM_3_MainLogic.Binding_Model;
using EM_3_MainLogic.Interface;
using EM_3_MainLogic.Logic;
using EM_3_MainLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;

namespace EM_3_MainLogic
{
    public class PluginManager
    {
        [ImportMany(typeof(IUpdate))]
        IEnumerable<IUpdate> updates { get; set; }
        [ImportMany(typeof(IReport))]
        IEnumerable<IReport> reports { get; set; }

        public readonly Dictionary<string, Action<IEnumerable<Employee>>> report = new Dictionary<string, Action<IEnumerable<Employee>>>();
        public readonly Dictionary<string, Action<Employee, EmployeeLogic, Action>> update = new Dictionary<string, Action<Employee, EmployeeLogic, Action>>();
        public List<string> Headers { get; set; }
        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            Headers = new List<string>();
            if (updates.Count() != 0)
            {
                updates.ToList()
                       .ForEach(prop => update.Add(prop.name, prop.Update));
                Headers.AddRange(update.Keys.ToList());
            }
            if (reports.Count() != 0)
            {
                reports.ToList().ForEach(prop => report.Add(prop.name, prop.Report));
                Headers.AddRange(report.Keys.ToList());
            }
        }
    }
}
