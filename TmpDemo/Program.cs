﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmpDemo
{
    static class Program
    {
        public static int devNum = 0;
        public static List<DataEntity> dataList;
        public static List<List<DataEntity>> devList = new List<List<DataEntity>>();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
