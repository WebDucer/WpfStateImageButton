using System.Windows;
using de.webducer.csharp.WpfControls.ImageButton.ViewModels;

namespace de.webducer.csharp.DemoApplication {
   /// <summary>
   /// Interaktionslogik für MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window {
      public MainWindow() {
         InitializeComponent();

         DataContext = new MainViewModel {
            AllStates = new ImageButtonViewModel {
               ToolTipText = "All States Images",
               DefaultImageName = "Images/default.png",
               FocusedImageName = "Images/active.png",
               DisabledImageName = "Images/disabled.png"
            },
            NoDisabled = new ImageButtonViewModel {
               ToolTipText = "No Disabled Image",
               DefaultImageName = "Images/default.png",
               FocusedImageName = "Images/active.png"
            },
            NoFocused = new ImageButtonViewModel {
               ToolTipText = "No Focused Image",
               DefaultImageName = "Images/default.png",
               DisabledImageName = "Images/disabled.png"
            }
         };
      }
   }
}
