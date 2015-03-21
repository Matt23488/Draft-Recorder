using GsmComm.GsmCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
	public class CommSetting
	{
		public static int Comm_Port = 0;
		public static long Comm_BaudRate = 0;
		public static long Comm_TimeOut = 0;
		public static GsmCommMain comm;
	}
}
