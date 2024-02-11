using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tokei_wform
{
    // reference site
    // https://qiita.com/yakumo_crow/items/a65de5e2f35eaae8ef60

    public class VirtualDesktopManager
    {
        public static readonly IVirtualDesktopManager DesktopManager;

        static VirtualDesktopManager()
        {
            var type = Type.GetTypeFromCLSID(new Guid("aa509086-5ca9-4c25-8f95-589d3c07b48a"));
            DesktopManager = (IVirtualDesktopManager)Activator.CreateInstance(type);
        }
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("a5cd92ff-29be-454c-8d04-d82879fb3f1b")]
    public interface IVirtualDesktopManager
    {
        bool IsWindowOnCurrentVirtualDesktop(IntPtr topLevelWindow);
        Guid GetWindowDesktopId(IntPtr topLevelWindow);
        void MoveWindowToDesktop(IntPtr topLevelWindow, ref Guid desktopId);
    }
}
