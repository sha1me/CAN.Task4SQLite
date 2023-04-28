using CAN.Task4SQLite.Model;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;

namespace CAN.Task4SQLite
{
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new UserDataContext());
            facade.EnsureCreated();
        }
    }
}
