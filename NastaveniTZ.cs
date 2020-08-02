// Vysoké učení technické v Brně
// Ústav automatizace inženýrských úloh a informatiky
// Ing. Michal Nováček
// michal.novace93@seznam.cz
// +420 723 602 636

#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

using System.Threading;
using System.Threading.Tasks;

#endregion

namespace GGmenu
{
    [Transaction(TransactionMode.Manual)]
    public class NastaveniTZ : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            
            
            // Access current selection
            UserControl1 userControl = new UserControl1(doc);
            userControl.ShowDialog();
            
           /* Window win = new Window();
            win.Content = userControl;
            win.Show();*/
            

          //  TaskDialog.Show("Informace o nástroji Tlakové ztráty", "Nástroj počítá tlakové ztráty na kolenech obdélníkového a kruhového průřezu průřezu, které mají parametr rodiny s názvem STŘEDNÍ POLOMĚR (tento parametr mají defaultní rodiny v Revitu).Tyto hodnoty přičítá k hodnotám tlakových ztrát přímých kusů potrubí, které jsou počítány nativně podle nastavení Revitu. Kolena jsou počítána podle tabelárních hodnot v textovém souboru Koeficienty.txt a také podle vztahů zjištěných numericky. Plug-in počítá také tlakové ztráty přechodových kusů, u kterých je nutný parametr VYPOČÍTANÁ DÉLKA, která je také součástí defaultních rodin potrubí v Revitu");
            return Result.Succeeded;

        }
        
    }
}
