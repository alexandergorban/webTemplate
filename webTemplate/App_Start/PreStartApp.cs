using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTemplate.App_Start;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(PreStartApp), "Start")]
namespace webTemplate.App_Start
{
    public class PreStartApp
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The method is started once before the start of the application
        /// </summary>
        public static void Start()
        {
            logger.Info("Application PreStart");
        }
    }
}