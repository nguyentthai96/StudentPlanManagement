using StudentPlanManagementData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStudentPlanManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer<StudentPlanManagementContext>(new StudentPlanManagementInitializer());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //while(true)
            //{
            //    Application.Run(new FormSchedules.FScheduleRegisterSubject("123", "HK4"));
            //}
            //while (true)
            //{
            //    Application.Run(new FormPlan.FPlanAdd("123"));
            //}
            Application.Run(new FormAccounts.FAccountSignIn());
            
        }
    }
}
