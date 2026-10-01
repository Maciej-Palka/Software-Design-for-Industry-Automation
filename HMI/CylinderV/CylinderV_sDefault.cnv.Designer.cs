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

namespace HMI.Main.Symbols.CylinderV
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
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.GrpInnerPart = new NxtControl.GuiFramework.Group();
			this.POS = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(40)), ((float)(102)), ((float)(80)), ((float)(20)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(52)), ((float)(122)), ((float)(57)), ((float)(160)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(40)), ((float)(281)), ((float)(80)), ((float)(20)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(75)), ((float)(84)), ((float)(10)), ((float)(196)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(51)), ((float)(74)), ((float)(58)), ((float)(13)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(43)), ((float)(70)), ((float)(91)), ((float)(223)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Blue"), 8F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(43, 70),
									new NxtControl.Drawing.PointF(134, 70),
									new NxtControl.Drawing.PointF(134, 293)});
			// 
			// GrpInnerPart
			// 
			this.GrpInnerPart.BeginInit();
			this.GrpInnerPart.Name = "GrpInnerPart";
			this.GrpInnerPart.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle4,
									this.rectangle5,
									this.polyline1});
			this.GrpInnerPart.EndInit();
			// 
			// POS
			// 
			this.POS.BeginInit();
			this.POS.AngleIgnore = false;
			this.POS.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 37, 332);
			this.POS.IsOnlyInput = true;
			this.POS.Name = "POS";
			this.POS.TagName = "POS";
			this.POS.Value = 0F;
			this.POS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.POSValueChanged);
			this.POS.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.GrpInnerPart,
									this.rectangle1,
									this.rectangle2,
									this.rectangle3,
									this.POS});
			this.SymbolSize = new System.Drawing.Size(405, 457);
		}
		private System.HMI.Symbols.Base.Execute<float> POS;
		private NxtControl.GuiFramework.Group GrpInnerPart;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
