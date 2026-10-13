/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 10:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Heat_Control_Slider
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.Heat_Value = new System.HMI.Symbols.Base.TrackerVertical<float>();
			this.Label = new System.HMI.Symbols.Base.Label();
			this.freeText_11 = new System.HMI.Symbols.Base.FreeText<float>();
			// 
			// Heat_Value
			// 
			this.Heat_Value.BeginInit();
			this.Heat_Value.AngleIgnore = false;
			this.Heat_Value.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.Heat_Value.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 0.68333333333333324D, 104D, 42D);
			this.Heat_Value.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.Heat_Value.Maximum = 80F;
			this.Heat_Value.MaximumTag = null;
			this.Heat_Value.Minimum = 40F;
			this.Heat_Value.MinimumTag = null;
			this.Heat_Value.MouseMoveValueThreshold = 0D;
			this.Heat_Value.Name = "Heat_Value";
			this.Heat_Value.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.Heat_Value.Radius = 20D;
			this.Heat_Value.TagName = "Heat_Value";
			this.Heat_Value.TickLength = 5;
			this.Heat_Value.TrackHandleSize = 28;
			this.Heat_Value.TrackLineDisabledBrush = new NxtControl.Drawing.Brush("TrackerLineDisabledBrush");
			this.Heat_Value.EndInit();
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(0.86D, 0D, 0D, 0.80952380952380953D, 64D, 262D);
			this.Label.FontScale = false;
			this.Label.IsOnlyInput = true;
			this.Label.Name = "Label";
			this.Label.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Label.TagName = "Label";
			this.Label.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LabelValueChanged);
			this.Label.EndInit();
			// 
			// freeText_11
			// 
			this.freeText_11.BeginInit();
			this.freeText_11.AngleIgnore = false;
			this.freeText_11.DecimalPlacesCount = ((uint)(2u));
			this.freeText_11.DesignTransformation = new NxtControl.Drawing.Matrix(4.681640625D, 0D, 0D, 7.4239999999999995D, 205D, 137D);
			this.freeText_11.Name = "freeText_11";
			this.freeText_11.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.freeText_11.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.freeText_11.TagName = "Heat_Value";
			this.freeText_11.TextAngle = 0F;
			this.freeText_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FreeText_11ValueChanged);
			this.freeText_11.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Heat_Value,
									this.Label,
									this.freeText_11});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.FreeText<float> freeText_11;
		private System.HMI.Symbols.Base.Label Label;
		private System.HMI.Symbols.Base.TrackerVertical<float> Heat_Value;
		#endregion
	}
}
