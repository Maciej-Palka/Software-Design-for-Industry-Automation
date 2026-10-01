/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/28/2016
 * Time: 9:49 PM
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
			this.sensRead = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// sensRead
			// 
			this.sensRead.BeginInit();
			this.sensRead.AngleIgnore = false;
			this.sensRead.ColorFrame = new NxtControl.Drawing.Color("Black");
			this.sensRead.DesignTransformation = new NxtControl.Drawing.Matrix(2, 0, 0, 2, 37, 34.999999999999993);
			this.sensRead.Name = "sensRead";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(255)), ((byte)(0))));
			this.sensRead.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.sensRead.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.sensRead.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.sensRead.Shape = System.HMI.Symbols.Base.LedShape.Rectangle;
			this.sensRead.TagName = "sensRead";
			this.sensRead.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.sensRead});
			this.SymbolSize = new System.Drawing.Size(143, 104);
		}
		private System.HMI.Symbols.Base.Led<bool> sensRead;
		#endregion
	}
}
