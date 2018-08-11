using System.Collections.Generic;
using System.Web.Mvc;

namespace LinaMovies.Web.ViewModels.Authentication
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}