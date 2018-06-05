using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ULA.Presentation.Infrastructure.ViewModels.Interactions;

namespace ULA.Presentation.Infrastructure.ViewModels
{
    public interface ICommandOnTemplateInteractionViewModel : IInteractionViewModel
    {
        string Title { get; set; }

        ICommand EditTemplateCommand { get; }
        ICommand SaveTemplateCommand { get; }
        ICommand SaveAsTemplateCommand { get; }
        ICommand DeleteTemplateCommand { get; }
        ICommand ExecuteTemplateCommand { get; }
        ICommand ExitWindowCommand { get; }



    }
}
