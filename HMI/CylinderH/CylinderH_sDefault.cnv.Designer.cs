/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/25/2016
 * Time: 10:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderH
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle14 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle12 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle13 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle15 = new NxtControl.GuiFramework.Rectangle();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.POS = new System.HMI.Symbols.Base.Execute<float>();
			this.GrpInnerPart = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(105)), ((float)(29)), ((float)(20)), ((float)(80)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(125)), ((float)(40)), ((float)(170)), ((float)(57)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle4.FillDirection = NxtControl.Drawing.FillDirection.RightToLeft;
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(292)), ((float)(29)), ((float)(20)), ((float)(80)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle14
			// 
			this.rectangle14.Bounds = new NxtControl.Drawing.RectF(((float)(80)), ((float)(57)), ((float)(25)), ((float)(25)));
			this.rectangle14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle14.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle14.Name = "rectangle14";
			// 
			// rectangle12
			// 
			this.rectangle12.Bounds = new NxtControl.Drawing.RectF(((float)(253)), ((float)(43)), ((float)(10)), ((float)(50)));
			this.rectangle12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle12.Name = "rectangle12";
			// 
			// rectangle13
			// 
			this.rectangle13.Bounds = new NxtControl.Drawing.RectF(((float)(64)), ((float)(64)), ((float)(226)), ((float)(10)));
			this.rectangle13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle13.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle13.Name = "rectangle13";
			// 
			// rectangle15
			// 
			this.rectangle15.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(39)), ((float)(10)), ((float)(60)));
			this.rectangle15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle15.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle15.Name = "rectangle15";
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(34)), ((float)(212)), ((float)(84)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Blue"), 8F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(50, 34),
									new NxtControl.Drawing.PointF(50, 118),
									new NxtControl.Drawing.PointF(262, 118)});
			// 
			// POS
			// 
			this.POS.BeginInit();
			this.POS.AngleIgnore = false;
			this.POS.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 120, 139);
			this.POS.IsOnlyInput = true;
			this.POS.Name = "POS";
			this.POS.TagName = "POS";
			this.POS.Value = 0F;
			this.POS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.POSValueChanged);
			this.POS.EndInit();
			// 
			// GrpInnerPart
			// 
			this.GrpInnerPart.BeginInit();
			this.GrpInnerPart.Name = "GrpInnerPart";
			this.GrpInnerPart.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle12,
									this.rectangle13,
									this.rectangle15,
									this.polyline1});
			this.GrpInnerPart.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.GrpInnerPart,
									this.POS,
									this.rectangle4,
									this.rectangle1,
									this.rectangle14,
									this.rectangle5});
			this.SymbolSize = new System.Drawing.Size(377, 176);
		}
		private NxtControl.GuiFramework.Group GrpInnerPart;
		private System.HMI.Symbols.Base.Execute<float> POS;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Rectangle rectangle15;
		private NxtControl.GuiFramework.Rectangle rectangle13;
		private NxtControl.GuiFramework.Rectangle rectangle12;
		private NxtControl.GuiFramework.Rectangle rectangle14;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
