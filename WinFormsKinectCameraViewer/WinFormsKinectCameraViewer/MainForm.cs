using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WinFormsKinectCameraViewer
{
    public partial class MainForm : Form
    {
        KinectSensor kinectSensor = null;
        ColorImageFormat imageFormat = ColorImageFormat.RgbResolution640x480Fps30;

        public MainForm()
        {
            InitializeComponent();

            cmbDisplayMode.Items.Add(ColorImageFormat.RgbResolution640x480Fps30);
            cmbDisplayMode.Items.Add(ColorImageFormat.RgbResolution1280x960Fps12);
            cmbDisplayMode.SelectedIndex = 0;

            PopulateAvailableSensors();
        }

        private void PopulateAvailableSensors()
        {
            cmbSensors.Items.Clear();

            foreach (KinectSensor sensor in KinectSensor.KinectSensors)
            {
                cmbSensors.Items.Add(sensor.UniqueKinectId);
                cmbSensors.SelectedItem = sensor.UniqueKinectId;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateAvailableSensors();
        }

        private void btnActivateSensor_Click(object sender, EventArgs e)
        {
            if (cmbSensors.SelectedIndex != -1)
            {
                DeActivateSensor();

                string sensorID = cmbSensors.SelectedItem.ToString();

                foreach (KinectSensor sensor in KinectSensor.KinectSensors)
                {
                    if (sensor.UniqueKinectId == sensorID)
                    {
                        kinectSensor = sensor;
                        SetupSensorVideoInput();
                    }
                }
            }
        }

        private void SetupSensorVideoInput()
        {
            if (kinectSensor != null)
            {
                imageFormat = (ColorImageFormat)cmbDisplayMode.SelectedItem;
                kinectSensor.ColorStream.Enable(imageFormat);

                kinectSensor.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(kinectSensor_ColorFrameReady);
                kinectSensor.Start();
            }
        }

        private void DeActivateSensor()
        {
            if (kinectSensor != null)
            {
                kinectSensor.Stop();
                kinectSensor.ColorFrameReady -= new EventHandler<ColorImageFrameReadyEventArgs>(kinectSensor_ColorFrameReady);
                kinectSensor.Dispose();
            }
        }

        private void kinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            ColorImageFrame colorFrame = e.OpenColorImageFrame();

            if (colorFrame == null)
            {
                return;
            }

            Bitmap bmpFrame = ColorImageFrameToBitmap(colorFrame);

            picVideoDisplay.Image = bmpFrame;
        }

        private static Bitmap ColorImageFrameToBitmap(ColorImageFrame colorFrame)
        {
            byte[] pixelBuffer = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixelBuffer);

            Bitmap bitmapFrame = new Bitmap(colorFrame.Width, colorFrame.Height, PixelFormat.Format32bppRgb);
            BitmapData bitmapData = bitmapFrame.LockBits(new Rectangle(0, 0, colorFrame.Width, colorFrame.Height), ImageLockMode.WriteOnly, bitmapFrame.PixelFormat);

            IntPtr intPointer = bitmapData.Scan0;
            Marshal.Copy(pixelBuffer, 0, intPointer, colorFrame.PixelDataLength);

            bitmapFrame.UnlockBits(bitmapData);

            return bitmapFrame;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            DeActivateSensor();
        }
    }
}
