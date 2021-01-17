using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AOC.Perf.Common;
using AOC.Perf.Model;
using AOC.Perf.WinFormsApp.ViewModel;

namespace AOC.Perf.WinFormsApp
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            AirbusSystemConfigInit();
            AirbusInterfaceInit();

        }

        private void AirbusSystemConfigInit()
        {
            ADBPathtextBox.Text = ConfigureAppConfig.GetConnectionStringsElementValue("AptDBPath").Substring(45);
            PEPPathtextBox.Text = ConfigureAppConfig.GetAppSettingsKeyValue("PEPPath");
            GSPathtextBox.Text = ConfigureAppConfig.GetAppSettingsKeyValue("GSPath");
            OutputPathtextBox.Text = ConfigureAppConfig.GetAppSettingsKeyValue("OutputPath");
        }

        private void AirbusInterfaceInit()
        {
            RunwaystreeViewInit();
        }
        private void RunwaystreeViewInit()
        {

            //List<AIRPORT> airports = new BLL.AIRPORT().GetModelList("");
            //foreach (AIRPORT apt in airports)
            //{
            //    TreeNode nodeapt = new TreeNode();
            //    nodeapt.Tag = apt.AIRPORTCODE;//把自己的id存放在该节点tag对象里
            //    nodeapt.Text = apt.ICAOCODE + "(" + apt.NAME + ")";
            //    RunwaystreeView.Nodes.Add(nodeapt);
            //    List<LOGICRUNWAY> logicrwys = getLogicRunway(apt);
            //    foreach (LOGICRUNWAY logicrwy in logicrwys)
            //    {
            //        TreeNode noderwy = new TreeNode();
            //        noderwy.Tag = logicrwy.QFUCODE;//把自己的id存放在该节点tag对象里
            //        noderwy.Text = "RWY " + logicrwy.DESIGNATION + logicrwy.IDENT;
            //        nodeapt.Nodes.Add(noderwy);

            //    }

            //}


        }


        private List<Airport> GetAirports()
        {
            List<Airport> apts = JsonConverter.JsonDeserialize<List<Airport>>(JsonConverter.JsonSerialize<List<AIRPORT>>(new BLL.AIRPORT().GetModelList("")));
            foreach (var apt in apts)
            {
                apt.RUNWAYS = GetLogicRunwaysOfAirport(apt);
            }
            return apts;

        }

        private List<Runway> GetLogicRunwaysOfAirport(Airport apt)
        {
            List<Runway> runways = new List<Runway>();
            List<RUNWAY> RWYS = new BLL.RUNWAY().GetModelList("AIRPORTCODE=" + apt.AIRPORTCODE);
            foreach (var rwy in RWYS)
            {
                foreach (var rwytoqfu in (new BLL.RUNWAYTOQFUS().GetModelList("RUNWAYCODE=" + rwy.RUNWAYCODE)))
                {
                    Runway logicrwy = new Runway();
                   
                    logicrwy = JsonConverter.JsonDeserialize<Runway>(JsonConverter.JsonSerialize<QFU>(new BLL.QFU().GetModel(rwytoqfu.QFUCODE)));
                    logicrwy.DESIGNATION = new BLL.QFUREFERENCE().GetModel(rwytoqfu.QFUREFCODE).DESIGNATION;
                    RUNWAY rwytemp = new BLL.RUNWAY().GetModel(rwy.RUNWAYCODE);
                    logicrwy.MAGNETICHEADING = rwytemp.MAGNETICHEADING;
                    logicrwy.MAGNETICHEADINGDATE = rwytemp.MAGNETICHEADINGDATE;
                    logicrwy.STRENGTH = rwytemp.STRENGTH;
                    logicrwy.MAXLENGTH = rwytemp.MAXLENGTH;
                    logicrwy.WIDTH = rwytemp.WIDTH;
                    logicrwy.SHOULDER = rwytemp.SHOULDER;
                    logicrwy.OBSTACLES = JsonConverter.JsonDeserialize<List<Obstacle>>(JsonConverter.JsonSerialize<List<OBSTACLES>>(new BLL.OBSTACLES().GetModelList("QFUCODE=" + rwytoqfu.QFUCODE)));
                    runways.Add(logicrwy);
                }
            }
            return runways;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PEPPathChangebutton_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ADBPathChangebutton_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Files(*.mdb)|*.mdb|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                ADBPathtextBox.Text = op.FileName;

            }
            else
            {
                ADBPathtextBox.Text = "";
            }
        }

        private void ADBPathSavebutton_Click(object sender, EventArgs e)
        {
            if (ADBPathtextBox.Text != "" && (ADBPathtextBox.Text.EndsWith("*.mdb")|| ADBPathtextBox.Text.EndsWith("*.mdbx")))
            {
                ConfigureAppConfig.ConnectionStringsSave("AptMgr", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ADBPathtextBox.Text);

            }
            else
            {
                MessageBox.Show("请设置正确的机场数据库路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateChildNodes(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = node.Checked;
                child.ForeColor = Color.Black;
                UpdateChildNodes(child);
            }
        }

        private void UpdateParents(TreeNode node)
        {
            var parent = node.Parent;
            while (parent != null)
            {
                //设置父节点状态
                SetNodeState(parent);
                parent = parent.Parent;
            }
        }
        private void SetNodeState(TreeNode parent)
        {
            if (parent.Nodes.IsAllChecked())
            {
                //子节点全选中        
                parent.Checked = true;
                parent.ForeColor = Color.Black;
            }
            else if(parent.Nodes.IsAllUnChecked())
            {
                //子节点全未选中        
                parent.Checked = false;
                parent.ForeColor = Color.Black;
                //还要判断子节点中是否有半选中状态        
                foreach (TreeNode child in parent.Nodes)
                {
                    if (child.ForeColor == Color.DimGray)
                    {
                        //用蓝色标记半选中状态                
                        parent.ForeColor = Color.DimGray;
                        break;
                    }
                }
            }
            else
            {
                //子节点有的选中有的未选中        
                parent.Checked = false;
                parent.ForeColor = Color.DimGray;
            }
        }
        



        private void RunwaystreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                e.Node.ForeColor = Color.Black;
                //更新子节点状态
                UpdateChildNodes(e.Node);
                //更新父节点状态
                UpdateParents(e.Node);
            }
        }

        private void RunwaystreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Bounds.Location.X <= 0)
            {
                return;
            }
            var treeview = sender as TreeView;
            var brush = Brushes.Black;
            if (e.Node.ForeColor == Color.DimGray)
            {
                var location = e.Node.Bounds.Location;
                location.Offset(-11, 2);
                var size = new Size(9, 9);
                brush = Brushes.DimGray;
                e.Graphics.FillRectangle(brush, new Rectangle(location, size));
            }
            //绘制文本    
            e.Graphics.DrawString(e.Node.Text, treeview.Font, brush, e.Bounds.Left, e.Bounds.Top);  
        }

        private void BatchCacubutton_Click(object sender, EventArgs e)
        {
            //StringBuilder sbapt = new StringBuilder();
            //foreach (TreeNode node in RunwaystreeView.Nodes)
            //{
            //    if (node.Checked == true)
            //        sbapt.Append(node.Tag);

            //}

            //foreach (TreeNode nd in RunwaystreeView.Nodes)
            //{
            //    if (nd.Checked == true)
            //    {
            //        MessageBox.Show(nd.Tag.ToString());
            //    }

            //}
            //MessageBox.Show(sbapt.ToString());
            StringBuilder aptString = new StringBuilder();
            List<AIRPORT> airports = new BLL.AIRPORT().GetModelList("");
            foreach(var apt in airports)
            {
                

                   


            }






        }

        private void OutputPathSavebutton_Click(object sender, EventArgs e)
        {
            if (OutputPathtextBox.Text != "")
            {
                ConfigureAppConfig.AppSettingsSave("OutputPath", OutputPathtextBox.Text);

            }
            else
            {
                MessageBox.Show("请选择工作路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
