﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeTool
{
  internal static class Program
  {
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new Main());
      //Application.Run(new FormMake());
      Application.Run(new FormTemplate());

    }
  }
}