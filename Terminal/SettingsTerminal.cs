using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Terminal
{
    internal class SettingsTerminal
    {
        public int CountPC { get; private set; } = 25;
        public string ComPort { get; private set; } = "COM1";
        public string NameServer { get; private set; } = "localhost";
        public string IPHost { get; private set; } = "192.168.0.10";
        public bool Debug { get; private set; } = false;

        private static SettingsTerminal instance;
        public static SettingsTerminal Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsTerminal();
                    instance.Load();
                }
                return instance;

            }
        }

        private SettingsTerminal() { }


        private void Load()
        {

            string[] temp = new string[0];
            bool needSaveConfig = false;
            try
            {
                temp = File.ReadAllLines(".\\terminal.ini");
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
                        case nameof(CountPC):
                            if (int.TryParse(subs[1], out int countPC))
                            {
                                CountPC = countPC;
                            }
                            else
                            {
                                needSaveConfig = true;
                            }
                            break;
                        case "comPort":
                            if (!string.IsNullOrWhiteSpace(subs[1]))
                            {
                                ComPort = subs[1];
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
                        case "IPHost":
                            if (!string.IsNullOrWhiteSpace(subs[1]))
                            {
                                IPHost = subs[1];
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
                using (StreamWriter writer = new StreamWriter(".\\terminal.ini", false))
                {
                    writer.WriteLine($"{nameof(CountPC)}={CountPC}");
                    writer.WriteLine($"{nameof(ComPort)}={ComPort}");
                    writer.WriteLine($"{nameof(NameServer)}={NameServer}");
                    writer.WriteLine($"{nameof(IPHost)}={IPHost}");
                    writer.WriteLine($"{nameof(Debug)}={Debug}");
                }
            }
            catch
            {
                throw new Exception("Нет доступа у файлу настроек для записи");
            }
        }
    }
}
