using GsmComm.GsmCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMS
{
	public class ServerMain
	{
		public ServerMain()
		{
			
		}

		public bool TestConnection()
		{
			GsmCommMain comm = new GsmCommMain(GsmCommMain.DefaultPortName, 9600, GsmCommMain.DefaultTimeout);
			try
			{
				comm.Open();
				int i = 0;
				while (!comm.IsConnected())
				{
					i++;
					if (i == 5) return false;
					Thread.Sleep(5000);
				}

				comm.Close();
			}
			catch
			{
				throw;
			}

			return true;
		}
	}
}
