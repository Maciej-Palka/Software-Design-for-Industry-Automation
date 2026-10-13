/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/20/2016
 * Time: 4:32 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ButtonM_HMI;

namespace HMI.Main.Symbols.ButtonM
{

  public class INIT1EventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INIT1EventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Label(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String Label
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

}

namespace HMI.Main.Symbols.ButtonM
{

  public class REQEventArgs : System.EventArgs
  {
    public REQEventArgs()
    {
    }
    private System.Boolean? Button_field = null;
    public System.Boolean? Button
    {
       get { return Button_field; }
       set { Button_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.ButtonM
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.ButtonM.INIT1EventArgs> INIT1_Fired;

    protected override void OnEndInit()
    {
      if (INIT1_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (INIT1_Fired != null)
          {
            try
            {
              INIT1_Fired(this, new HMI.Main.Symbols.ButtonM.INIT1EventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","INIT1_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Boolean Button)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Button});
    }
    public bool FireEvent_REQ(HMI.Main.Symbols.ButtonM.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Button.HasValue) _values_[0] = ea.Button.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Boolean Button, bool ignore_Button)
    {
      object[] _values_ = new object[1];
      if (!ignore_Button) _values_[0] = Button;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ButtonM_HMI;

#endregion Definitions;
