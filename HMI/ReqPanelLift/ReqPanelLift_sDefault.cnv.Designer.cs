/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 12:05 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ReqPanelLift
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
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.led2 = new NxtControl.GuiFramework.Rectangle();
			this.led1 = new NxtControl.GuiFramework.Rectangle();
			this.led0 = new NxtControl.GuiFramework.Rectangle();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.button0 = new NxtControl.GuiFramework.Group();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.button1 = new NxtControl.GuiFramework.Group();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.label3 = new NxtControl.GuiFramework.Label();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.button2 = new NxtControl.GuiFramework.Group();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(30)), ((float)(30)), ((float)(150)), ((float)(220)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 40;
			// 
			// led2
			// 
			this.led2.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(90)), ((float)(103)), ((float)(8)));
			this.led2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.led2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.led2.Name = "led2";
			// 
			// led1
			// 
			this.led1.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(149)), ((float)(103)), ((float)(8)));
			this.led1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.led1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.led1.Name = "led1";
			// 
			// led0
			// 
			this.led0.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(210)), ((float)(103)), ((float)(8)));
			this.led0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.led0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.led0.Name = "led0";
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(64)), ((float)(183)), ((float)(81)), ((float)(25)));
			this.label1.Brush = new NxtControl.Drawing.Brush("White");
			this.label1.Font = new NxtControl.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "FLOOR 0";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label1.TextAutoSizeHorizontalOffset = 12;
			this.label1.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(210)), ((float)(103)), ((float)(8)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(180)), ((float)(111)), ((float)(43)));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// button0
			// 
			this.button0.BeginInit();
			this.button0.Name = "button0";
			this.button0.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle6,
									this.rectangle5,
									this.label1});
			this.button0.MouseLeave += new System.EventHandler(this.Button0MouseLeave);
			this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button0MouseDown);
			this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button0MouseUp);
			this.button0.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(149)), ((float)(103)), ((float)(8)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(64)), ((float)(122)), ((float)(81)), ((float)(25)));
			this.label2.Brush = new NxtControl.Drawing.Brush("White");
			this.label2.Font = new NxtControl.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.Text = "FLOOR 1";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label2.TextAutoSizeHorizontalOffset = 12;
			this.label2.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(119)), ((float)(111)), ((float)(43)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// button1
			// 
			this.button1.BeginInit();
			this.button1.Name = "button1";
			this.button1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle2,
									this.rectangle1,
									this.label2});
			this.button1.MouseLeave += new System.EventHandler(this.Button1MouseLeave);
			this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1MouseDown);
			this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1MouseUp);
			this.button1.EndInit();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(90)), ((float)(103)), ((float)(8)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// label3
			// 
			this.label3.AngleIgnore = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label3.Bounds = new NxtControl.Drawing.RectF(((float)(64)), ((float)(63)), ((float)(81)), ((float)(25)));
			this.label3.Brush = new NxtControl.Drawing.Brush("White");
			this.label3.Font = new NxtControl.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.Name = "label3";
			this.label3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label3.Text = "FLOOR 2";
			this.label3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label3.TextAutoSizeHorizontalOffset = 12;
			this.label3.TextColor = new NxtControl.Drawing.Color("LabelBackColor");
			this.label3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(60)), ((float)(111)), ((float)(43)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// button2
			// 
			this.button2.BeginInit();
			this.button2.Name = "button2";
			this.button2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle4,
									this.rectangle3,
									this.label3});
			this.button2.MouseLeave += new System.EventHandler(this.Button2MouseLeave);
			this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2MouseDown);
			this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2MouseUp);
			this.button2.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.roundedRectangle1,
									this.button0,
									this.led0,
									this.button1,
									this.button2,
									this.led1,
									this.led2});
			this.SymbolSize = new System.Drawing.Size(289, 371);
		}
		private NxtControl.GuiFramework.Label label3;
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.Group button2;
		private NxtControl.GuiFramework.Group button1;
		private NxtControl.GuiFramework.Group button0;
		private NxtControl.GuiFramework.Rectangle led2;
		private NxtControl.GuiFramework.Rectangle led1;
		private NxtControl.GuiFramework.Rectangle led0;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		#endregion
	}
}
