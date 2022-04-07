using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Models.System.ViewModels
{
    public class GenderViewModel
    {
        public IEnumerable<Gender> AllGenders { get; set; }
        public Gender ManageGender { get; set; }
    }
}
