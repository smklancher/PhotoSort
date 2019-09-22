using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSort
{
    public partial class PhotoSortForm : Form
    {
        Prototype p;

        public PhotoSortForm()
        {
            InitializeComponent();
            p=new Prototype();
            ReferencePictureBox.Load(p.ReferencePhoto.FilePath);
            TargetChanged();
        }

        private void TargetChanged()
        {
            StatsTextBox.Text = p.Stats();
            TargetPictureBox.Load(p.TargetPhoto.FilePath);
        }

        private void NewReferenceButton_Click(object sender, EventArgs e)
        {
            ReferencePictureBox.Load(p.NewReferencePhoto().FilePath);
        }

        private void OlderButton_Click(object sender, EventArgs e)
        {
            p.ConfirmCurrentRelationship(false);
            TargetChanged();
        }

        private void NewerButton_Click(object sender, EventArgs e)
        {

            p.ConfirmCurrentRelationship(true);
            TargetChanged();
        }

        private void ConfirmDateButton_Click(object sender, EventArgs e)
        {
            p.SetTargetDate(DateTimePicker.Value);
            TargetChanged();
        }

        private void EstimateYearMonthButton_Click(object sender, EventArgs e)
        {

            p.SetTargetDate(DateTimePicker.Value, true);
            TargetChanged();
        }

        private void EstimatedYearButton_Click(object sender, EventArgs e)
        {

            p.SetTargetDate(DateTimePicker.Value, true, true);
            TargetChanged();
        }

        private void PhotoSortForm_Resize(object sender, EventArgs e)
        {
            PhotoContainer.SplitterDistance = Size.Width / 2;
            BottomContainer.SplitterDistance = BottomContainer.Height - 100;
        }
    }
}
