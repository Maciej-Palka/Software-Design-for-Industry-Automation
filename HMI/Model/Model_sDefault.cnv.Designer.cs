/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:20 PM
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.pusher = new NxtControl.GuiFramework.Rectangle();
			this.TransArm = new HMI.Main.Graphics.Graphic1();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.wp1 = new NxtControl.GuiFramework.Rectangle();
			this.PosPusher = new System.HMI.Symbols.Base.Execute<float>();
			this.AngleTransUnit = new System.HMI.Symbols.Base.Execute<float>();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.wp1X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp1Y = new System.HMI.Symbols.Base.Execute<float>();
			this.wp2 = new NxtControl.GuiFramework.Rectangle();
			this.wp3 = new NxtControl.GuiFramework.Rectangle();
			this.wp4 = new NxtControl.GuiFramework.Rectangle();
			this.wp5 = new NxtControl.GuiFramework.Rectangle();
			this.wp6 = new NxtControl.GuiFramework.Rectangle();
			this.wp2X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp2Y = new System.HMI.Symbols.Base.Execute<float>();
			this.wp3X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp3Y = new System.HMI.Symbols.Base.Execute<float>();
			this.wp4X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp4Y = new System.HMI.Symbols.Base.Execute<float>();
			this.wp5X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp5Y = new System.HMI.Symbols.Base.Execute<float>();
			this.wp6X = new System.HMI.Symbols.Base.Execute<float>();
			this.wp6Y = new System.HMI.Symbols.Base.Execute<float>();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.mgzEmpty = new System.HMI.Symbols.Base.Led<bool>();
			this.vcmON = new System.HMI.Symbols.Base.Led<bool>();
			this.vacum = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(12)), ((float)(220)), ((float)(150)), ((float)(50)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// pusher
			// 
			this.pusher.Bounds = new NxtControl.Drawing.RectF(((float)(137)), ((float)(236)), ((float)(140)), ((float)(30)));
			this.pusher.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))));
			this.pusher.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.pusher.Name = "pusher";
			// 
			// TransArm
			// 
			this.TransArm.BeginInit();
			this.TransArm.AngleIgnore = false;
			this.TransArm.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 477, 202);
			this.TransArm.Name = "TransArm";
			this.TransArm.EndInit();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(427)), ((float)(186)), ((float)(100)), ((float)(85)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(194)), ((byte)(206)), ((byte)(218))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(165)), ((float)(45)), ((float)(66)), ((float)(188)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(154)), ((byte)(194))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(58)), ((byte)(86)), ((byte)(126))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// wp1
			// 
			this.wp1.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(206)), ((float)(60)), ((float)(30)));
			this.wp1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp1.Name = "wp1";
			// 
			// PosPusher
			// 
			this.PosPusher.BeginInit();
			this.PosPusher.AngleIgnore = false;
			this.PosPusher.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 38, 238);
			this.PosPusher.IsOnlyInput = true;
			this.PosPusher.Name = "PosPusher";
			this.PosPusher.TagName = "PosPusher";
			this.PosPusher.Value = 0F;
			this.PosPusher.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PosPusherValueChanged);
			this.PosPusher.EndInit();
			// 
			// AngleTransUnit
			// 
			this.AngleTransUnit.BeginInit();
			this.AngleTransUnit.AngleIgnore = false;
			this.AngleTransUnit.DesignTransformation = new NxtControl.Drawing.Matrix(0.87, 0, 0, 1, 437, 233);
			this.AngleTransUnit.IsOnlyInput = true;
			this.AngleTransUnit.Name = "AngleTransUnit";
			this.AngleTransUnit.TagName = "AngleTransUnit";
			this.AngleTransUnit.Value = 0F;
			this.AngleTransUnit.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PosTransUnitValueChanged);
			this.AngleTransUnit.EndInit();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(641)), ((float)(196)), ((float)(14)), ((float)(14)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(645)), ((float)(200)), ((float)(6)), ((float)(30)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(637)), ((float)(230)), ((float)(22)), ((float)(6)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(643, 230),
									new NxtControl.Drawing.PointF(637, 236),
									new NxtControl.Drawing.PointF(659, 236),
									new NxtControl.Drawing.PointF(653, 230)});
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(164)), ((float)(234)), ((float)(192)), ((float)(34)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(154)), ((byte)(194))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			this.rectangle5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(106)), ((byte)(150))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// wp1X
			// 
			this.wp1X.BeginInit();
			this.wp1X.AngleIgnore = false;
			this.wp1X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 25, 172);
			this.wp1X.IsOnlyInput = true;
			this.wp1X.Name = "wp1X";
			this.wp1X.TagName = "wp1X";
			this.wp1X.Value = 0F;
			this.wp1X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp1XValueChanged);
			this.wp1X.EndInit();
			// 
			// wp1Y
			// 
			this.wp1Y.BeginInit();
			this.wp1Y.AngleIgnore = false;
			this.wp1Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 27, 194);
			this.wp1Y.IsOnlyInput = true;
			this.wp1Y.Name = "wp1Y";
			this.wp1Y.TagName = "wp1Y";
			this.wp1Y.Value = 0F;
			this.wp1Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp1YValueChanged);
			this.wp1Y.EndInit();
			// 
			// wp2
			// 
			this.wp2.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(175)), ((float)(60)), ((float)(30)));
			this.wp2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp2.Name = "wp2";
			// 
			// wp3
			// 
			this.wp3.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(144)), ((float)(60)), ((float)(30)));
			this.wp3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp3.Name = "wp3";
			// 
			// wp4
			// 
			this.wp4.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(113)), ((float)(60)), ((float)(30)));
			this.wp4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp4.Name = "wp4";
			// 
			// wp5
			// 
			this.wp5.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(82)), ((float)(60)), ((float)(30)));
			this.wp5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp5.Name = "wp5";
			// 
			// wp6
			// 
			this.wp6.Bounds = new NxtControl.Drawing.RectF(((float)(168)), ((float)(51)), ((float)(60)), ((float)(30)));
			this.wp6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.wp6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.wp6.Name = "wp6";
			// 
			// wp2X
			// 
			this.wp2X.BeginInit();
			this.wp2X.AngleIgnore = false;
			this.wp2X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 25, 155);
			this.wp2X.IsOnlyInput = true;
			this.wp2X.Name = "wp2X";
			this.wp2X.TagName = "wp2X";
			this.wp2X.Value = 0F;
			this.wp2X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp2XValueChanged);
			this.wp2X.EndInit();
			// 
			// wp2Y
			// 
			this.wp2Y.BeginInit();
			this.wp2Y.AngleIgnore = false;
			this.wp2Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 23, 137);
			this.wp2Y.IsOnlyInput = true;
			this.wp2Y.Name = "wp2Y";
			this.wp2Y.TagName = "wp2Y";
			this.wp2Y.Value = 0F;
			this.wp2Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp2YValueChanged);
			this.wp2Y.EndInit();
			// 
			// wp3X
			// 
			this.wp3X.BeginInit();
			this.wp3X.AngleIgnore = false;
			this.wp3X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 20, 121);
			this.wp3X.IsOnlyInput = true;
			this.wp3X.Name = "wp3X";
			this.wp3X.TagName = "wp3X";
			this.wp3X.Value = 0F;
			this.wp3X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp3XValueChanged);
			this.wp3X.EndInit();
			// 
			// wp3Y
			// 
			this.wp3Y.BeginInit();
			this.wp3Y.AngleIgnore = false;
			this.wp3Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 25, 104);
			this.wp3Y.IsOnlyInput = true;
			this.wp3Y.Name = "wp3Y";
			this.wp3Y.TagName = "wp3Y";
			this.wp3Y.Value = 0F;
			this.wp3Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp3YValueChanged);
			this.wp3Y.EndInit();
			// 
			// wp4X
			// 
			this.wp4X.BeginInit();
			this.wp4X.AngleIgnore = false;
			this.wp4X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 18, 91);
			this.wp4X.IsOnlyInput = true;
			this.wp4X.Name = "wp4X";
			this.wp4X.TagName = "wp4X";
			this.wp4X.Value = 0F;
			this.wp4X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp4XValueChanged);
			this.wp4X.EndInit();
			// 
			// wp4Y
			// 
			this.wp4Y.BeginInit();
			this.wp4Y.AngleIgnore = false;
			this.wp4Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 18, 76);
			this.wp4Y.IsOnlyInput = true;
			this.wp4Y.Name = "wp4Y";
			this.wp4Y.TagName = "wp4Y";
			this.wp4Y.Value = 0F;
			this.wp4Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp4YValueChanged);
			this.wp4Y.EndInit();
			// 
			// wp5X
			// 
			this.wp5X.BeginInit();
			this.wp5X.AngleIgnore = false;
			this.wp5X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 44, 63);
			this.wp5X.IsOnlyInput = true;
			this.wp5X.Name = "wp5X";
			this.wp5X.TagName = "wp5X";
			this.wp5X.Value = 0F;
			this.wp5X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp5XValueChanged);
			this.wp5X.EndInit();
			// 
			// wp5Y
			// 
			this.wp5Y.BeginInit();
			this.wp5Y.AngleIgnore = false;
			this.wp5Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 44, 49);
			this.wp5Y.IsOnlyInput = true;
			this.wp5Y.Name = "wp5Y";
			this.wp5Y.TagName = "wp5Y";
			this.wp5Y.Value = 0F;
			this.wp5Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp5YValueChanged);
			this.wp5Y.EndInit();
			// 
			// wp6X
			// 
			this.wp6X.BeginInit();
			this.wp6X.AngleIgnore = false;
			this.wp6X.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 14, 33);
			this.wp6X.IsOnlyInput = true;
			this.wp6X.Name = "wp6X";
			this.wp6X.TagName = "wp6X";
			this.wp6X.Value = 0F;
			this.wp6X.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp6XValueChanged);
			this.wp6X.EndInit();
			// 
			// wp6Y
			// 
			this.wp6Y.BeginInit();
			this.wp6Y.AngleIgnore = false;
			this.wp6Y.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 12, 21);
			this.wp6Y.IsOnlyInput = true;
			this.wp6Y.Name = "wp6Y";
			this.wp6Y.TagName = "wp6Y";
			this.wp6Y.Value = 0F;
			this.wp6Y.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Wp6YValueChanged);
			this.wp6Y.EndInit();
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(271)), ((float)(731)), ((float)(39)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(337)), ((float)(251)), ((float)(15)), ((float)(15)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(610)), ((float)(266)), ((float)(120)), ((float)(3)));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// mgzEmpty
			// 
			this.mgzEmpty.BeginInit();
			this.mgzEmpty.AngleIgnore = false;
			this.mgzEmpty.ColorFrame = new NxtControl.Drawing.Color("Black");
			this.mgzEmpty.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 197, 251);
			this.mgzEmpty.Name = "mgzEmpty";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.mgzEmpty.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.mgzEmpty.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.mgzEmpty.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.mgzEmpty.TagName = "mgzEmpty";
			this.mgzEmpty.EndInit();
			// 
			// vcmON
			// 
			this.vcmON.BeginInit();
			this.vcmON.AngleIgnore = false;
			this.vcmON.ColorFrame = new NxtControl.Drawing.Color("Black");
			this.vcmON.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 648, 203);
			this.vcmON.Name = "vcmON";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(255)), ((byte)(0))));
			this.vcmON.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.vcmON.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.vcmON.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vcmON.TagName = "vcmON";
			this.vcmON.EndInit();
			// 
			// vacum
			// 
			this.vacum.BeginInit();
			this.vacum.Name = "vacum";
			this.vacum.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.ellipse1,
									this.rectangle2,
									this.polygon1,
									this.vcmON});
			this.vacum.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.pusher,
									this.rectangle3,
									this.TransArm,
									this.rectangle4,
									this.rectangle1,
									this.wp1,
									this.PosPusher,
									this.AngleTransUnit,
									this.wp1X,
									this.wp1Y,
									this.wp2,
									this.wp3,
									this.wp4,
									this.wp5,
									this.wp6,
									this.wp2X,
									this.wp2Y,
									this.wp3X,
									this.wp3Y,
									this.wp4X,
									this.wp4Y,
									this.wp5X,
									this.wp5Y,
									this.wp6X,
									this.wp6Y,
									this.rectangle6,
									this.rectangle7,
									this.rectangle5,
									this.rectangle9,
									this.mgzEmpty,
									this.vacum});
			this.SymbolSize = new System.Drawing.Size(730, 310);
		}
		private System.HMI.Symbols.Base.Led<bool> vcmON;
		private System.HMI.Symbols.Base.Led<bool> mgzEmpty;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private System.HMI.Symbols.Base.Execute<float> wp6Y;
		private System.HMI.Symbols.Base.Execute<float> wp6X;
		private System.HMI.Symbols.Base.Execute<float> wp5Y;
		private System.HMI.Symbols.Base.Execute<float> wp5X;
		private System.HMI.Symbols.Base.Execute<float> wp4Y;
		private System.HMI.Symbols.Base.Execute<float> wp4X;
		private System.HMI.Symbols.Base.Execute<float> wp3Y;
		private System.HMI.Symbols.Base.Execute<float> wp3X;
		private System.HMI.Symbols.Base.Execute<float> wp2Y;
		private System.HMI.Symbols.Base.Execute<float> wp2X;
		private NxtControl.GuiFramework.Rectangle wp6;
		private NxtControl.GuiFramework.Rectangle wp5;
		private NxtControl.GuiFramework.Rectangle wp4;
		private NxtControl.GuiFramework.Rectangle wp3;
		private NxtControl.GuiFramework.Rectangle wp2;
		private System.HMI.Symbols.Base.Execute<float> wp1Y;
		private System.HMI.Symbols.Base.Execute<float> wp1X;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Group vacum;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private System.HMI.Symbols.Base.Execute<float> AngleTransUnit;
		private HMI.Main.Graphics.Graphic1 TransArm;
		private NxtControl.GuiFramework.Rectangle pusher;
		private System.HMI.Symbols.Base.Execute<float> PosPusher;
		private NxtControl.GuiFramework.Rectangle wp1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
