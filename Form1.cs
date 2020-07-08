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
        private int xOffset, yOffset;
        private int imageWidth, imageHeight;
        private Image image_in, image_out;
        private InterpolationFlags interpolation;
        private double alpha, beta, gamma;

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
            Rectangle cropRect1 = new Rectangle(xOffset, yOffset, imageWidth, imageHeight);
            Bitmap src1 = image_in as Bitmap;
            picIn.Image = src1.Clone(cropRect1, src1.PixelFormat);

            Mat image_opencv = BitmapConverter.ToMat(new Bitmap(image_in));
            Size dsize = new Size(0, 0);
            int fx = zoom;
            int fy = zoom;
            Mat image_filtered = image_opencv.Resize(dsize, fx, fy, interpolation);

            Mat blur = new Mat();
            Mat image_usm = new Mat();

            Cv2.GaussianBlur(image_filtered, blur, new Size(0, 0), 25);
            Cv2.AddWeighted(image_filtered, alpha, blur, -1 * beta, gamma, image_usm);

            MemoryStream ms_out = new MemoryStream(image_filtered.ToBytes());
            image_out = Image.FromStream(ms_out);

            Rectangle cropRect2 = new Rectangle(xOffset * zoom, yOffset * zoom, image_out.Width / zoom, image_out.Height / zoom);
            Bitmap src2 = image_out as Bitmap;
            picOut.Image = src2.Clone(cropRect2, src2.PixelFormat);
        }

        private void PicMove() {
            Rectangle cropRect1 = new Rectangle(xOffset, yOffset, imageWidth, imageHeight);
            Bitmap src1 = image_in as Bitmap;
            picIn.Image = src1.Clone(cropRect1, src1.PixelFormat);

            Rectangle cropRect2 = new Rectangle(xOffset * zoom, yOffset * zoom, image_out.Width / zoom, image_out.Height / zoom);
            Bitmap src2 = image_out as Bitmap;
            picOut.Image = src2.Clone(cropRect2, src2.PixelFormat);
        }

        private void TbarAlpha_Scroll(object sender, EventArgs e) {
            alpha = tbarAlpha.Value;
            PicZoom();
        }

        private void TbarBeta_Scroll(object sender, EventArgs e) {
            beta = tbarBeta.Value;
            PicZoom();
        }

        private void TbarGamma_Scroll(object sender, EventArgs e) {
            gamma = tbarGamma.Value;
            PicZoom();
        }

        private void TbarWidth_Scroll(object sender, EventArgs e) {
            if (image_in != null) {
                xOffset = tbarWidth.Value;
                PicMove();
            }
        }

        private void TbarHeight_Scroll(object sender, EventArgs e) {
            if (image_in != null) {
                yOffset = tbarHeight.Value;
                PicMove();
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
            if (image_in != null) {
                PicZoom();
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
        }
    }
}
