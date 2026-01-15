using pr18_elik.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr18_elik.Element
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(TicketsClass Ticket)
        {
            InitializeComponent();

            lPrice.Text = Ticket.Price + " ₽";
            fromTime.Text = Ticket.StartTime.ToString("HH:mm");
            fromDate.Text = Ticket.StartTime.ToString("MM.dd.yyyy");
            from.Text = Ticket.From;

           
            toDate.Text = Ticket.EndTime.ToString("MM.dd.yyyy");
            to.Text = Ticket.To;
            toTime.Text = Ticket.EndTime.ToString("HH:mm");

            TimeSpan WayTime = Ticket.EndTime.Subtract(Ticket.StartTime);
            way.Text = "В пути " + WayTime.ToString("HH: mm");

        }
    }
}
