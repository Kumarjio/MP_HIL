using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.HIL;
using System.IO;

namespace MissionPlanner
{
    public partial class Simudataform: Form
    {
		public static float test_lat;              //自定义Home经纬度、高度
		public static float test_lon;
		public static float test_alt;

		public static float test_wind_speed;     //自定义风速、风向、风的扰动
		public static float test_wind_direction;
		public static float test_wind_turbulance;

		public static float test_frame_mass;     //自定义机身高度、重量
		public static float test_frame_height;


		public Simudataform()
        {
            InitializeComponent();
			
        }

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				test_lat = float.Parse(textBox3.Text);   //获取自定义Home值
				test_lon = float.Parse(textBox4.Text);
				test_alt = float.Parse(textBox5.Text);

				test_wind_speed = float.Parse(textBox1.Text);   //获取自定义风值
				test_wind_direction = float.Parse(textBox2.Text);
				test_wind_turbulance = float.Parse(textBox6.Text);

				test_frame_mass = float.Parse(textBox7.Text);   //获取机身数据
				test_frame_height = float.Parse(textBox8.Text);

				XPlane XPlane = new XPlane();
				Hil.sitl_fdm sitl = new Hil.sitl_fdm();
				XPlane.SendToAP(sitl);

				//写入TXT文件
				string data1 = this.textBox3.Text;
				string data2 = this.textBox4.Text;
				string data3 = this.textBox5.Text;
				string data4 = this.textBox1.Text;
				string data5 = this.textBox2.Text;
				string data6 = this.textBox6.Text;
				string data7 = this.textBox7.Text;
				string data8 = this.textBox8.Text;
				string data9 = this.textBox9.Text;

				StreamWriter sw = new StreamWriter("test.txt");  //写入到bin目录下的test.txt文件
				sw.WriteLine(data1 + "\r\n" + data2 + "\r\n" + data3 + "\r\n" + data4 + "\r\n" + data5 + "\r\n" + data6 + "\r\n" + data7 + "\r\n" + data8 + "\r\n" + data9);
				sw.Close();

			}
			catch
			{
				

				MessageBox.Show("数据格式错误！");
			}



		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox9.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	
	}
}
