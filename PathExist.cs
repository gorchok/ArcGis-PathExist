using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.ArcCatalog;


namespace PathExist
{
    public class ToolPathExist : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ToolPathExist()
        {
        }

        protected override void OnClick()
        {
            ArcCatalog.Application.CurrentTool = null;
            Form myForm = new MyForm();
            myForm.ShowDialog();
        }

        protected override void OnUpdate()
        {
            Enabled = ArcCatalog.Application != null;
        }
    }
}
