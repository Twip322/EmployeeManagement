﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeManagementUCsec
{
    public partial class Backup: UserControl
    {
        public Backup()
        {
            InitializeComponent();
        }

        public Backup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void saveData<T>(String path, T[] data)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var type = data.GetType();
            if (!type.IsSerializable)
            {
                throw new Exception("Класс не сериализуемый");
            }
            try
            {
                var serializer = new XmlSerializer(typeof(T[]));
                string tempPath = path + "/temp";
                var tempDir = Directory.CreateDirectory(tempPath);
                string pathXml = tempPath + "/backup.xml";

                using (var output = new FileStream(pathXml, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(output, data);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка сериализации", ex);
            }
        }
        public T LoadXml<T>(string Path)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new Exception("Класс не сериализуем");
            }
            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                T temp = (T)formatter.Deserialize(fs);
                return temp;

            }
        }
    }
}
