using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Notifications
    {
        public void SendNotifications(List<string> list)
        {
            //foreach (var item in list)
            //{
            //    Console.WriteLine("Invitation to the PARTY sent - " + item);
            //}

            //    var count = 0;
            //    while (count < list.Count)
            //    {
            //        Console.WriteLine("Invitation to the PARTY sent - " + list[count]);
            //        count++;
            //    }

            //Tratamento de exceções

            try
            {
                foreach (var item in list)
                {
                    var myNumber = Convert.ToInt16(item);
                    if (myNumber > 1)
                        Console.WriteLine("Invitation to the PARTY sent - " + item);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error - Contate o administrador");
            }

        }
    }
