using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Operator
{
    internal class Logger
    {
        private static Logger instance;
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                    //instance.ReadLog();
                }
                return instance;
            }
        }

        public void WriteLog(List<ActionInfo> values)
        {
            Task.Run(() =>
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(".\\operator.log", false))
                    {
                        int i = 1;
                        foreach (ActionInfo value in values.OrderBy(x => x.Position))
                        {
                            var date = value.IncomeDate > DateTime.MinValue ? value.IncomeDate : DateTime.Now;
                            writer.Write($"{nameof(value.Position)}={i++};");
                            writer.Write($"{nameof(value.IncomeDate)}={date};");
                            writer.Write($"{nameof(value.PCName)}={value.PCName};");
                            writer.Write($"{nameof(value.Quantity)}={value.Quantity};");
                            writer.Write($"{nameof(value.State)}={value.State};");
                            writer.Write($"{nameof(value.TypeID)}={value.TypeID};");
                            writer.WriteLine();
                        }
                    }
                }
                catch
                {
                    throw new Exception("Нет доступа к файлу логирования для записи");
                }
            });
        }

        public List<ActionInfo> ReadLog()
        {
            List<ActionInfo> list = new List<ActionInfo>();

            string[] temp = new string[0];

            //bool needSaveConfig = false;
            try
            {
                temp = File.ReadAllLines(".\\operator.log");
            }
            catch
            {
                return new List<ActionInfo>();
            }

            foreach (string line in temp)
            {
                ActionInfo actionInfo = new ActionInfo();
                list.Add(actionInfo);
                string[] subs = line.Split(';');
                if (subs.Length > 5)
                {
                    foreach (string lineSubs in subs)
                    {
                        string[] subsLine = lineSubs.Split('=');
                        switch (subsLine[0])
                        {
                            case nameof(ActionInfo.Position):
                                if (int.TryParse(subsLine[1], out int Position1))
                                {
                                    actionInfo.Position = Position1;
                                }
                                break;
                            case nameof(ActionInfo.IncomeDate):
                                if (DateTime.TryParse(subsLine[1], out DateTime IncomeDate))
                                {
                                    actionInfo.IncomeDate = IncomeDate;
                                }
                                break;
                            case nameof(ActionInfo.PCName):
                                if (int.TryParse(subsLine[1], out int PCName))
                                {
                                    actionInfo.PCName = PCName;
                                }
                                break;
                            case nameof(ActionInfo.Quantity):
                                if (int.TryParse(subsLine[1], out int Quantity))
                                {
                                    actionInfo.Quantity = Quantity;
                                }
                                break;
                            case nameof(ActionInfo.State):
                                if (int.TryParse(subsLine[1], out int State))
                                {
                                    actionInfo.State = State;
                                }
                                break;
                            case nameof(ActionInfo.TypeID):
                                if (int.TryParse(subsLine[1], out int TypeID))
                                {
                                    actionInfo.TypeID = TypeID;
                                }
                                break;

                        }
                    }

                }

            }
            return list;
        }

    }
}
