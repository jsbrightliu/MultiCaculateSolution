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

        //public static string GetAirportString(Airport a)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("               ------------------------------     ");
        //    sb.AppendLine("                        RUNWAY DATA");
        //    sb.AppendLine("               ------------------------------     ");
        //    sb.AppendLine(" RUNWAY TYPE (1=PAVED 2=UNPAVED)         :     1");
        //    sb.AppendLine(" CBR OPTION INDEX                        :     1");
        //    sb.AppendLine(" BRAKING ACTION                          :     1");
        //    sb.AppendLine(" DISPERSE DUST (1=NO 2=YES)              :     1");
        //    sb.AppendLine("*NUMBER OF RUNWAYS                       :     1");
        //    sb.AppendLine("*ALIGMENT ALLOWANCE SELECTION (1=STANDAR :     2");
        //    sb.AppendLine("*ALIGMENT   0 DEGREE (TODA,TORA)         :       0.000");
        //    sb.AppendLine("*ALIGMENT   0 DEGREE (ASDA)              :       0.000");
        //    sb.AppendLine("*ALIGMENT  90 DEGREE (TODA,TORA)         :      11.100");
        //    sb.AppendLine("*ALIGMENT  90 DEGREE (ASDA)              :      22.100");
        //    sb.AppendLine("*ALIGMENT 180 DEGREE (TODA,TORA)         :      15.000");
        //    sb.AppendLine("*ALIGMENT 180 DEGREE (ASDA)              :      26.000");
        //    sb.AppendLine("*ALIGMENT 180PAD     (TODA,TORA)         :      15.000");
        //    sb.AppendLine("*ALIGMENT 180PAD     (ASDA)              :      26.000");
        //    sb.AppendLine("*ALIGMENT 180 OTHER  (TODA,TORA)         :       0.000");
        //    sb.AppendLine("*ALIGMENT 180 OTHER  (ASDA)              :       0.000");
        //    sb.AppendLine(" CURRENT RUNWAY NUMBER                   :     1");
        //    sb.AppendLine("*AIRPORT IDENTIFICATION                  : FUZHOU - CHANGLE                                                                          ");
        //    sb.AppendLine("*RUNWAY IDENTIFICATION                   : 21                                                                                        ");
        //    sb.AppendLine("*ICAO CODE                               : ZSFZ                                                                                      ");
        //    sb.AppendLine("*IATA CODE                               : FOC                                                                                       ");
        //    sb.AppendLine(" RUNWAY QFU                              :                                                                                           ");
        //    sb.AppendLine("*RUNWAY SLOPE                            :      -0.220");
        //    sb.AppendLine(" HEADING                                 :       0.000");
        //    sb.AppendLine(" RUNWAY ALTITUDE TYPE (1=ZP 2=QNH 3=QFE) :     2");
        //    sb.AppendLine(" RUNWAY PRESSURE ALTITUDE                :    1013.250");
        //    sb.AppendLine("*RUNWAY GEOMETRIC ALTITUDE               :      46.916");
        //    sb.AppendLine("*RUNWAY LENGTH REPRESENTATION (1=TODA-AS :     1");
        //    sb.AppendLine("*ASDA OR STOPWAY                         :    3600.000");
        //    sb.AppendLine("*MULTIPLICATION FACTOR ON ASDA           :       1.000");
        //    sb.AppendLine("*INCREMENT VALUE ON ASDA                 :       0.000");
        //    sb.AppendLine(" ALIGNMENT ALLOWANCE FOR ASDA            :       0.000");
        //    sb.AppendLine("*TODA OR CLEARWAY                        :    3600.000");
        //    sb.AppendLine("*AVAILABLE RUNWAY DIST.(TORA)            :    3600.000");
        //    sb.AppendLine(" ALIGNMENT ALLOWANCE FOR TORA AND TODA   :       0.000");
        //    sb.AppendLine("*ENTRY ANGLE                             :     3");
        //    sb.AppendLine(" ENTRY ANGLE (UNUSED)                    :     1");
        //    sb.AppendLine(" LDA                                     :    3600.000");
        //    sb.AppendLine(" ADDITIVE COEFFICIENT ON LDA             :       0.000");
        //    sb.AppendLine(" MULTIPLICATIVE OEFFICIENT ON LDA        :       1.000");
        //    sb.AppendLine(" RUNWAY INFORMATION TYPE (1=RUNWAY CONDI :     1");
        //    sb.AppendLine(" REPORTED BRAKING ACTION (1=DRY 2=GOOD 4 :     1");
        //    sb.AppendLine(" RUNWAY STATE (1=DRY 2=WET 3=WATER_1/4\"  :     1");
        //    sb.AppendLine("*RUNWAY SURFACE (1=SMOOTH 2=GROOVED/PFC) :     1");
        //    sb.AppendLine("*STOPWAY SURFACE (1=SMOOTH 2=GROOVED/PFC :     1");
        //    sb.AppendLine(" RUNWAY TEMPERATURE                      :      26.850");
        //    sb.AppendLine(" REFERENCE FOR OBSTACLE DEFINITION       :     1");
        //    sb.AppendLine("*NUMBER OF OBSTACLES                     :     4");
        //    sb.AppendLine("*OBSTACLE X POSITIONS                    : ");
        //    sb.AppendLine("  18160.000   20263.000   21081.000   22566.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("*OBSTACLE Y POSITIONS                    : ");
        //    sb.AppendLine("    571.000    -644.000    -336.000    -362.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("*OBSTACLE H POSITIONS                    : ");
        //    sb.AppendLine("    902.231    1056.430    1489.501    1676.509       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine(" OBSTACLE SELECTION (1=ALL 2=SPLAY)      :     2");
        //    sb.AppendLine(" FLIGHT PATH SPLAY ANGLE                 :      12.500");
        //    sb.AppendLine(" INITIAL FLIGHT PATH HALFWIDTH           :      90.000");
        //    sb.AppendLine(" FINAL   FLIGHT PATH HALFWIDTH           :     900.000");
        //    sb.AppendLine("*RUNWAY WIDTH                            :      45.000");
        //    sb.AppendLine(" RUNWAY + STAB. SHOULDER WIDTH LT 58M    :     1");
        //    sb.AppendLine("*COMMENT LINE 1 FOR TAKE-OFF             : TAKEOFF BASED ON CLIMBING ON EXTENDED RUNWAY CENTERLINE                                   ");
        //    sb.AppendLine("*COMMENT LINE 2 FOR TAKE-OFF             :                                                                                           ");
        //    sb.AppendLine(" COMMENT LINE 1 FOR LANDING              :                                                                                           ");
        //    sb.AppendLine(" COMMENT LINE 2 FOR LANDING              :                                                                                           ");
        //    sb.AppendLine(" APPROACH GRADIENT (RUNWAY)              :       2.100");
        //    sb.AppendLine(" DELTA ALTITUDE FOR ACG CALCULATION      :       0.000");
        //    sb.AppendLine(" ILS GLIDE (RUNWAY)                      :      -3.000");
        //    sb.AppendLine(" TRANSITION ALTITUDE                     :    5000.000");
        //    sb.AppendLine(" THRUST RED. HEIGHT                      :    1500.000");
        //    sb.AppendLine(" ACC. HEIGHT                             :    1500.000");
        //    sb.AppendLine(" CLIMB SPEED LIMIT (1=NO 2=YES)          :     1");
        //    sb.AppendLine(" INITIAL CLIMB SPEED                     :     250.000");
        //    sb.AppendLine(" SPEED LIMIT ALTITUDE                    :   10000.000");
        //    sb.AppendLine(" FINAL CLIMB SPEED                       :     300.000");
        //    sb.AppendLine(" NUMBER OF TARGET CONSTRAINT             :     0");
        //    sb.AppendLine(" TARGET ALTITUDES                        :     0");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine(" TARGET GRADIENTS                        :     0");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine(" GO-AROUND METHOD (1=PNT 2=AVER 3=OBST)  :     2");
        //    sb.AppendLine(" TARGET ALTITUDE (GO-AROUND)             :    1500.000");
        //    sb.AppendLine(" MIN ACCELERATION HEIGHT (GO-AROUND)     :    1500.000");
        //    sb.AppendLine(" DECISION ALTITUDE (GO-AROUND)           :      46.916");
        //    sb.AppendLine(" SPEED OPTIMIZATION (1=NO 2=KVS 3=ACC)   :     1");
        //    sb.AppendLine(" SPEED OPTIMIZATION VALUE                :       1.230");
        //    sb.AppendLine(" OBSTACLES DEFINITION (1=GO-AR 2=TAKEOFF :     1");
        //    sb.AppendLine(" OBSTACLE REFERENCE (GO-AROUND)          :     1");
        //    sb.AppendLine(" NUMBER OF OBSTACLES (GO-AROUND)         :     0");
        //    sb.AppendLine(" OBSTACLE X POSITIONS (GO-AROUND)        :     0");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine(" OBSTACLE Y POSITIONS (GO-AROUND)        :     0");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine(" OBSTACLE H POSITIONS (GO-AROUND)        :     0");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("      0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000       0.000");
        //    sb.AppendLine("*MIN EO ACC HEIGHT DEFINITION (1:BY CALC :     1");
        //    sb.AppendLine(" MIN EO ACC HEIGHT VALUE (RWY)           :     400.000");
        //    sb.AppendLine("*V2 MIN DEFINITION (1:BY CALC.OPT 2:BY R :     1");
        //    sb.AppendLine(" V2 MIN TYPE (RWY)                       :     1");
        //    sb.AppendLine(" V2 MIN VALUE (RWY)                      :       1.130");
        //    sb.AppendLine("*V2 MAX DEFINITION (1:BY CALC.OPT 2:BY R :     1");
        //    sb.AppendLine(" V2 MAX TYPE (RWY)                       :     1");
        //    sb.AppendLine(" V2 MAX VALUE (RWY)                      :       1.130");
        //    sb.AppendLine("                                                  ");
        //    return sb.ToString();
        //}
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
            List<Airport> apts = GetAirports();
            foreach(var apt in apts)
            {

            }


        }


        private List<Airport> GetAirports()
        {

            List<Airport> apts = new List<Airport>();

                //JsonConverter.JsonDeserialize<List<Airport>>(JsonConverter.JsonSerialize<List<AIRPORT>>());
            foreach (var apt in (new BLL.AIRPORT().GetModelList("ICAOCODE='ZSFZ'")))
            {
                Airport airport = new Airport();
                airport=JsonConverter.JsonDeserialize<Airport>(JsonConverter.JsonSerialize<AIRPORT>(apt));
                airport.CITYNAME = new BLL.CITY().GetModel(apt.CITYCODE).NAME;
                airport.RUNWAYS = GetLogicRunwaysOfAirport(airport);
                apts.Add(airport);
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
