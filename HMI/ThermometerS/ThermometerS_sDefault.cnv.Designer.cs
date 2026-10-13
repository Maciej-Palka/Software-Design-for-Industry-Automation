/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/21/2016
 * Time: 11:18 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ThermometerS
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
			this.label1 = new NxtControl.GuiFramework.Label();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.temperature = new NxtControl.GuiFramework.Rectangle();
			this.level4 = new NxtControl.GuiFramework.Label();
			this.level3 = new NxtControl.GuiFramework.Label();
			this.level2 = new NxtControl.GuiFramework.Label();
			this.level1 = new NxtControl.GuiFramework.Label();
			this.level0 = new NxtControl.GuiFramework.Label();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(67)), ((float)(33)), ((float)(80)), ((float)(380)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(77)), ((float)(43)), ((float)(60)), ((float)(360)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(143)), ((float)(402)), ((float)(50)), ((float)(10)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(25)), ((float)(287)), ((float)(35)), ((float)(16)));
			this.label1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(154)), ((byte)(194))));
			this.label1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label1.Name = "label1";
			this.label1.Text = "Min";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(25)), ((float)(137)), ((float)(35)), ((float)(16)));
			this.label2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(202)), ((byte)(114)), ((byte)(110))));
			this.label2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label2.Name = "label2";
			this.label2.Text = "Max";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// temperature
			// 
			this.temperature.Bounds = new NxtControl.Drawing.RectF(((float)(82)), ((float)(70)), ((float)(10)), ((float)(300)));
			this.temperature.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.temperature.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.temperature.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.temperature.Name = "temperature";
			this.temperature.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// level4
			// 
			this.level4.AngleIgnore = true;
			this.level4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.level4.Bounds = new NxtControl.Drawing.RectF(((float)(94)), ((float)(64)), ((float)(41)), ((float)(17)));
			this.level4.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.level4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.level4.Name = "level4";
			this.level4.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.level4.Text = "100°C";
			this.level4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.level4.TextAutoSizeHorizontalOffset = 10;
			this.level4.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.level4.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// level3
			// 
			this.level3.AngleIgnore = true;
			this.level3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.level3.Bounds = new NxtControl.Drawing.RectF(((float)(95)), ((float)(137)), ((float)(37)), ((float)(16)));
			this.level3.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.level3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.level3.Name = "level3";
			this.level3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.level3.Text = "80°C";
			this.level3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.level3.TextAutoSizeHorizontalOffset = 10;
			this.level3.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.level3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// level2
			// 
			this.level2.AngleIgnore = true;
			this.level2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.level2.Bounds = new NxtControl.Drawing.RectF(((float)(95)), ((float)(212)), ((float)(37)), ((float)(16)));
			this.level2.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.level2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.level2.Name = "level2";
			this.level2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.level2.Text = "60°C";
			this.level2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.level2.TextAutoSizeHorizontalOffset = 10;
			this.level2.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.level2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// level1
			// 
			this.level1.AngleIgnore = true;
			this.level1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.level1.Bounds = new NxtControl.Drawing.RectF(((float)(95)), ((float)(287)), ((float)(37)), ((float)(16)));
			this.level1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.level1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.level1.Name = "level1";
			this.level1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.level1.Text = "40°C";
			this.level1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.level1.TextAutoSizeHorizontalOffset = 10;
			this.level1.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.level1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// level0
			// 
			this.level0.AngleIgnore = true;
			this.level0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.level0.Bounds = new NxtControl.Drawing.RectF(((float)(96)), ((float)(360)), ((float)(37)), ((float)(17)));
			this.level0.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.level0.Font = new NxtControl.Drawing.Font("LabelFont");
			this.level0.Name = "level0";
			this.level0.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.level0.Text = "20°C";
			this.level0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.level0.TextAutoSizeHorizontalOffset = 10;
			this.level0.TextColor = new NxtControl.Drawing.Color("GroupBoxBackColor");
			this.level0.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle3,
									this.rectangle1,
									this.rectangle2,
									this.label1,
									this.label2,
									this.temperature,
									this.level4,
									this.level3,
									this.level2,
									this.level1,
									this.level0});
			this.SymbolSize = new System.Drawing.Size(268, 450);
		}
		private NxtControl.GuiFramework.Rectangle temperature;
		private NxtControl.GuiFramework.Label level0;
		private NxtControl.GuiFramework.Label level1;
		private NxtControl.GuiFramework.Label level2;
		private NxtControl.GuiFramework.Label level3;
		private NxtControl.GuiFramework.Label level4;
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
