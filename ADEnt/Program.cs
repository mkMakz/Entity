using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ADEnt.Model;

namespace ADEnt
{
    class Program
    {
        private static MCSEntities db = new MCSEntities();

        static void Main(string[] args)
        {
            db.Database.Log = Console.Write;
            //Явная загрузка
            TablesModel model = db.TablesModel.Find(1);

            db.Entry(model).Collection(c => c.TablesSNPrefix).Load();






            return;


            //Lazy load 
            foreach (var tablesModel in db.TablesModel.Take(5))
            {
                Console.WriteLine(tablesModel.strName);
                foreach (var tablesSnPrefix in tablesModel.TablesSNPrefix)
                {
                    Console.WriteLine(" -"+tablesSnPrefix.strPrefix);
                }
            }



            return;


            //Прямая загрузка
            List<newEquipment> equipList = db.newEquipment
                //.Include(d => d.TablesLocation)
                //.Include(d => d.TablesModel)
                //.Include(d => d.TablesModel.TablesSNPrefix)
                .ToList();

            Console.WriteLine("------------------------------------------------");
            foreach (var newEquipment in equipList)
            {
                Console.WriteLine(newEquipment.intGarageRoom);
                foreach (var pref in newEquipment.TablesModel.TablesSNPrefix)
                {
                    //Console.WriteLine("->" + pref.strPrefix);
                }
            }
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
