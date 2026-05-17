using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public partial class ReservationForm : Form
    {
        private IMongoCollection<Reservation> collection = MongoDBHelper.GetCollection<Reservation>("Reservations");

        public ReservationForm()
        {
            InitializeComponent();
            LoadReservations();
        }

        private void LoadReservations()
        {
            var list = collection.Find(Builders<Reservation>.Filter.Empty).ToList();
            dgvReservations.DataSource = list;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                UserId = txtUserId.Text.Trim(),
                TableNumber = (int)nudTable.Value,
                ReservationDate = dtpDate.Value,
                NumberOfPeople = (int)nudPeople.Value
            };

            collection.InsertOne(reservation);
            MessageBox.Show($"Table {reservation.TableNumber} reserved for {reservation.NumberOfPeople} people!\nID: {reservation.ReservationId}");
            LoadReservations();
            ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null) return;
            var selected = (Reservation)dgvReservations.CurrentRow.DataBoundItem;
            collection.DeleteOne(Builders<Reservation>.Filter.Eq(r => r.ReservationId, selected.ReservationId));
            MessageBox.Show("Reservation cancelled.");
            LoadReservations();
        }

        private void ClearFields()
        {
            txtUserId.Text = "";
            nudTable.Value = 1;
            nudPeople.Value = 1;
            dtpDate.Value = DateTime.Now;
        }
    }
}
