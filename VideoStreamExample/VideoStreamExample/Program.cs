using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using AjaxControlToolkit.HtmlEditor.ToolbarButtons;
using Touchless.Vision.Camera;

namespace VideoStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!DesignMode)
            {
                comboBoxCameras.Items.Clear();
                foreach (Camera cam in CameraService.AvailableCameras)
                    comboBoxCameras.Items.Add(cam);

                if (comboBoxCameras.Items.Count > 0)
                    comboBoxCameras.SelectedIndex = 0;
            }
        }
    }
}
