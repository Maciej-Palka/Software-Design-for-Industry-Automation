/*
 * Created by nxtSTUDIO.
 * User: Sandeep Patil
 * Date: 2/16/2019
 * Time: 1:12 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ControlPanel
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
			this.LiftUp = new System.HMI.Symbols.Base.SwitchButton();
			this.LiftDown = new System.HMI.Symbols.Base.SwitchButton();
			this.Pusher = new System.HMI.Symbols.Base.SwitchButton();
			// 
			// LiftUp
			// 
			this.LiftUp.BeginInit();
			this.LiftUp.AngleIgnore = false;
			this.LiftUp.DesignTransformation = new NxtControl.Drawing.Matrix(1.7375D, 0D, 0D, 1D, 17.999999999999986D, 7D);
			this.LiftUp.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.LiftUp.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.LiftUp.FalseText = "LIFT UP OFF";
			this.LiftUp.Name = "LiftUp";
			this.LiftUp.TagName = "LiftUp";
			this.LiftUp.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.LiftUp.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.LiftUp.TrueText = "LIFT UP ON";
			this.LiftUp.Value = false;
			this.LiftUp.EndInit();
			// 
			// LiftDown
			// 
			this.LiftDown.BeginInit();
			this.LiftDown.AngleIgnore = false;
			this.LiftDown.DesignTransformation = new NxtControl.Drawing.Matrix(1.9625000000000001D, 0D, 0D, 1D, 180D, 7D);
			this.LiftDown.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.LiftDown.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.LiftDown.FalseText = "LIFT DOWN OFF";
			this.LiftDown.Name = "LiftDown";
			this.LiftDown.TagName = "LiftDown";
			this.LiftDown.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.LiftDown.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.LiftDown.TrueText = "LIFT DOWN ON";
			this.LiftDown.Value = false;
			this.LiftDown.EndInit();
			// 
			// Pusher
			// 
			this.Pusher.BeginInit();
			this.Pusher.AngleIgnore = false;
			this.Pusher.DesignTransformation = new NxtControl.Drawing.Matrix(1.475D, 0D, 0D, 1D, 361D, 7D);
			this.Pusher.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Pusher.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Pusher.FalseText = "PUSHER OFF";
			this.Pusher.Name = "Pusher";
			this.Pusher.TagName = "Push";
			this.Pusher.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Pusher.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Pusher.TrueText = "PUSHER ON";
			this.Pusher.Value = false;
			this.Pusher.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.LiftUp,
									this.LiftDown,
									this.Pusher});
			this.SymbolSize = new System.Drawing.Size(493, 45);
		}
		private System.HMI.Symbols.Base.SwitchButton Pusher;
		private System.HMI.Symbols.Base.SwitchButton LiftDown;
		private System.HMI.Symbols.Base.SwitchButton LiftUp;
		#endregion
	}
}
