using de.webducer.csharp.WpfControls.ImageButton.ViewModels;

namespace de.webducer.csharp.DemoApplication {
   public class MainViewModel {
      public ImageButtonViewModel AllStates {
         get;
         set;
      }

      public ImageButtonViewModel NoDisabled {
         get;
         set;
      }

      public ImageButtonViewModel NoFocused {
         get;
         set;
      }
   }
}
