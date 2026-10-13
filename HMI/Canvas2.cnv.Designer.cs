/*
 * Created by nxtSTUDIO.
 * User: valeriy
 * Date: 6/6/2017
 * Time: 10:09 AM
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
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HotWaterTankModel = new HMI.Main.Symbols.Model.sDefault();
			this.HotWaterTankModel_1 = new HMI.Main.Symbols.Model.sDefault();
			this.sDefault1 = new HMI.Main.Symbols.TankResis.sDefault();
			this.HotWaterTankModel_2 = new HMI.Main.Symbols.Model.sDefault();
			this.sDefault2 = new HMI.Main.Symbols.TankResis.sDefault();
			this.sDefault3 = new HMI.Main.Symbols.Tank.sDefault();
			this.sDefault4 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault5 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault6 = new HMI.Main.Symbols.Resistance.sDefault();
			this.sDefault7 = new HMI.Main.Symbols.ThermometerS.sDefault();
			this.sDefault8 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault9 = new HMI.Main.Symbols.Sensor.sDefault();
			this.Temp_Control_Slider = new HMI.Main.Symbols.Heat_Control_Slider.sDefault();
			this.watch_trend = new HMI.Main.Symbols.wtch_trend.sDefault();
			// 
			// HotWaterTankModel
			// 
			this.HotWaterTankModel.BeginInit();
			this.HotWaterTankModel.AngleIgnore = false;
			this.HotWaterTankModel.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 239D, 236D);
			this.HotWaterTankModel.Name = "HotWaterTankModel";
			this.HotWaterTankModel.SecurityToken = ((uint)(4294967295u));
			this.HotWaterTankModel.TagName = "257DA29A740268CF";
			this.HotWaterTankModel.EndInit();
			// 
			// HotWaterTankModel_1
			// 
			this.HotWaterTankModel_1.BeginInit();
			this.HotWaterTankModel_1.AngleIgnore = false;
			this.HotWaterTankModel_1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 338D, 247D);
			this.HotWaterTankModel_1.Name = "HotWaterTankModel_1";
			this.HotWaterTankModel_1.SecurityToken = ((uint)(4294967295u));
			this.HotWaterTankModel_1.TagName = "257DA29A740268CF";
			this.HotWaterTankModel_1.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 201D, 202D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "257DA29A740268CF.FB1";
			this.sDefault1.EndInit();
			// 
			// HotWaterTankModel_2
			// 
			this.HotWaterTankModel_2.BeginInit();
			this.HotWaterTankModel_2.AngleIgnore = false;
			this.HotWaterTankModel_2.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 248D, 205D);
			this.HotWaterTankModel_2.Name = "HotWaterTankModel_2";
			this.HotWaterTankModel_2.SecurityToken = ((uint)(4294967295u));
			this.HotWaterTankModel_2.TagName = "257DA29A740268CF";
			this.HotWaterTankModel_2.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.AngleIgnore = false;
			this.sDefault2.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 296D, 259D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "257DA29A740268CF.FB1";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.AngleIgnore = false;
			this.sDefault3.DesignTransformation = new NxtControl.Drawing.Matrix(0.695859872611465D, 0D, 0D, 0.55379188712522043D, 12D, 321D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "257DA29A740268CF.FB1.FB1";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.AngleIgnore = false;
			this.sDefault4.DesignTransformation = new NxtControl.Drawing.Matrix(0.61971830985915488D, 0D, 0D, 1.0416666666666667D, 296D, 475D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "257DA29A740268CF.FB2.lowSensor";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.AngleIgnore = false;
			this.sDefault5.DesignTransformation = new NxtControl.Drawing.Matrix(0.647887323943662D, 0D, 0D, 0.70833333333333337D, 296D, 507D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "257DA29A740268CF.FB2.minSensor";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.AngleIgnore = false;
			this.sDefault6.DesignTransformation = new NxtControl.Drawing.Matrix(0.611764705882353D, 0D, 0D, 0.71276595744680848D, 179.75294117647059D, 517D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "257DA29A740268CF.FB1.FB2";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.AngleIgnore = false;
			this.sDefault7.DesignTransformation = new NxtControl.Drawing.Matrix(0.45238095238095238D, 0D, 0D, 0.71842105263157885D, 84D, 310D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "257DA29A740268CF.FB3";
			this.sDefault7.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.AngleIgnore = false;
			this.sDefault8.DesignTransformation = new NxtControl.Drawing.Matrix(0.74647887323943662D, 0D, 0D, 0.54166666666666663D, 297D, 366D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "257DA29A740268CF.FB2.maxSensor";
			this.sDefault8.EndInit();
			// 
			// sDefault9
			// 
			this.sDefault9.BeginInit();
			this.sDefault9.AngleIgnore = false;
			this.sDefault9.DesignTransformation = new NxtControl.Drawing.Matrix(0.676056338028169D, 0D, 0D, 0.95833333333333337D, 296D, 390D);
			this.sDefault9.Name = "sDefault9";
			this.sDefault9.SecurityToken = ((uint)(4294967295u));
			this.sDefault9.TagName = "257DA29A740268CF.FB2.upSensor";
			this.sDefault9.EndInit();
			// 
			// Temp_Control_Slider
			// 
			this.Temp_Control_Slider.BeginInit();
			this.Temp_Control_Slider.AngleIgnore = false;
			this.Temp_Control_Slider.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 420D, 381D);
			this.Temp_Control_Slider.Name = "Temp_Control_Slider";
			this.Temp_Control_Slider.SecurityToken = ((uint)(4294967295u));
			this.Temp_Control_Slider.TagName = "8185DEAF77E5A0EC";
			this.Temp_Control_Slider.EndInit();
			// 
			// watch_trend
			// 
			this.watch_trend.BeginInit();
			this.watch_trend.AngleIgnore = false;
			this.watch_trend.DesignTransformation = new NxtControl.Drawing.Matrix(0.68445121951219512D, 0D, 0D, 0.741424802110818D, 21D, 21D);
			this.watch_trend.Name = "watch_trend";
			this.watch_trend.SecurityToken = ((uint)(4294967295u));
			this.watch_trend.TagName = "C2C0C1F96A397967";
			this.watch_trend.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(625D)), ((float)(640D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas2";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.HotWaterTankModel,
									this.HotWaterTankModel_1,
									this.sDefault1,
									this.HotWaterTankModel_2,
									this.sDefault2,
									this.sDefault3,
									this.sDefault4,
									this.sDefault5,
									this.sDefault6,
									this.sDefault7,
									this.sDefault8,
									this.sDefault9,
									this.Temp_Control_Slider,
									this.watch_trend});
			this.Size = new System.Drawing.Size(625, 640);
		}
		private HMI.Main.Symbols.wtch_trend.sDefault watch_trend;
		private HMI.Main.Symbols.Heat_Control_Slider.sDefault Temp_Control_Slider;
		private HMI.Main.Symbols.Sensor.sDefault sDefault9;
		private HMI.Main.Symbols.Sensor.sDefault sDefault8;
		private HMI.Main.Symbols.ThermometerS.sDefault sDefault7;
		private HMI.Main.Symbols.Resistance.sDefault sDefault6;
		private HMI.Main.Symbols.Sensor.sDefault sDefault5;
		private HMI.Main.Symbols.Sensor.sDefault sDefault4;
		private HMI.Main.Symbols.Tank.sDefault sDefault3;
		private HMI.Main.Symbols.TankResis.sDefault sDefault2;
		private HMI.Main.Symbols.Model.sDefault HotWaterTankModel_2;
		private HMI.Main.Symbols.TankResis.sDefault sDefault1;
		private HMI.Main.Symbols.Model.sDefault HotWaterTankModel_1;
		private HMI.Main.Symbols.Model.sDefault HotWaterTankModel;
		#endregion
	}
}
