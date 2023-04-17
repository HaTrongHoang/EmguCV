using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCV
{
    public partial class Form1 : Form
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        Rectangle rectangle;
        Point startPoint;
        bool selecting, mouseDown;
        public Form1()
        {
            InitializeComponent();
            InitRoiEnv();
        }

        private void InitRoiEnv()
        {
            rectangle = Rectangle.Empty;
            selecting = false;
            imgList = new Dictionary<string, Image<Bgr, byte>>();
        }
        private void  AddImg(Image<Bgr,byte> img,string key)
        {
            if (!treeView.Nodes.ContainsKey(key))
            {
                TreeNode node = new TreeNode(key);
                node.Name = key;
                treeView.Nodes.Add(node);
                treeView.SelectedNode = node;
            }
            if (!imgList.ContainsKey(key))
            {
                imgList.Add(key, img);
            }
            else
            {
                imgList[key] = img;
            }
        }

        private void btnChonVung_Click(object sender, EventArgs e)
        {
            selecting = true;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                mouseDown = true;
                startPoint = e.Location;
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                int width = Math.Max(startPoint.X, e.X) - Math.Min(startPoint.X, e.X);
                int height = Math.Max(startPoint.Y, e.Y) - Math.Min(startPoint.Y, e.Y);
                Point startLocation = new Point(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y));
                Size size = new Size(width, height);
                rectangle = new Rectangle(startLocation, size);
                Refresh();
            }
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (mouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen,rectangle);
                }
               
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                selecting = false;
                mouseDown = false;
            }
        }

        private void btnAnhChon_Click(object sender, EventArgs e)
        {
            if (pic.Image == null || rectangle == Rectangle.Empty)
            {
                return;
            }
            var img = new Bitmap(pic.Image).ToImage<Bgr, byte>();
            img.ROI = rectangle;
            var imgRoi = img.Copy();
            img.ROI = Rectangle.Empty;
            pic.Image = imgRoi.ToBitmap();
            AddImg(imgRoi, "ROIimg");
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            pic.Image = imgList[e.Node.Text].AsBitmap();
        }
        List<string> lstZone = new List<string>() { "ZONE 8", "ZONE 28","ZONE 49" };
        private void btnTim_Click(object sender, EventArgs e)
        {
            //if(pic.Image==null|| rectangle == Rectangle.Empty)
            //{
            //    return;
            //}
            var imgOrg = imgList["input"].Clone();
            foreach (var item in lstZone)
            {
                string[] fileName = Directory.GetFiles("./" + item + "/", "*.jpg");
                for(int i = 0; i < fileName.Length; i++)
                {
                   
                    var temp = new Bitmap(Image.FromFile(fileName[i])).ToImage<Bgr, byte>();
                    Mat imgOut = new Mat();
                    CvInvoke.MatchTemplate(imgOrg, temp, imgOut, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
                    double minVal = 0.0;
                    double maxVal = 0.0;
                    Point minLoc = new Point();
                    Point maxLoc = new Point();
                    CvInvoke.MinMaxLoc(imgOut, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                    Rectangle rec = new Rectangle(maxLoc, temp.Size);
                    var outI = imgOrg.Copy();
                    CvInvoke.Rectangle(imgOrg, rec, new MCvScalar(0, 0, 255), -1);
                    CvInvoke.AddWeighted(outI, 0.5, imgOrg, 1 - 0.5, 1, outI);
                    imgOrg = outI;
                }
                pic.Image = imgOrg.AsBitmap();
            }
            
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            imgList.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg|*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var inputImg = new Image<Bgr, byte>(openFile.FileName);
                AddImg(inputImg, "input");
                pic.Image = inputImg.AsBitmap();
            }
        }
    }
}
