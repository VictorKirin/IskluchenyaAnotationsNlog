using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsklAnotationsNlog
{
    public class Nlog
    {
        private static Logger logirovanie = LogManager.GetCurrentClassLogger();

        public void Launchprogram()
        {
            logirovanie.Info("Запуск программы");
        }

        public void Closeprogram()
        {
            logirovanie.Info("Закрытие программы.");
        }

        public void Numbers()
        {
            logirovanie.Error("Можно использовать только числовые значения!");
        }
    }