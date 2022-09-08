using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class ActionInfo
    {
        private int state;

        public event Action StateChanged;

        public int Position { get; set; }
        public DateTime IncomeDate { get; set; }
        public int PCName { get; set; }
        public int Quantity { get; set; }
        /// <summary>
        /// состояние задачи (1-новая, 2-выполнена, 3-ошибка)
        /// </summary>
        public int State 
        {
            get { return state; }
            set
			{
                if (value != state && state > 0)
				{
                    StateChanged?.Invoke();
				}
                state = value;
			}
        }
        /// <summary>
        /// тип задачи (1-пополнение, 2-выдача)
        /// </summary>
        public int TypeID { get; set; }
    }

}





    

