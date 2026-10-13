/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/20/2016
 * Time: 4:39 PM
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
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Heat = new HMI.Main.Symbols.ButtonM.sDefault();
			this.InFast = new HMI.Main.Symbols.ButtonM.sDefault();
			this.InSlow = new HMI.Main.Symbols.ButtonM.sDefault();
			this.Out = new HMI.Main.Symbols.ButtonM.sDefault();
			this.sDefault2 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault3 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault4 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault5 = new HMI.Main.Symbols.Sensor.sDefault();
			this.sDefault7 = new HMI.Main.Symbols.ThermometerS.sDefault();
			this.sDefault1 = new HMI.Main.Symbols.Tank.sDefault();
			this.sDefault6 = new HMI.Main.Symbols.Resistance.sDefault();
			// 
			// Heat
			// 
			this.Heat.BeginInit();
			this.Heat.AngleIgnore = false;
			this.Heat.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 519D, 335D);
			this.Heat.Name = "Heat";
			this.Heat.SecurityToken = ((uint)(4294967295u));
			this.Heat.TagName = "2044EFF0479ADBD3";
			this.Heat.EndInit();
			// 
			// InFast
			// 
			this.InFast.BeginInit();
			this.InFast.AngleIgnore = false;
			this.InFast.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 521D, 151D);
			this.InFast.Name = "InFast";
			this.InFast.SecurityToken = ((uint)(4294967295u));
			this.InFast.TagName = "846507FA8D0AFB2E";
			this.InFast.EndInit();
			// 
			// InSlow
			// 
			this.InSlow.BeginInit();
			this.InSlow.AngleIgnore = false;
			this.InSlow.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 521D, 207D);
			this.InSlow.Name = "InSlow";
			this.InSlow.SecurityToken = ((uint)(4294967295u));
			this.InSlow.TagName = "39BC1CE4CF2A00A8";
			this.InSlow.EndInit();
			// 
			// Out
			// 
			this.Out.BeginInit();
			this.Out.AngleIgnore = false;
			this.Out.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 518D, 270D);
			this.Out.Name = "Out";
			this.Out.SecurityToken = ((uint)(4294967295u));
			this.Out.TagName = "F6362E4EE2073827";
			this.Out.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.AngleIgnore = false;
			this.sDefault2.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 405D, 380D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "257DA29A740268CF.FB2.minSensor";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.AngleIgnore = false;
			this.sDefault3.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 405D, 330D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "257DA29A740268CF.FB2.lowSensor";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.AngleIgnore = false;
			this.sDefault4.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 405D, 175D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "257DA29A740268CF.FB2.upSensor";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.AngleIgnore = false;
			this.sDefault5.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 405D, 125D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "257DA29A740268CF.FB2.maxSensor";
			this.sDefault5.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.AngleIgnore = false;
			this.sDefault7.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 48D, 135D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "257DA29A740268CF.FB3";
			this.sDefault7.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 0D, 43D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "257DA29A740268CF.FB1.FB1";
			this.sDefault1.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.AngleIgnore = false;
			this.sDefault6.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 248D, 423D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "257DA29A740268CF.FB1.FB2";
			this.sDefault6.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(697D)), ((float)(717D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.sDefault1,
									this.Heat,
									this.InFast,
									this.InSlow,
									this.Out,
									this.sDefault2,
									this.sDefault3,
									this.sDefault4,
									this.sDefault5,
									this.sDefault7,
									this.sDefault6});
			this.Size = new System.Drawing.Size(697, 717);
		}
		private HMI.Main.Symbols.Resistance.sDefault sDefault6;
		private HMI.Main.Symbols.Tank.sDefault sDefault1;
		private HMI.Main.Symbols.ThermometerS.sDefault sDefault7;
		private HMI.Main.Symbols.Sensor.sDefault sDefault5;
		private HMI.Main.Symbols.Sensor.sDefault sDefault4;
		private HMI.Main.Symbols.Sensor.sDefault sDefault3;
		private HMI.Main.Symbols.Sensor.sDefault sDefault2;
		private HMI.Main.Symbols.ButtonM.sDefault Out;
		private HMI.Main.Symbols.ButtonM.sDefault InSlow;
		private HMI.Main.Symbols.ButtonM.sDefault InFast;
		private HMI.Main.Symbols.ButtonM.sDefault Heat;
		#endregion
	}
}
