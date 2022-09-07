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


    
    public void WriteLog(List<ActionInfo> values)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(".\\operator.log", false))
            {
                    //поток тут
                foreach (ActionInfo value in values)
                    {
                        writer.Write($"{nameof(value.Position)}={value.Position};");
                        writer.Write($"{nameof(value.IncomeDate)}={value.IncomeDate};");
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
    }
        public List<ActionInfo> ReadConfig()
        {
            Task.Run(() =>
            {
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

                    string[] subs = line.Split(';');
                    if (subs.Length == 12)
                    {
                        switch (subs[0])
                        {
                            case nameof(Position):
                                if (int.TryParse(subs[1], out int Position1))
                                {
                                    Position = Position1;
                                }
                                break;
                        };
                        switch (subs[2])
                        {
                            case nameof(IncomeDate):
                                if (DateTime.TryParse(subs[3], out DateTime date))
                                {
                                    IncomeDate = date;
                                }
                                break;
                        };
                        switch (subs[4])
                        {
                            case nameof(PCName):
                                if (int.TryParse(subs[5], out int PCName1))
                                {
                                    PCName = PCName1;
                                }
                                break;
                        };
                        switch (subs[6])
                        {
                            case nameof(Quantity):
                                if (int.TryParse(subs[7], out int Quantity1))
                                {
                                    Quantity = Quantity1;
                                }
                                break;
                        };
                        switch (subs[8])
                        {
                            case nameof(State):
                                if (int.TryParse(subs[9], out int State1))
                                {
                                    State = State1;
                                }
                                break;
                        };
                        switch (subs[10])
                        {
                            case nameof(TypeID):
                                if (int.TryParse(subs[11], out int TypeID1))
                                {
                                    TypeID = TypeID1;
                                }
                                break;
                        }

                    }

                }
            });
        }
}
}
