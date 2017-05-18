using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;

namespace PathExist
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK && folderBrowserDialog1.SelectedPath != " ")
            { txtb1.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {

            // Считываю слои из базы и заполняю CheckBoxList
            clb1.Items.Clear();
            IFeatureClass myFeatureClass = null;
            IWorkspaceFactory workspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace workspace = workspaceFactory.OpenFromFile(txtb1.Text, 0);
            IFeatureWorkspace iworkspace = (IFeatureWorkspace)workspace;
            IEnumDataset enumDataset = workspace.get_Datasets(esriDatasetType.esriDTAny);
            enumDataset.Reset();
            List<string> datasets = new List<string>();
            IDataset dataset = null;
            while ((dataset = enumDataset.Next()) != null)
            {

                if (dataset.Type == esriDatasetType.esriDTFeatureClass)
                {
                    clb1.Items.Add(dataset.Name);
                }
                if (dataset.Type == esriDatasetType.esriDTFeatureDataset)
                {
                    datasets.Add(dataset.Name);
                }
                //Проходим по датасетам если они есть

                foreach (string el in datasets)
                {
                    string datasetsroot = txtb1.Text + @"\" + el;
                    IFeatureDataset mydataset = iworkspace.OpenFeatureDataset(el);
                    IEnumDataset enumDataset1 = mydataset.Subsets;
                    IDataset dataset1 = null;
                    while ((dataset1 = enumDataset1.Next()) != null)
                    {
                        clb1.Items.Add(dataset1.Name);
                    }

                }
            }
            // Считываю все поля из всех слоев
            clb2.Items.Clear();
            List<string> bn = new List<string>();
            foreach (object item in clb1.Items)
            {

                myFeatureClass = iworkspace.OpenFeatureClass(item.ToString());
                for (int j = 0; j < myFeatureClass.Fields.FieldCount; j++)
                {
                    bn.Add(myFeatureClass.Fields.get_Field(j).Name);
                }
            }
            string[] bnn = bn.Distinct().ToArray();

            foreach (string f in bnn)
            {
                clb2.Items.Add(f);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            txb2.Text = "";
            foreach (object itemChecked in clb1.CheckedItems)
            {                
                int vsego = 0;
                IWorkspaceFactory workspaceFactory = new FileGDBWorkspaceFactory();
                IWorkspace workspace = workspaceFactory.OpenFromFile(txtb1.Text, 0);
                IFeatureWorkspace iworkspace = (IFeatureWorkspace)workspace;
                IFeatureClass myFeatureClass2 = iworkspace.OpenFeatureClass(itemChecked.ToString());
                txb2.Text += itemChecked.ToString() + ":" + "\n";
                //MessageBox.Show(myFeatureClass2.AliasName);
                foreach (object itemChecked2 in clb2.CheckedItems)
                {
                    int fieldind_obj = myFeatureClass2.Fields.FindField(itemChecked2.ToString());
                    
                    if (fieldind_obj >= 0)
                    {
                        IFeatureCursor myFC = myFeatureClass2.Search(null, true);
                        IFeature curfeature;
                        while ((curfeature = myFC.NextFeature()) != null)
                        {
                            object fieldValue_obj = curfeature.get_Value(fieldind_obj);

                            if ((System.IO.Directory.Exists(fieldValue_obj.ToString()) == false) && (System.IO.File.Exists(fieldValue_obj.ToString()) == false))
                            {
                                txb2.Text += curfeature.OID.ToString() + " " + itemChecked2.ToString() + " не существует файла или папки:" + fieldValue_obj.ToString() + Environment.NewLine;
                                vsego++;
                            }                        

                        }
                    }
                }
                if (vsego == 0)
                {
                    txb2.Text += "Ok";
                }
                else
                {
                    txb2.Text += "Всего ошибок: " + vsego.ToString();
                }
            }
        }
    }
}
