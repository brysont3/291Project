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
            CustomerID = -1;
            EmployeeID = -1;
            //Application.Run(new Login());
            Application.Run(new Login());


            if (CustomerID > -1)
                Application.Run(new Employee.CustomerMenu());

            if (EmployeeID > -1)
            {
                if (EmployeeType == "Manager")
                {
                    Application.Run(new ManagerMenu());
                }
                else
                {
                    Application.Run(new EmployeeMenu());
                }
            }

        }

        static int CustID;

        static public int CustomerID
        {
            get { return CustID; }
            set { CustID = value; }
        }

        static int EmpID;

        static public int EmployeeID
        {
            get { return EmpID; }
            set { EmpID = value; }
        }
        static string EmpType;

        static public string EmployeeType
        {
            get { return EmpType; }
            set { EmpType = value; }
        }
    }
}
