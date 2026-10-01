/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/28/2016
 * Time: 9:30 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderHSens
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
			this.FB1 = new HMI.Main.Symbols.CylinderH.sDefault();
			this.LeftSensor = new HMI.Main.Symbols.Sensor.sDefault();
			this.RightSensor = new HMI.Main.Symbols.Sensor.sDefault();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 42, 34);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "FB1";
			this.FB1.EndInit();
			// 
			// LeftSensor
			// 
			this.LeftSensor.BeginInit();
			this.LeftSensor.AngleIgnore = false;
			this.LeftSensor.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 117, 24);
			this.LeftSensor.Name = "LeftSensor";
			this.LeftSensor.SecurityToken = ((uint)(4294967295u));
			this.LeftSensor.TagName = "LeftSensor";
			this.LeftSensor.EndInit();
			// 
			// RightSensor
			// 
			this.RightSensor.BeginInit();
			this.RightSensor.AngleIgnore = false;
			this.RightSensor.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 263, 23);
			this.RightSensor.Name = "RightSensor";
			this.RightSensor.SecurityToken = ((uint)(4294967295u));
			this.RightSensor.TagName = "RightSensor";
			this.RightSensor.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.FB1,
									this.LeftSensor,
									this.RightSensor});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private HMI.Main.Symbols.Sensor.sDefault RightSensor;
		private HMI.Main.Symbols.Sensor.sDefault LeftSensor;
		private HMI.Main.Symbols.CylinderH.sDefault FB1;
		#endregion
	}
}
