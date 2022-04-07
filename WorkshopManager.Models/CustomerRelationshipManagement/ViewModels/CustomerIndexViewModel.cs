using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;

namespace WorkshopManager.Models.CustomerRelationshipManagement.ViewModels
{
    public class CustomerIndexViewModel
    {
        public Customer NewCustomer { get; set; }
        public IEnumerable<Customer> AllCustomers { get; set; }
    }
}
