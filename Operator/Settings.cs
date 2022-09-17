using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    
    class Settings
    {
        public int WindowPositionX { get; set; } = 10;
        public int WindowPositionY { get; set; } = 10;
        public int WindowHeight { get; set; } = 500;
        public string NameServer { get; private set; } = "localhost";
        public bool Debug { get; private set; } = false;

        private static Settings instance;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                    instance.Load();
                }
                return instance;

            }
        }

        private Settings() { }

        public void SaveConfig()
        {
            CreateConfig();
        }

        private void Load()
        {

            string[] temp = new string[0];
            bool needSaveConfig = false;
            try
            {
                temp = File.ReadAllLines(".\\operator.ini");
            }
            catch
            {
                CreateConfig();
                return;
            }

            foreach (string line in temp)
            {

                string[] subs = line.Split('='); //Мы нашли строку, и пытаемся ее поделить по разделителю "=". Если такого разделителя нет, выдадим ошибку
                if (subs.Length == 2)//в массиве должно быть только 2 значения. Иначе прерываем
                {
                    switch (subs[0])
                    {
                        case nameof(WindowPositionX):
                            if (int.TryParse(subs[1], out int PositionX))
                            {
                                WindowPositionX = PositionX;
                            }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                        case nameof(WindowPositionY):
                            if (int.TryParse(subs[1], out int PositionY))
                            {
                                WindowPositionY = PositionY;
                            }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                        case "NameServer":
                            if (!string.IsNullOrWhiteSpace(subs[1]))
                            {
                                NameServer = subs[1];
                            }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                        case nameof(WindowHeight):
                            if (int.TryParse(subs[1], out int Height))
                            {
                                WindowHeight = Height;
                            }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                        case "Debug":
                            if (!string.IsNullOrWhiteSpace(subs[1]))
                            {
                                if (bool.TryParse(subs[1], out bool value))
                                {
                                    Debug = value;
                                }
                             }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                    }

                }
            }
            if (needSaveConfig)
            {
                CreateConfig();
            }
        }

        private void CreateConfig()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(".\\operator.ini", false))
                {
                    writer.WriteLine($"{nameof(WindowPositionX)}={WindowPositionX}");
                    writer.WriteLine($"{nameof(WindowPositionY)}={WindowPositionY}");
                    //writer.WriteLine($"{nameof(NameServer)}={NameServer}");
                    writer.WriteLine($"{nameof(WindowHeight)}={WindowHeight}");
                    // writer.WriteLine($"{nameof(Debug)}={Debug}");
                }
            }
            catch
            {
                throw new Exception("Нет доступа к файлу настроек для записи");
            }
        }
    }
}

