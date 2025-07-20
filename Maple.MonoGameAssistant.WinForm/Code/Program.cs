
using DevExpress.LookAndFeel;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Data;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using Maple.MonoGameAssistant.WinForm.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            WindowsFormsSettings.ForceDirectXPaint();
            UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Darkness);


            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException; ;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; ;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
            Application.Run(ConfigService());
            //   Application.Exit
        }

        private static void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            e.SetObserved();
            XtraMessageBox.Show(e.Exception.Message);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            XtraMessageBox.Show(e.Exception.Message);
        }

        static ViewMainForm ConfigService()
        {
            ServiceCollection services = new();
            services.AddLogging(p => p.AddOnlyMonoGameLogger());
            services.AddGameContextService();

            services.AddSingleton<ViewMainForm>();
            services.AddTransient<ViewHomeTab>();
            services.AddTransient<ViewGameTab>();

            services.AddTransient<PageCodeEditor>();
            services.AddTransient<PageClassDetail>();
            services.AddTransient<PageSpecialClasses>();
            services.AddTransient<PageSaveProgress>();
            services.AddTransient<PageOrgClasses>();

            services.AddSingleton<UIService>();

            var serviceProvider = services.BuildServiceProvider();
            var main = serviceProvider.GetRequiredService<ViewMainForm>();

            return main;
        }
    }
}
