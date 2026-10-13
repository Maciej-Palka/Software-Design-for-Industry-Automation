/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 3/26/2020
 * Time: 8:13 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas4.
	/// </summary>
	partial class Canvas
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new HMI.Main.Symbols.TankResis.sDefault();
			this.sDefault3 = new HMI.Main.Symbols.Tank.sDefault();
			this.sDefault4 = new HMI.Main.Symbols.Resistance.sDefault();
			this.sDefault5 = new HMI.Main.Symbols.ThermometerS.sDefault();
			this.sDefault6 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault7 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault8 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault9 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault10 = new HMI.Main.Symbols.Level_Control_Slider.sDefault();
			this.sDefault11 = new HMI.Main.Symbols.Heat_Control_Slider.sDefault();
			this.sDefault12 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault13 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault14 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault15 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.Trends = new HMI.Main.Symbols.wtch_trend.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 782D, 365D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "53DEB3203F985707.FB1";
			this.sDefault1.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.AngleIgnore = false;
			this.sDefault3.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, -20D, 292D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "53DEB3203F985707.FB1.FB1";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.AngleIgnore = false;
			this.sDefault4.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 216D, 672D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "53DEB3203F985707.FB1.FB2";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.AngleIgnore = false;
			this.sDefault5.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 29D, 384D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "53DEB3203F985707.FB3";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.AngleIgnore = false;
			this.sDefault6.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 389D, 629D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "53DEB3203F985707.FB2.minSensor";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.AngleIgnore = false;
			this.sDefault7.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 388D, 579D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "53DEB3203F985707.FB2.lowSensor";
			this.sDefault7.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.AngleIgnore = false;
			this.sDefault8.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 388D, 424D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "53DEB3203F985707.FB2.upSensor";
			this.sDefault8.EndInit();
			// 
			// sDefault9
			// 
			this.sDefault9.BeginInit();
			this.sDefault9.AngleIgnore = false;
			this.sDefault9.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 388D, 373D);
			this.sDefault9.Name = "sDefault9";
			this.sDefault9.SecurityToken = ((uint)(4294967295u));
			this.sDefault9.TagName = "53DEB3203F985707.FB2.maxSensor";
			this.sDefault9.EndInit();
			// 
			// sDefault10
			// 
			this.sDefault10.BeginInit();
			this.sDefault10.AngleIgnore = false;
			this.sDefault10.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 515D, 577D);
			this.sDefault10.Name = "sDefault10";
			this.sDefault10.SecurityToken = ((uint)(4294967295u));
			this.sDefault10.TagName = "812D5AE0F0A3AFF0.Level_Value";
			this.sDefault10.EndInit();
			// 
			// sDefault11
			// 
			this.sDefault11.BeginInit();
			this.sDefault11.AngleIgnore = false;
			this.sDefault11.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 703D, 577D);
			this.sDefault11.Name = "sDefault11";
			this.sDefault11.SecurityToken = ((uint)(4294967295u));
			this.sDefault11.TagName = "812D5AE0F0A3AFF0.Temp_Value";
			this.sDefault11.EndInit();
			// 
			// sDefault12
			// 
			this.sDefault12.BeginInit();
			this.sDefault12.AngleIgnore = false;
			this.sDefault12.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 1012D, 456D);
			this.sDefault12.Name = "sDefault12";
			this.sDefault12.SecurityToken = ((uint)(4294967295u));
			this.sDefault12.TagName = "812D5AE0F0A3AFF0.Start_Button";
			this.sDefault12.EndInit();
			// 
			// sDefault13
			// 
			this.sDefault13.BeginInit();
			this.sDefault13.AngleIgnore = false;
			this.sDefault13.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 1017D, 556D);
			this.sDefault13.Name = "sDefault13";
			this.sDefault13.SecurityToken = ((uint)(4294967295u));
			this.sDefault13.TagName = "812D5AE0F0A3AFF0.Recipe1";
			this.sDefault13.EndInit();
			// 
			// sDefault14
			// 
			this.sDefault14.BeginInit();
			this.sDefault14.AngleIgnore = false;
			this.sDefault14.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 1023D, 651D);
			this.sDefault14.Name = "sDefault14";
			this.sDefault14.SecurityToken = ((uint)(4294967295u));
			this.sDefault14.TagName = "812D5AE0F0A3AFF0.Recipe2";
			this.sDefault14.EndInit();
			// 
			// sDefault15
			// 
			this.sDefault15.BeginInit();
			this.sDefault15.AngleIgnore = false;
			this.sDefault15.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 1022D, 743D);
			this.sDefault15.Name = "sDefault15";
			this.sDefault15.SecurityToken = ((uint)(4294967295u));
			this.sDefault15.TagName = "812D5AE0F0A3AFF0.Stop_Button";
			this.sDefault15.EndInit();
			// 
			// Trends
			// 
			this.Trends.BeginInit();
			this.Trends.AngleIgnore = false;
			this.Trends.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 250D, 6D);
			this.Trends.Name = "Trends";
			this.Trends.SecurityToken = ((uint)(4294967295u));
			this.Trends.TagName = "DFAC90C9C1D7EBFC";
			this.Trends.EndInit();
			// 
			// Canvas
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1200D)), ((float)(875D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas4";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.sDefault1,
									this.sDefault3,
									this.sDefault4,
									this.sDefault5,
									this.sDefault6,
									this.sDefault7,
									this.sDefault8,
									this.sDefault9,
									this.sDefault10,
									this.sDefault11,
									this.sDefault12,
									this.sDefault13,
									this.sDefault14,
									this.sDefault15,
									this.Trends});
			this.Size = new System.Drawing.Size(1200, 875);
		}
		private HMI.Main.Symbols.wtch_trend.sDefault Trends;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault15;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault14;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault13;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault12;
		private HMI.Main.Symbols.Heat_Control_Slider.sDefault sDefault11;
		private HMI.Main.Symbols.Level_Control_Slider.sDefault sDefault10;
		private HMI.Main.Symbols.Sensor.sDefault sDefault9;
		private HMI.Main.Symbols.Sensor.sDefault sDefault8;
		private HMI.Main.Symbols.Sensor.sDefault sDefault7;
		private HMI.Main.Symbols.Sensor.sDefault sDefault6;
		private HMI.Main.Symbols.ThermometerS.sDefault sDefault5;
		private HMI.Main.Symbols.Resistance.sDefault sDefault4;
		private HMI.Main.Symbols.Tank.sDefault sDefault3;
		private HMI.Main.Symbols.TankResis.sDefault sDefault1;
		#endregion
	}
}
