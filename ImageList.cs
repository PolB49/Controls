using System.Windows.Forms;

namespace Rich_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ImageList();
        }

        private void ImageList()
        {
            imageList1 = new ImageList();
            imageList1.Images.Add("exemple1", new Bitmap("tel.png"));
            imageList1.Images.Add("exemple2", new Bitmap("us.png"));
        }
    }
}
