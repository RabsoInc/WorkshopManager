using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class TitleViewModel
    {
        public IEnumerable<Title> AllTitles { get; set; }
        public Title ManageTitle { get; set; }
    }
}
