// Vysoké uèení technické v Brnì
// Ústav automatizace inženýrských úloh a informatiky
// Ing. Michal Nováèek
// michal.novace93@seznam.cz
// +420 723 602 636

#region Namespaces
using System;
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using System.Windows.Media.Imaging;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Reflection;
#endregion

namespace RevitAddin1
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            AddRibbonPanel(a);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }

        static void AddRibbonPanel(UIControlledApplication application)
        {
            // VYTVOØENÍ KARTY GGMENU
            String tabName = "GGmenu";
            application.CreateRibbonTab(tabName);


            // VYTVOØENÍ ÈÁSTI NA KARTÌ TLAKOVÉ ZTRÁTY
            RibbonPanel ribbonPanel = application.CreateRibbonPanel(tabName, "Tlakové ztráty");

            // Get dll assembly path
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            // create push button for CurveTotalLength
            PushButtonData b1Data = new PushButtonData(
                "TlakoveZtraty",
                "Tlakové ztráty",
                thisAssemblyPath,
                "GGmenu.TlakoveZtraty");

            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Výpoèet tlakových ztrát obdélníkového VZT potrubí";
            BitmapImage pb1Image = new BitmapImage(new Uri("pack://application:,,,/GGmenu;component/Resources/PressureLoss.png"));
            pb1.LargeImage = pb1Image;


            PushButtonData b1Nastaveni = new PushButtonData(
                "NastaveniTZ",
                "Info",
                thisAssemblyPath,
                "GGmenu.NastaveniTZ");

            PushButton pbNastaveni = ribbonPanel.AddItem(b1Nastaveni) as PushButton;
            pbNastaveni.ToolTip = "Informace k nástroji tlakové ztráty";
            BitmapImage pbNastaveniImage = new BitmapImage(new Uri("pack://application:,,,/GGmenu;component/Resources/Nastaveni32.png"));
            pbNastaveni.LargeImage = pbNastaveniImage;




            //////////////////// VYTVOØENÍ ÈÁSTI NA KARTÌ TLAKOVÉ ZTRÁTY
            RibbonPanel ribbonPanel2 = application.CreateRibbonPanel(tabName, "Katastr");

            
            PushButtonData b2Data = new PushButtonData(
                "KatastrUniqueNazev",
                "Katastr",
                thisAssemblyPath,
                "GGmenu.Katastr");

            PushButton pb2 = ribbonPanel2.AddItem(b2Data) as PushButton;
            pb2.ToolTip = "Select Multiple Lines to Obtain Total Length";
            BitmapImage pb2Image = new BitmapImage(new Uri("pack://application:,,,/GGmenu;component/Resources/Katastr.png"));
            pb2.LargeImage = pb2Image;


        /*   PushButtonData b3Data = new PushButtonData(
                "OslunìníUniqueNazev",
                "Oslunìní",
                thisAssemblyPath,
                "RevitAddin1.Osluneni");

            PushButton pb3 = ribbonPanel.AddItem(b3Data) as PushButton;
            pb3.ToolTip = "Select Multiple Lines to Obtain Total Length";
            BitmapImage pb3Image = new BitmapImage(new Uri("pack://application:,,,/RevitAddin1;component/Resources/osluneni.png"));
            pb3.LargeImage = pb3Image;*/
        }
    }


}
