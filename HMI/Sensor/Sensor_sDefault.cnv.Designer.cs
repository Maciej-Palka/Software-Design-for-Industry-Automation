/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 6:06 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Sensor
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.SensorRear = new System.HMI.Symbols.Base.Led<bool>();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.sensor = new NxtControl.GuiFramework.Group();
			// 
			// SensorRear
			// 
			this.SensorRear.BeginInit();
			this.SensorRear.AngleIgnore = false;
			this.SensorRear.ColorFrame = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SensorRear.DesignTransformation = new NxtControl.Drawing.Matrix(2, 0, 0, 2, 59, 12);
			this.SensorRear.Name = "SensorRear";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.SensorRear.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.SensorRear.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.SensorRear.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.SensorRear.TagName = "SensorRear";
			this.SensorRear.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(7)), ((float)(52)), ((float)(10)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sensor
			// 
			this.sensor.BeginInit();
			this.sensor.Name = "sensor";
			this.sensor.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle1,
									this.SensorRear});
			this.sensor.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.sensor});
			this.SymbolSize = new System.Drawing.Size(441, 333);
		}
		private NxtControl.GuiFramework.Group sensor;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.Led<bool> SensorRear;
		#endregion
	}
}
