/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 10:37 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Door_HMI;

namespace HMI.Main.Symbols.Door
{

  public class INITCEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INITCEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_DoorPosition(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? DoorPosition
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace HMI.Main.Symbols.Door
{

  public class CHGEventArgs : System.EventArgs
  {
    public CHGEventArgs()
    {
    }

  }

}

namespace HMI.Main.Symbols.Door
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.Door.INITCEventArgs> INITC_Fired;

    private event EventHandler<HMI.Main.Symbols.Door.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (INITC_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (INITC_Fired != null)
          {
            try
            {
              INITC_Fired(this, new HMI.Main.Symbols.Door.INITCEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","INITC_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.Door.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CHG()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_CHG(HMI.Main.Symbols.Door.CHGEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Door_HMI;

#endregion Definitions;
