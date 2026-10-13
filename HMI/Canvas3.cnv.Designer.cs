/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 4/6/2020
 * Time: 12:01 PM
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
	/// Summary description for Canvas3.
	/// </summary>
	partial class Canvas3
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new HMI.Main.Symbols.TankResis.sDefault();
			this.sDefault2 = new HMI.Main.Symbols.Tank.sDefault();
			this.sDefault3 = new HMI.Main.Symbols.Resistance.sDefault();
			this.sDefault4 = new HMI.Main.Symbols.ThermometerS.sDefault();
			this.sDefault5 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault6 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault7 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault8 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault9 = new HMI.Main.Symbols.Level_Control_Slider.sDefault();
			this.sDefault10 = new HMI.Main.Symbols.Heat_Control_Slider.sDefault();
			this.sDefault11 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault12 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault13 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault14 = new HMI.Main.Symbols.ButtonM.sDefault();
			this.Trends = new HMI.Main.Symbols.wtch_trend.sDefault();
			this.alarmGrid1 = new NxtControl.GuiFramework.AlarmGrid();
			((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).BeginInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 155D, 241D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "53DEB3203F985707.FB1";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.57006369426751591D, 0D, 0D, 0.49382716049382719D, 1D, 138D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "53DEB3203F985707.FB1.FB1";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49411764705882355D, 0D, 0D, 0.6063829787234043D, 139.2235294117647D, 316D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "53DEB3203F985707.FB1.FB2";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.52976190476190477D, 0D, 0D, 0.518421052631579D, 34.000000000000007D, 174D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "53DEB3203F985707.FB3";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53521126760563376D, 0D, 0D, 0.54166666666666674D, 233D, 178D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "53DEB3203F985707.FB2.maxSensor";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53521126760563376D, 0D, 0D, 0.54166666666666663D, 233D, 304D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "53DEB3203F985707.FB2.minSensor";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53521126760563376D, 0D, 0D, 0.54166666666666663D, 233D, 278D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "53DEB3203F985707.FB2.lowSensor";
			this.sDefault7.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53521126760563376D, 0D, 0D, 0.54166666666666663D, 233D, 203D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "53DEB3203F985707.FB2.upSensor";
			this.sDefault8.EndInit();
			// 
			// sDefault9
			// 
			this.sDefault9.BeginInit();
			this.sDefault9.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66473988439306353D, 0D, 0D, 0.84388185654008441D, 263D, 204D);
			this.sDefault9.Name = "sDefault9";
			this.sDefault9.SecurityToken = ((uint)(4294967295u));
			this.sDefault9.TagName = "812D5AE0F0A3AFF0.Level_Value";
			this.sDefault9.EndInit();
			// 
			// sDefault10
			// 
			this.sDefault10.BeginInit();
			this.sDefault10.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66473988439306353D, 0D, 0D, 0.84388185654008441D, 373D, 204D);
			this.sDefault10.Name = "sDefault10";
			this.sDefault10.SecurityToken = ((uint)(4294967295u));
			this.sDefault10.TagName = "812D5AE0F0A3AFF0.Temp_Value";
			this.sDefault10.EndInit();
			// 
			// sDefault11
			// 
			this.sDefault11.BeginInit();
			this.sDefault11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.631578947368421D, 0D, 0D, 0.71428571428571419D, 640D, 270D);
			this.sDefault11.Name = "sDefault11";
			this.sDefault11.SecurityToken = ((uint)(4294967295u));
			this.sDefault11.TagName = "812D5AE0F0A3AFF0.Recipe1";
			this.sDefault11.EndInit();
			// 
			// sDefault12
			// 
			this.sDefault12.BeginInit();
			this.sDefault12.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63157894736842113D, 0D, 0D, 0.71428571428571441D, 640D, 340D);
			this.sDefault12.Name = "sDefault12";
			this.sDefault12.SecurityToken = ((uint)(4294967295u));
			this.sDefault12.TagName = "812D5AE0F0A3AFF0.Recipe2";
			this.sDefault12.EndInit();
			// 
			// sDefault13
			// 
			this.sDefault13.BeginInit();
			this.sDefault13.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.631578947368421D, 0D, 0D, 0.71428571428571419D, 540D, 270D);
			this.sDefault13.Name = "sDefault13";
			this.sDefault13.SecurityToken = ((uint)(4294967295u));
			this.sDefault13.TagName = "812D5AE0F0A3AFF0.Start_Button";
			this.sDefault13.EndInit();
			// 
			// sDefault14
			// 
			this.sDefault14.BeginInit();
			this.sDefault14.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.631578947368421D, 0D, 0D, 0.7142857142857143D, 540D, 340D);
			this.sDefault14.Name = "sDefault14";
			this.sDefault14.SecurityToken = ((uint)(4294967295u));
			this.sDefault14.TagName = "812D5AE0F0A3AFF0.Stop_Button";
			this.sDefault14.EndInit();
			// 
			// Trends
			// 
			this.Trends.BeginInit();
			this.Trends.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5058448459086079D, 0D, 0D, 0.60158311345646442D, 307D, 8D);
			this.Trends.Name = "Trends";
			this.Trends.SecurityToken = ((uint)(4294967295u));
			this.Trends.TagName = "DFAC90C9C1D7EBFC";
			this.Trends.EndInit();
			// 
			// alarmGrid1
			// 
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Shortcut, true, null, 32));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Ack, true, null, 40));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Origin, true, null, 200));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Text, true, null, 100));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameTime, true, null, 130));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneTime, true, null, 130));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Present, true, null, 48));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.State, true, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Value, true, null, 80));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.InfoValue, true, null, 80));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameAckTime, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneAckTime, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Interval, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameAckUser, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneAckUser, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Path, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Alias, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Time, false, null, 0));
			this.alarmGrid1.AlarmFilter = new NxtControl.GuiFramework.AlarmConfiguration("");
			this.alarmGrid1.AlternatingRowColor = System.Drawing.Color.Empty;
			this.alarmGrid1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.alarmGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.alarmGrid1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alarmGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.alarmGrid1.GridCellBackColor = System.Drawing.SystemColors.Window;
			this.alarmGrid1.HeaderBackColor = System.Drawing.SystemColors.Control;
			this.alarmGrid1.HeaderForeColor = System.Drawing.SystemColors.WindowText;
			this.alarmGrid1.Location = new System.Drawing.Point(-1, 1);
			this.alarmGrid1.Name = "alarmGrid1";
			this.alarmGrid1.SecurityLevel = 3;
			this.alarmGrid1.Size = new System.Drawing.Size(286, 115);
			this.alarmGrid1.Text = "alarmGrid1";
			this.alarmGrid1.ToolBarBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.alarmGrid1.ToolBarForeColor = System.Drawing.SystemColors.ControlText;
			// 
			// Canvas3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(800D)), ((float)(420D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas3";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sDefault2,
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
			this.Trends,
			this.alarmGrid1});
			this.Size = new System.Drawing.Size(800, 420);
			((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).EndInit();

		}
		private HMI.Main.Symbols.wtch_trend.sDefault Trends;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault14;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault13;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault12;
		private HMI.Main.Symbols.ButtonM.sDefault sDefault11;
		private HMI.Main.Symbols.Heat_Control_Slider.sDefault sDefault10;
		private HMI.Main.Symbols.Level_Control_Slider.sDefault sDefault9;
		private HMI.Main.Symbols.Sensor.sDefault sDefault8;
		private HMI.Main.Symbols.Sensor.sDefault sDefault7;
		private HMI.Main.Symbols.Sensor.sDefault sDefault6;
		private HMI.Main.Symbols.Sensor.sDefault sDefault5;
		private HMI.Main.Symbols.ThermometerS.sDefault sDefault4;
		private HMI.Main.Symbols.Resistance.sDefault sDefault3;
		private HMI.Main.Symbols.Tank.sDefault sDefault2;
		private HMI.Main.Symbols.TankResis.sDefault sDefault1;
		private NxtControl.GuiFramework.AlarmGrid alarmGrid1;
		#endregion
	}
}
