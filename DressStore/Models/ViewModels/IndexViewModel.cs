
using System.Collections.Generic;

namespace DressStore.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Dress> Dresses { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }

        //public IndexViewModel(IEnumerable<Dress> dresses, IEnumerable<CompanyModel> companyModels)
        //{
        //    Dresses = dresses;
        //    Companies = companyModels;
        //}

    }
}
