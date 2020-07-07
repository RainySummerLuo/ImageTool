using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Size = OpenCvSharp.Size;

namespace ImageTool {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private int zoom;
        private int xOffset;
        private int yOffset;
        private int imageWidth;
        private int imageHeight;
        private Image image_in;
        private Image image_out;
        private InterpolationFlags interpolation;


        private void BtnInput_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog {
                Multiselect = false,
                Title = "Please choose a video file:",
                Filter = "Video File (*.jpg)|*.jpg"
            };
            if (fileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }

            string file = fileDialog.FileName;
            string filename = Path.GetFileName(file);
            string path = Path.GetDirectoryName(file);
            string file_output = Path.Combine(path, "[superresolution]" + filename);

            image_in = Image.FromFile(file);
            picIn.Image = image_in;
            picOut.Image = image_in;

            zoom = 1;
            imageWidth = image_in.Width;
            imageHeight = image_in.Height;

            tbarWidth.Enabled = true;
            tbarHeight.Enabled = true;
        }

        private void PicIn_DoubleClick(object sender, EventArgs e) {
            //if (picIn.SizeMode == PictureBoxSizeMode.Zoom) {
            //    picIn.SizeMode = PictureBoxSizeMode.Normal;
            //    picOut.SizeMode = PictureBoxSizeMode.Normal;
            //} else {
            //    picIn.SizeMode = PictureBoxSizeMode.Zoom;
            //    picOut.SizeMode = PictureBoxSizeMode.Zoom;
            //}
        }

        private void PicIn_MouseWheel(object sender, MouseEventArgs e) {
            //if (image_in == null) {
            //    return;
            //}
            
            //if (e.Delta > 0) {
            //    zoom++;
            //} else if (e.Delta < 0)  {
            //    if (zoom <= 1) {
            //        zoom = 1;
            //    } else {
            //        zoom--;
            //    }
            //}

            //imageWidth = image_in.Width / zoom;
            //imageHeight = image_in.Height / zoom;

            //var widthMax = image_in.Width - imageWidth;
            //if (widthMax < 0) {
            //    widthMax = 0;
            //}
            //tbarWidth.Maximum = widthMax;
            //tbarWidth.Value = 0;
            //tbarWidth.TickFrequency = 1;
            //xOffset = 0;
            //var heightMax = image_in.Height - imageHeight;
            //if (heightMax < 0) {
            //    heightMax = 0;
            //}
            //tbarHeight.Maximum = heightMax;
            //tbarHeight.Value = 0;
            //tbarHeight.TickFrequency = 1;
            //yOffset = 0;
            //PicZoom();
        }

        private void PicIn_Click(object sender, EventArgs e) {
            //picIn.Focus();
        }

        private void PicZoom() {
            Rectangle cropRect = new Rectangle(xOffset, yOffset, imageWidth, imageHeight);
            Bitmap src = image_in as Bitmap;
            var image_temp = src.Clone(cropRect, src.PixelFormat);
            picIn.Image = image_temp;
        }

        private void PicFilter() {
            Mat image_opencv = BitmapConverter.ToMat(new Bitmap(image_in));
            Size dsize = new Size(0, 0);
            int fx = zoom;
            int fy = zoom;
            Mat image_filtered = image_opencv.Resize(dsize, fx, fy, interpolation);
            MemoryStream ms_out = new MemoryStream(image_filtered.ToBytes());
            image_out = Image.FromStream(ms_out);

            Rectangle cropRect = new Rectangle(xOffset * zoom, yOffset * zoom, image_out.Width / zoom, image_out.Height / zoom);
            Bitmap src = image_out as Bitmap;
            var image_temp = src.Clone(cropRect, src.PixelFormat);
            picOut.Image = image_temp;
        }

        private void TbarWidth_Scroll(object sender, EventArgs e) {
            if (image_in != null) {
                xOffset = tbarWidth.Value;
                PicZoom();
                PicFilter();
            }
        }

        private void TbarHeight_Scroll(object sender, EventArgs e) {
            if (image_in != null) {
                yOffset = tbarHeight.Value;
                PicZoom();
                PicFilter();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            cboxInterpolation.SelectedIndex = 4;
            interpolation = InterpolationFlags.Lanczos4;
        }

        private void CboxInterpolation_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cboxInterpolation.SelectedIndex) {
                case 0:
                    interpolation = InterpolationFlags.Nearest;
                    break;
                case 1:
                    interpolation = InterpolationFlags.Linear;
                    break;
                case 2:
                    interpolation = InterpolationFlags.Cubic;
                    break;
                case 3:
                    interpolation = InterpolationFlags.Area;
                    break;
                case 4:
                    interpolation = InterpolationFlags.Lanczos4;
                    break;
                case 5:
                    interpolation = InterpolationFlags.LinearExact;
                    break;
            }
        }

        private void TbarZoom_Scroll(object sender, EventArgs e) {
            lblZoom.Text = tbarZoom.Value + " ×";
            zoom = tbarZoom.Value;

            imageWidth = image_in.Width / zoom;
            imageHeight = image_in.Height / zoom;

            var widthMax = image_in.Width - imageWidth;
            if (widthMax < 0) {
                widthMax = 0;
            }
            tbarWidth.Maximum = widthMax;
            tbarWidth.Value = 0;
            tbarWidth.TickFrequency = 1;
            xOffset = 0;
            var heightMax = image_in.Height - imageHeight;
            if (heightMax < 0) {
                heightMax = 0;
            }
            tbarHeight.Maximum = heightMax;
            tbarHeight.Value = 0;
            tbarHeight.TickFrequency = 1;
            yOffset = 0;
            PicZoom();
            PicFilter();
        }
    }
}
