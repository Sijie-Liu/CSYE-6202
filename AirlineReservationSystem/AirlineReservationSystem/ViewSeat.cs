using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class ViewSeat : Form
    {
        private List<Seat> seatList;
        public ViewSeat(List<Seat> s)
        {
            InitializeComponent();
            seatList = s;

            for (int i = 0; i < seatList.Count; i++)
            {
                this.seatTable.Rows.Add();
                this.seatTable.Rows[i].Cells[0].Value = seatList[i].type;
                this.seatTable.Rows[i].Cells[1].Value = seatList[i].price;
            }
            
            
        }

        private void seatTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
