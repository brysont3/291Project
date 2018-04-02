using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        static int CustID;

        static public int CurrentCumsterID
        {
            get { return CustID; }
            set { CustID = value; }
        }

        static int EmpID;

        static public int CurrentEmployeeID
        {
            get { return EmpID; }
            set { EmpID = value; }
        }
    }
}
