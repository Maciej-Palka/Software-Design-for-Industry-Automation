/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/14/2016
 * Time: 1:47 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Test
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
			this.retract = new System.HMI.Symbols.Base.CheckButton();
			this.to_mgz = new System.HMI.Symbols.Base.CheckButton();
			this.to_next = new System.HMI.Symbols.Base.CheckButton();
			this.vcm_on = new System.HMI.Symbols.Base.CheckButton();
			this.vcm_off = new System.HMI.Symbols.Base.CheckButton();
			// 
			// retract
			// 
			this.retract.BeginInit();
			this.retract.AngleIgnore = false;
			this.retract.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 9D, 216D);
			this.retract.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.retract.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.retract.FalseText = "Push WP";
			this.retract.Name = "retract";
			this.retract.TagName = "retract";
			this.retract.TextColorFalse = new NxtControl.Drawing.Color("Red");
			this.retract.TextColorTrue = new NxtControl.Drawing.Color("Green");
			this.retract.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.retract.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.retract.TrueText = "Push WP";
			this.retract.Value = false;
			this.retract.EndInit();
			// 
			// to_mgz
			// 
			this.to_mgz.BeginInit();
			this.to_mgz.AngleIgnore = false;
			this.to_mgz.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 107D, 215D);
			this.to_mgz.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.to_mgz.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.to_mgz.FalseText = "GO TO MAG";
			this.to_mgz.Name = "to_mgz";
			this.to_mgz.TagName = "to_mgz";
			this.to_mgz.TextColorFalse = new NxtControl.Drawing.Color("Red");
			this.to_mgz.TextColorTrue = new NxtControl.Drawing.Color("Green");
			this.to_mgz.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.to_mgz.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.to_mgz.TrueText = "GO TO MAG";
			this.to_mgz.Value = false;
			this.to_mgz.EndInit();
			// 
			// to_next
			// 
			this.to_next.BeginInit();
			this.to_next.AngleIgnore = false;
			this.to_next.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 208D, 215D);
			this.to_next.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.to_next.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.to_next.FalseText = "GO TO NEXT";
			this.to_next.Name = "to_next";
			this.to_next.TagName = "to_next";
			this.to_next.TextColorFalse = new NxtControl.Drawing.Color("Red");
			this.to_next.TextColorTrue = new NxtControl.Drawing.Color("Green");
			this.to_next.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.to_next.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.to_next.TrueText = "GO TO NEXT";
			this.to_next.Value = false;
			this.to_next.EndInit();
			// 
			// vcm_on
			// 
			this.vcm_on.BeginInit();
			this.vcm_on.AngleIgnore = false;
			this.vcm_on.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 308D, 214D);
			this.vcm_on.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.vcm_on.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.vcm_on.FalseText = "VACUUM ON";
			this.vcm_on.Name = "vcm_on";
			this.vcm_on.TagName = "vcm_on";
			this.vcm_on.TextColorFalse = new NxtControl.Drawing.Color("Red");
			this.vcm_on.TextColorTrue = new NxtControl.Drawing.Color("Green");
			this.vcm_on.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.vcm_on.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.vcm_on.TrueText = "VACUUM ON";
			this.vcm_on.Value = false;
			this.vcm_on.EndInit();
			// 
			// vcm_off
			// 
			this.vcm_off.BeginInit();
			this.vcm_off.AngleIgnore = false;
			this.vcm_off.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 407D, 214D);
			this.vcm_off.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.vcm_off.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.vcm_off.FalseText = "VACUUM OFF";
			this.vcm_off.Name = "vcm_off";
			this.vcm_off.TagName = "vcm_off";
			this.vcm_off.TextColorFalse = new NxtControl.Drawing.Color("Red");
			this.vcm_off.TextColorTrue = new NxtControl.Drawing.Color("Green");
			this.vcm_off.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.vcm_off.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.vcm_off.TrueText = "VACUUM OFF";
			this.vcm_off.Value = false;
			this.vcm_off.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.retract,
									this.to_mgz,
									this.to_next,
									this.vcm_on,
									this.vcm_off});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.CheckButton vcm_off;
		private System.HMI.Symbols.Base.CheckButton vcm_on;
		private System.HMI.Symbols.Base.CheckButton to_next;
		private System.HMI.Symbols.Base.CheckButton to_mgz;
		private System.HMI.Symbols.Base.CheckButton retract;
		#endregion
	}
}
