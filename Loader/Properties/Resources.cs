

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Loader.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Loader.Properties.Resources.resourceMan == null)
          Loader.Properties.Resources.resourceMan = new ResourceManager("Loader.Properties.Resources", typeof (Loader.Properties.Resources).Assembly);
        return Loader.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Loader.Properties.Resources.resourceCulture;
      set => Loader.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap standard => (Bitmap) Loader.Properties.Resources.ResourceManager.GetObject(nameof (standard), Loader.Properties.Resources.resourceCulture);
  }
}
