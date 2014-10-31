using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.ApplicationServices;
//  using Autodesk.AutoCAD.ApplicationServices.Application;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;


// [assembly: Rtm.CommandClass(typeof(MyClassSerializer.Commands))]

namespace tabl_6_7_SP1813330
{
    

    public class Commands
    {
        
        //Создаю палитру 
        public Autodesk.AutoCAD.Windows.PaletteSet myPaletteSet;
        public UserControl1 myPalette;


        [CommandMethod("tabl67_СП1813330")]
        public void tabl67_СП1813330()
        {
            //Проверяю активно ли сейчас окно палеттсет

            if ((myPaletteSet == null))
            {

                //создаю ссылку на группу палеттов
                myPaletteSet = new PaletteSet("табл 6.7 СП 1813330", new Guid("17E59E2C-35F1-4A80-BE3D-B451D6600A92"));

                //Создаю новый палет
                myPalette = new UserControl1();

                //Добавляю новый палет в группу
                myPaletteSet.Add("табл 6.7 СП 1813330", myPalette);
            }
            //двойная проверка что окно палеттсе действительно показвается
            myPaletteSet.Visible = true;
        }
    }
}
