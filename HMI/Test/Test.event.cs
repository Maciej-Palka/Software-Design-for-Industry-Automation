/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/14/2016
 * Time: 1:47 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Test_HMI;

namespace HMI.Main.Symbols.Test
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? retract_field = null;
    public System.Boolean? retract
    {
       get { return retract_field; }
       set { retract_field = value; }
    }
    private System.Boolean? to_mgz_field = null;
    public System.Boolean? to_mgz
    {
       get { return to_mgz_field; }
       set { to_mgz_field = value; }
    }
    private System.Boolean? to_next_field = null;
    public System.Boolean? to_next
    {
       get { return to_next_field; }
       set { to_next_field = value; }
    }
    private System.Boolean? vcm_on_field = null;
    public System.Boolean? vcm_on
    {
       get { return vcm_on_field; }
       set { vcm_on_field = value; }
    }
    private System.Boolean? vcm_off_field = null;
    public System.Boolean? vcm_off
    {
       get { return vcm_off_field; }
       set { vcm_off_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.Test
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.Boolean retract, System.Boolean to_mgz, System.Boolean to_next, System.Boolean vcm_on, System.Boolean vcm_off)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {retract, to_mgz, to_next, vcm_on, vcm_off});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.Test.CNFEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.retract.HasValue) _values_[0] = ea.retract.Value;
      if (ea.to_mgz.HasValue) _values_[1] = ea.to_mgz.Value;
      if (ea.to_next.HasValue) _values_[2] = ea.to_next.Value;
      if (ea.vcm_on.HasValue) _values_[3] = ea.vcm_on.Value;
      if (ea.vcm_off.HasValue) _values_[4] = ea.vcm_off.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean retract, bool ignore_retract, System.Boolean to_mgz, bool ignore_to_mgz, System.Boolean to_next, bool ignore_to_next, System.Boolean vcm_on, bool ignore_vcm_on, System.Boolean vcm_off, bool ignore_vcm_off)
    {
      object[] _values_ = new object[5];
      if (!ignore_retract) _values_[0] = retract;
      if (!ignore_to_mgz) _values_[1] = to_mgz;
      if (!ignore_to_next) _values_[2] = to_next;
      if (!ignore_vcm_on) _values_[3] = vcm_on;
      if (!ignore_vcm_off) _values_[4] = vcm_off;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Test_HMI;

#endregion Definitions;
