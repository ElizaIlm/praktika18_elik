using MySql.Data.MySqlClient;
using pr18_elik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr18_elik.Classes
{
    public class TicketsClass: Ticket
    {
         public TicketsClass(int Price, string From, string To, DateTime StartTime, DateTime EndTime) : base(Price, From, To, StartTime, EndTime) { }
        public static List<TicketsClass> AllTickets()
        {
          
            List<TicketsClass> AllTickets = new List<TicketsClass>();

            

            MySqlConnection connection = WorkingBD.Connection.OpenConnection();
            MySqlDataReader ticketQuery = WorkingBD.Connection.Query("SELECT * FROM `Airlines`.`Tickets`;", connection);
            while(ticketQuery.Read())
            {
                AllTickets.Add(new TicketsClass(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1),
                     ticketQuery.GetString(2),
                     ticketQuery.GetDateTime(4),
                     ticketQuery.GetDateTime(5)
                    ));
            }
            WorkingBD.Connection.CloseConnection(connection);

            return AllTickets;
        }
    }
}
