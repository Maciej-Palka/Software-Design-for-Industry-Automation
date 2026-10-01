/*
 * Created by nxtSTUDIO.
 * User: Sandeep Patil
 * Date: 2/16/2019
 * Time: 1:12 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ControlPanel_HMI;

namespace HMI.Main.Symbols.ControlPanel
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? LiftUp_field = null;
    public System.Boolean? LiftUp
    {
       get { return LiftUp_field; }
       set { LiftUp_field = value; }
    }
    private System.Boolean? LiftDown_field = null;
    public System.Boolean? LiftDown
    {
       get { return LiftDown_field; }
       set { LiftDown_field = value; }
    }
    private System.Boolean? Push_field = null;
    public System.Boolean? Push
    {
       get { return Push_field; }
       set { Push_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.ControlPanel
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.Boolean LiftUp, System.Boolean LiftDown, System.Boolean Push)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {LiftUp, LiftDown, Push});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.ControlPanel.CNFEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.LiftUp.HasValue) _values_[0] = ea.LiftUp.Value;
      if (ea.LiftDown.HasValue) _values_[1] = ea.LiftDown.Value;
      if (ea.Push.HasValue) _values_[2] = ea.Push.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean LiftUp, bool ignore_LiftUp, System.Boolean LiftDown, bool ignore_LiftDown, System.Boolean Push, bool ignore_Push)
    {
      object[] _values_ = new object[3];
      if (!ignore_LiftUp) _values_[0] = LiftUp;
      if (!ignore_LiftDown) _values_[1] = LiftDown;
      if (!ignore_Push) _values_[2] = Push;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ControlPanel_HMI;

#endregion Definitions;
