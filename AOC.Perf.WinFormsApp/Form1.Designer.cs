namespace AOC.Perf.WinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.空客性能表计算 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.BatchCacubutton = new System.Windows.Forms.Button();
            this.Runwayslabel = new System.Windows.Forms.Label();
            this.波音性能表计算 = new System.Windows.Forms.TabPage();
            this.系统设置 = new System.Windows.Forms.TabPage();
            this.BOEINGgroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.AIRBUSgroupBox = new System.Windows.Forms.GroupBox();
            this.GSPathtextBox = new System.Windows.Forms.TextBox();
            this.OutputPathSavebutton = new System.Windows.Forms.Button();
            this.ADBPathtextBox = new System.Windows.Forms.TextBox();
            this.OutputPathChangebutton = new System.Windows.Forms.Button();
            this.ADBPathlabel = new System.Windows.Forms.Label();
            this.OutputPathtextBox = new System.Windows.Forms.TextBox();
            this.OutputPathlabel = new System.Windows.Forms.Label();
            this.ADBPathChangebutton = new System.Windows.Forms.Button();
            this.ADBPathSavebutton = new System.Windows.Forms.Button();
            this.GSPathSavebutton = new System.Windows.Forms.Button();
            this.PEPPathlabel = new System.Windows.Forms.Label();
            this.GSPathChangebutton = new System.Windows.Forms.Button();
            this.PEPPathtextBox = new System.Windows.Forms.TextBox();
            this.PEPPathChangebutton = new System.Windows.Forms.Button();
            this.GSPathlabel = new System.Windows.Forms.Label();
            this.PEPPathSavebutton = new System.Windows.Forms.Button();
            this.RunwaystreeView = new System.Windows.Forms.TreeView();
            this.Aircrafttypelabel = new System.Windows.Forms.Label();
            this.AircrafttypecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.空客性能表计算.SuspendLayout();
            this.系统设置.SuspendLayout();
            this.BOEINGgroupBox.SuspendLayout();
            this.AIRBUSgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.空客性能表计算);
            this.tabControl1.Controls.Add(this.波音性能表计算);
            this.tabControl1.Controls.Add(this.系统设置);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // 空客性能表计算
            // 
            this.空客性能表计算.Controls.Add(this.AircrafttypecheckedListBox);
            this.空客性能表计算.Controls.Add(this.button11);
            this.空客性能表计算.Controls.Add(this.BatchCacubutton);
            this.空客性能表计算.Controls.Add(this.Aircrafttypelabel);
            this.空客性能表计算.Controls.Add(this.RunwaystreeView);
            this.空客性能表计算.Controls.Add(this.Runwayslabel);
            this.空客性能表计算.Location = new System.Drawing.Point(4, 34);
            this.空客性能表计算.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.空客性能表计算.Name = "空客性能表计算";
            this.空客性能表计算.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.空客性能表计算.Size = new System.Drawing.Size(1059, 522);
            this.空客性能表计算.TabIndex = 0;
            this.空客性能表计算.Text = "空客性能表计算";
            this.空客性能表计算.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(596, 452);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 28);
            this.button11.TabIndex = 5;
            this.button11.Text = "查看结果";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // BatchCacubutton
            // 
            this.BatchCacubutton.Location = new System.Drawing.Point(316, 452);
            this.BatchCacubutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BatchCacubutton.Name = "BatchCacubutton";
            this.BatchCacubutton.Size = new System.Drawing.Size(100, 28);
            this.BatchCacubutton.TabIndex = 4;
            this.BatchCacubutton.Text = "批量计算";
            this.BatchCacubutton.UseVisualStyleBackColor = true;
            this.BatchCacubutton.Click += new System.EventHandler(this.BatchCacubutton_Click);
            // 
            // Runwayslabel
            // 
            this.Runwayslabel.AutoSize = true;
            this.Runwayslabel.Location = new System.Drawing.Point(199, 32);
            this.Runwayslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Runwayslabel.Name = "Runwayslabel";
            this.Runwayslabel.Size = new System.Drawing.Size(82, 15);
            this.Runwayslabel.TabIndex = 0;
            this.Runwayslabel.Text = "机场与跑道";
            // 
            // 波音性能表计算
            // 
            this.波音性能表计算.Location = new System.Drawing.Point(4, 34);
            this.波音性能表计算.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.波音性能表计算.Name = "波音性能表计算";
            this.波音性能表计算.Size = new System.Drawing.Size(1059, 522);
            this.波音性能表计算.TabIndex = 2;
            this.波音性能表计算.Text = "波音性能表计算";
            this.波音性能表计算.UseVisualStyleBackColor = true;
            // 
            // 系统设置
            // 
            this.系统设置.Controls.Add(this.BOEINGgroupBox);
            this.系统设置.Controls.Add(this.AIRBUSgroupBox);
            this.系统设置.Location = new System.Drawing.Point(4, 34);
            this.系统设置.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.系统设置.Name = "系统设置";
            this.系统设置.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.系统设置.Size = new System.Drawing.Size(1059, 522);
            this.系统设置.TabIndex = 1;
            this.系统设置.Text = "系统设置";
            this.系统设置.UseVisualStyleBackColor = true;
            // 
            // BOEINGgroupBox
            // 
            this.BOEINGgroupBox.Controls.Add(this.button1);
            this.BOEINGgroupBox.Controls.Add(this.textBox3);
            this.BOEINGgroupBox.Controls.Add(this.button2);
            this.BOEINGgroupBox.Controls.Add(this.label1);
            this.BOEINGgroupBox.Controls.Add(this.textBox4);
            this.BOEINGgroupBox.Controls.Add(this.label3);
            this.BOEINGgroupBox.Controls.Add(this.button5);
            this.BOEINGgroupBox.Controls.Add(this.button6);
            this.BOEINGgroupBox.Controls.Add(this.label4);
            this.BOEINGgroupBox.Controls.Add(this.textBox5);
            this.BOEINGgroupBox.Controls.Add(this.button9);
            this.BOEINGgroupBox.Controls.Add(this.button10);
            this.BOEINGgroupBox.Location = new System.Drawing.Point(50, 270);
            this.BOEINGgroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BOEINGgroupBox.Name = "BOEINGgroupBox";
            this.BOEINGgroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BOEINGgroupBox.Size = new System.Drawing.Size(952, 213);
            this.BOEINGgroupBox.TabIndex = 17;
            this.BOEINGgroupBox.TabStop = false;
            this.BOEINGgroupBox.Text = "BOEING";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 77);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(491, 25);
            this.textBox3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "更改设置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库路径";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 129);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(491, 25);
            this.textBox4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "结果输出路径";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(693, 72);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "更改设置";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(818, 72);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "保存";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "BPS安装路径";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(168, 27);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(491, 25);
            this.textBox5.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(693, 25);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 28);
            this.button9.TabIndex = 6;
            this.button9.Text = "更改设置";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(818, 23);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 28);
            this.button10.TabIndex = 7;
            this.button10.Text = "保存";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // AIRBUSgroupBox
            // 
            this.AIRBUSgroupBox.Controls.Add(this.GSPathtextBox);
            this.AIRBUSgroupBox.Controls.Add(this.OutputPathSavebutton);
            this.AIRBUSgroupBox.Controls.Add(this.ADBPathtextBox);
            this.AIRBUSgroupBox.Controls.Add(this.OutputPathChangebutton);
            this.AIRBUSgroupBox.Controls.Add(this.ADBPathlabel);
            this.AIRBUSgroupBox.Controls.Add(this.OutputPathtextBox);
            this.AIRBUSgroupBox.Controls.Add(this.OutputPathlabel);
            this.AIRBUSgroupBox.Controls.Add(this.ADBPathChangebutton);
            this.AIRBUSgroupBox.Controls.Add(this.ADBPathSavebutton);
            this.AIRBUSgroupBox.Controls.Add(this.GSPathSavebutton);
            this.AIRBUSgroupBox.Controls.Add(this.PEPPathlabel);
            this.AIRBUSgroupBox.Controls.Add(this.GSPathChangebutton);
            this.AIRBUSgroupBox.Controls.Add(this.PEPPathtextBox);
            this.AIRBUSgroupBox.Controls.Add(this.PEPPathChangebutton);
            this.AIRBUSgroupBox.Controls.Add(this.GSPathlabel);
            this.AIRBUSgroupBox.Controls.Add(this.PEPPathSavebutton);
            this.AIRBUSgroupBox.Location = new System.Drawing.Point(50, 20);
            this.AIRBUSgroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AIRBUSgroupBox.Name = "AIRBUSgroupBox";
            this.AIRBUSgroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AIRBUSgroupBox.Size = new System.Drawing.Size(952, 225);
            this.AIRBUSgroupBox.TabIndex = 16;
            this.AIRBUSgroupBox.TabStop = false;
            this.AIRBUSgroupBox.Text = "AIRBUS";
            this.AIRBUSgroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GSPathtextBox
            // 
            this.GSPathtextBox.Location = new System.Drawing.Point(168, 80);
            this.GSPathtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GSPathtextBox.Name = "GSPathtextBox";
            this.GSPathtextBox.Size = new System.Drawing.Size(491, 25);
            this.GSPathtextBox.TabIndex = 9;
            // 
            // OutputPathSavebutton
            // 
            this.OutputPathSavebutton.Location = new System.Drawing.Point(818, 170);
            this.OutputPathSavebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputPathSavebutton.Name = "OutputPathSavebutton";
            this.OutputPathSavebutton.Size = new System.Drawing.Size(100, 28);
            this.OutputPathSavebutton.TabIndex = 15;
            this.OutputPathSavebutton.Text = "保存";
            this.OutputPathSavebutton.UseVisualStyleBackColor = true;
            this.OutputPathSavebutton.Click += new System.EventHandler(this.OutputPathSavebutton_Click);
            // 
            // ADBPathtextBox
            // 
            this.ADBPathtextBox.Location = new System.Drawing.Point(168, 126);
            this.ADBPathtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADBPathtextBox.Name = "ADBPathtextBox";
            this.ADBPathtextBox.Size = new System.Drawing.Size(491, 25);
            this.ADBPathtextBox.TabIndex = 0;
            // 
            // OutputPathChangebutton
            // 
            this.OutputPathChangebutton.Location = new System.Drawing.Point(693, 173);
            this.OutputPathChangebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputPathChangebutton.Name = "OutputPathChangebutton";
            this.OutputPathChangebutton.Size = new System.Drawing.Size(100, 28);
            this.OutputPathChangebutton.TabIndex = 14;
            this.OutputPathChangebutton.Text = "更改设置";
            this.OutputPathChangebutton.UseVisualStyleBackColor = true;
            // 
            // ADBPathlabel
            // 
            this.ADBPathlabel.AutoSize = true;
            this.ADBPathlabel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADBPathlabel.Location = new System.Drawing.Point(38, 126);
            this.ADBPathlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ADBPathlabel.Name = "ADBPathlabel";
            this.ADBPathlabel.Size = new System.Drawing.Size(93, 17);
            this.ADBPathlabel.TabIndex = 1;
            this.ADBPathlabel.Text = "数据库路径";
            // 
            // OutputPathtextBox
            // 
            this.OutputPathtextBox.Location = new System.Drawing.Point(168, 173);
            this.OutputPathtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputPathtextBox.Name = "OutputPathtextBox";
            this.OutputPathtextBox.Size = new System.Drawing.Size(491, 25);
            this.OutputPathtextBox.TabIndex = 13;
            // 
            // OutputPathlabel
            // 
            this.OutputPathlabel.AutoSize = true;
            this.OutputPathlabel.Location = new System.Drawing.Point(36, 173);
            this.OutputPathlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputPathlabel.Name = "OutputPathlabel";
            this.OutputPathlabel.Size = new System.Drawing.Size(97, 15);
            this.OutputPathlabel.TabIndex = 12;
            this.OutputPathlabel.Text = "结果输出路径";
            // 
            // ADBPathChangebutton
            // 
            this.ADBPathChangebutton.Location = new System.Drawing.Point(693, 122);
            this.ADBPathChangebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADBPathChangebutton.Name = "ADBPathChangebutton";
            this.ADBPathChangebutton.Size = new System.Drawing.Size(100, 28);
            this.ADBPathChangebutton.TabIndex = 2;
            this.ADBPathChangebutton.Text = "更改设置";
            this.ADBPathChangebutton.UseVisualStyleBackColor = true;
            this.ADBPathChangebutton.Click += new System.EventHandler(this.ADBPathChangebutton_Click);
            // 
            // ADBPathSavebutton
            // 
            this.ADBPathSavebutton.Location = new System.Drawing.Point(818, 123);
            this.ADBPathSavebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADBPathSavebutton.Name = "ADBPathSavebutton";
            this.ADBPathSavebutton.Size = new System.Drawing.Size(100, 28);
            this.ADBPathSavebutton.TabIndex = 3;
            this.ADBPathSavebutton.Text = "保存";
            this.ADBPathSavebutton.UseVisualStyleBackColor = true;
            this.ADBPathSavebutton.Click += new System.EventHandler(this.ADBPathSavebutton_Click);
            // 
            // GSPathSavebutton
            // 
            this.GSPathSavebutton.Location = new System.Drawing.Point(818, 80);
            this.GSPathSavebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GSPathSavebutton.Name = "GSPathSavebutton";
            this.GSPathSavebutton.Size = new System.Drawing.Size(100, 28);
            this.GSPathSavebutton.TabIndex = 11;
            this.GSPathSavebutton.Text = "保存";
            this.GSPathSavebutton.UseVisualStyleBackColor = true;
            // 
            // PEPPathlabel
            // 
            this.PEPPathlabel.AutoSize = true;
            this.PEPPathlabel.Location = new System.Drawing.Point(40, 32);
            this.PEPPathlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PEPPathlabel.Name = "PEPPathlabel";
            this.PEPPathlabel.Size = new System.Drawing.Size(91, 15);
            this.PEPPathlabel.TabIndex = 4;
            this.PEPPathlabel.Text = "PEP安装路径";
            // 
            // GSPathChangebutton
            // 
            this.GSPathChangebutton.Location = new System.Drawing.Point(693, 80);
            this.GSPathChangebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GSPathChangebutton.Name = "GSPathChangebutton";
            this.GSPathChangebutton.Size = new System.Drawing.Size(100, 28);
            this.GSPathChangebutton.TabIndex = 10;
            this.GSPathChangebutton.Text = "更改设置";
            this.GSPathChangebutton.UseVisualStyleBackColor = true;
            // 
            // PEPPathtextBox
            // 
            this.PEPPathtextBox.Location = new System.Drawing.Point(168, 32);
            this.PEPPathtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PEPPathtextBox.Name = "PEPPathtextBox";
            this.PEPPathtextBox.Size = new System.Drawing.Size(491, 25);
            this.PEPPathtextBox.TabIndex = 5;
            // 
            // PEPPathChangebutton
            // 
            this.PEPPathChangebutton.Location = new System.Drawing.Point(693, 32);
            this.PEPPathChangebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PEPPathChangebutton.Name = "PEPPathChangebutton";
            this.PEPPathChangebutton.Size = new System.Drawing.Size(100, 28);
            this.PEPPathChangebutton.TabIndex = 6;
            this.PEPPathChangebutton.Text = "更改设置";
            this.PEPPathChangebutton.UseVisualStyleBackColor = true;
            this.PEPPathChangebutton.Click += new System.EventHandler(this.PEPPathChangebutton_Click);
            // 
            // GSPathlabel
            // 
            this.GSPathlabel.AutoSize = true;
            this.GSPathlabel.Location = new System.Drawing.Point(48, 80);
            this.GSPathlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GSPathlabel.Name = "GSPathlabel";
            this.GSPathlabel.Size = new System.Drawing.Size(83, 15);
            this.GSPathlabel.TabIndex = 8;
            this.GSPathlabel.Text = "GS安装路径";
            // 
            // PEPPathSavebutton
            // 
            this.PEPPathSavebutton.Location = new System.Drawing.Point(818, 29);
            this.PEPPathSavebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PEPPathSavebutton.Name = "PEPPathSavebutton";
            this.PEPPathSavebutton.Size = new System.Drawing.Size(100, 28);
            this.PEPPathSavebutton.TabIndex = 7;
            this.PEPPathSavebutton.Text = "保存";
            this.PEPPathSavebutton.UseVisualStyleBackColor = true;
            // 
            // RunwaystreeView
            // 
            this.RunwaystreeView.CheckBoxes = true;
            this.RunwaystreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.RunwaystreeView.Location = new System.Drawing.Point(116, 62);
            this.RunwaystreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RunwaystreeView.Name = "RunwaystreeView";
            this.RunwaystreeView.Size = new System.Drawing.Size(299, 344);
            this.RunwaystreeView.TabIndex = 1;
            this.RunwaystreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.RunwaystreeView_AfterCheck);
            this.RunwaystreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.RunwaystreeView_DrawNode);
            // 
            // Aircrafttypelabel
            // 
            this.Aircrafttypelabel.AutoSize = true;
            this.Aircrafttypelabel.Location = new System.Drawing.Point(702, 32);
            this.Aircrafttypelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aircrafttypelabel.Name = "Aircrafttypelabel";
            this.Aircrafttypelabel.Size = new System.Drawing.Size(82, 15);
            this.Aircrafttypelabel.TabIndex = 2;
            this.Aircrafttypelabel.Text = "请选择机型";
            this.Aircrafttypelabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // AircrafttypecheckedListBox
            // 
            this.AircrafttypecheckedListBox.FormattingEnabled = true;
            this.AircrafttypecheckedListBox.Items.AddRange(new object[] {
            "A320-214",
            "A320-214W",
            "A320-232",
            "A320-232W",
            "A320-251W"});
            this.AircrafttypecheckedListBox.Location = new System.Drawing.Point(596, 62);
            this.AircrafttypecheckedListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AircrafttypecheckedListBox.Name = "AircrafttypecheckedListBox";
            this.AircrafttypecheckedListBox.Size = new System.Drawing.Size(299, 324);
            this.AircrafttypecheckedListBox.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainForm";
            this.Text = "性能表计算";
            this.tabControl1.ResumeLayout(false);
            this.空客性能表计算.ResumeLayout(false);
            this.空客性能表计算.PerformLayout();
            this.系统设置.ResumeLayout(false);
            this.BOEINGgroupBox.ResumeLayout(false);
            this.BOEINGgroupBox.PerformLayout();
            this.AIRBUSgroupBox.ResumeLayout(false);
            this.AIRBUSgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 空客性能表计算;
        private System.Windows.Forms.TabPage 系统设置;
        private System.Windows.Forms.TabPage 波音性能表计算;
        private System.Windows.Forms.Button ADBPathChangebutton;
        private System.Windows.Forms.Label ADBPathlabel;
        private System.Windows.Forms.TextBox ADBPathtextBox;
        private System.Windows.Forms.Button ADBPathSavebutton;
        private System.Windows.Forms.GroupBox AIRBUSgroupBox;
        private System.Windows.Forms.Button OutputPathSavebutton;
        private System.Windows.Forms.Button OutputPathChangebutton;
        private System.Windows.Forms.TextBox OutputPathtextBox;
        private System.Windows.Forms.Label OutputPathlabel;
        private System.Windows.Forms.Button PEPPathSavebutton;
        private System.Windows.Forms.Button PEPPathChangebutton;
        private System.Windows.Forms.TextBox PEPPathtextBox;
        private System.Windows.Forms.Label PEPPathlabel;
        private System.Windows.Forms.GroupBox BOEINGgroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button BatchCacubutton;
        private System.Windows.Forms.Label Runwayslabel;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox GSPathtextBox;
        private System.Windows.Forms.Button GSPathSavebutton;
        private System.Windows.Forms.Button GSPathChangebutton;
        private System.Windows.Forms.Label GSPathlabel;
        private System.Windows.Forms.CheckedListBox AircrafttypecheckedListBox;
        private System.Windows.Forms.Label Aircrafttypelabel;
        private System.Windows.Forms.TreeView RunwaystreeView;
    }
}

