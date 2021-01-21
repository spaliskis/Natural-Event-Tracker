using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventForm.Properties;
using EventInfoLibrary;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.ShowCenter = false;
        }

 

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 100;
            gmap.Zoom = 5;
            gmap.DragButton = MouseButtons.Left;
            
        }


        GMapOverlay markers = new GMapOverlay("markers");
        private void loadMap(string response, Bitmap file)
        {
            var result = GetData.GetItems(response);
            Console.WriteLine(result);
            
            foreach (var element in result)
            {
                double coordinate1 = Convert.ToDouble(element.coordinate1);
                double coordinate2 = Convert.ToDouble(element.coordinate2);
                PointLatLng point = new PointLatLng(coordinate2, coordinate1);
                Bitmap btmap = new Bitmap(file, 25, 25);
                GMapMarker marker = new GMarkerGoogle(point, btmap);
                marker.ToolTipText = $"Title: {element.title}\nDate: {element.date}\nLatitude: {element.coordinate1}\nLongitude: {element.coordinate2}";
                markers.Markers.Add(marker);
            }
            gmap.Overlays.Add(markers);
        }

        private async void wildfireBtn_Click(object sender, EventArgs e)
        {
            markers.Markers.Clear();
            var response = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/8");
            loadMap(response, Resources.flameIcon);
            hideSubmenu();
        }

        private async void stormsBtn_Click(object sender, EventArgs e)
        {
            markers.Markers.Clear();
            var response = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/10");
            loadMap(response, Resources.stormIcon);
            hideSubmenu();
        }

        private async void volcanoesBtn_Click(object sender, EventArgs e)
        {
            markers.Markers.Clear();
            var response = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/12");
            loadMap(response, Resources.volcanoIcon);
            hideSubmenu();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customizeDesign()
        {
            eventsPanel.Visible = false;
        }

        private void hideSubmenu()
        {
            if(eventsPanel.Visible == true)
            {
                eventsPanel.Visible = false;
            }
        }

        private void showSubmenu(Panel Submenu)
        {
            if(Submenu.Visible == false)
            {
                hideSubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void eventsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(eventsPanel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            EventsBtn.Width = this.Width;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            EventsBtn.Width = splitContainer1.Width;
        }


        private async void allEventsBtn_Click(object sender, EventArgs e)
        {
            var response1 = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/8");
            loadMap(response1, Resources.flameIcon);
            var response2 = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/10");
            loadMap(response2, Resources.stormIcon);
            var response = await GetData.getAPI("https://eonet.sci.gsfc.nasa.gov/api/v2.1/categories/12");
            loadMap(response, Resources.volcanoIcon);
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markers.Markers.Clear();
        }
    }
}
