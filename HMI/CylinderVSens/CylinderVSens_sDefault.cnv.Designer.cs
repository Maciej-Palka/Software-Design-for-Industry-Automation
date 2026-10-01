/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/28/2016
 * Time: 9:55 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderVSens
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
			this.FB1 = new HMI.Main.Symbols.CylinderV.sDefault();
			this.EndSensor = new HMI.Main.Symbols.Sensor.sDefault();
			this.StartSensor = new HMI.Main.Symbols.Sensor.sDefault();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 29, 60);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "FB1";
			this.FB1.EndInit();
			// 
			// EndSensor
			// 
			this.EndSensor.BeginInit();
			this.EndSensor.AngleIgnore = false;
			this.EndSensor.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 98, 113);
			this.EndSensor.Name = "EndSensor";
			this.EndSensor.SecurityToken = ((uint)(4294967295u));
			this.EndSensor.TagName = "EndSensor";
			this.EndSensor.EndInit();
			// 
			// StartSensor
			// 
			this.StartSensor.BeginInit();
			this.StartSensor.AngleIgnore = false;
			this.StartSensor.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 98, 249);
			this.StartSensor.Name = "StartSensor";
			this.StartSensor.SecurityToken = ((uint)(4294967295u));
			this.StartSensor.TagName = "StartSensor";
			this.StartSensor.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.FB1,
									this.EndSensor,
									this.StartSensor});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private HMI.Main.Symbols.Sensor.sDefault StartSensor;
		private HMI.Main.Symbols.Sensor.sDefault EndSensor;
		private HMI.Main.Symbols.CylinderV.sDefault FB1;
		#endregion
	}
}
