/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/29/2016
 * Time: 12:22 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Model
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
			this.LiftCylinder = new HMI.Main.Symbols.CylinderVSensValve.sDefault();
			this.PushCylinder = new HMI.Main.Symbols.CylinderHSensValve.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.Luggage = new HMI.Main.Symbols.Luggage.sDefault();
			// 
			// LiftCylinder
			// 
			this.LiftCylinder.BeginInit();
			this.LiftCylinder.AngleIgnore = false;
			this.LiftCylinder.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 160D, 357D);
			this.LiftCylinder.Name = "LiftCylinder";
			this.LiftCylinder.SecurityToken = ((uint)(4294967295u));
			this.LiftCylinder.TagName = "LiftCylinder";
			this.LiftCylinder.EndInit();
			// 
			// PushCylinder
			// 
			this.PushCylinder.BeginInit();
			this.PushCylinder.AngleIgnore = false;
			this.PushCylinder.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 275D, 97D);
			this.PushCylinder.Name = "PushCylinder";
			this.PushCylinder.SecurityToken = ((uint)(4294967295u));
			this.PushCylinder.TagName = "PushCylinder";
			this.PushCylinder.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(217D)), ((float)(20D)), ((float)(381D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(-4D, 210D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 16F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(160D, 210D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(260D, 361D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 16F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(594D, 361D);
			// 
			// Luggage
			// 
			this.Luggage.BeginInit();
			this.Luggage.AngleIgnore = false;
			this.Luggage.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 595D, 322D);
			this.Luggage.Name = "Luggage";
			this.Luggage.SecurityToken = ((uint)(4294967295u));
			this.Luggage.TagName = "Luggage";
			this.Luggage.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.LiftCylinder,
									this.PushCylinder,
									this.rectangle1,
									this.line1,
									this.line2,
									this.Luggage});
			this.SymbolSize = new System.Drawing.Size(676, 600);
		}
		private HMI.Main.Symbols.Luggage.sDefault Luggage;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private HMI.Main.Symbols.CylinderHSensValve.sDefault PushCylinder;
		private HMI.Main.Symbols.CylinderVSensValve.sDefault LiftCylinder;
		#endregion
	}
}
