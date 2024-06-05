﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Toolkit_DependencyInjection
{
	class MessageBoxService : IMessageBoxService
	{
		public void Show(string message)
		{
			MessageBox.Show(message);
		}
	}
}
