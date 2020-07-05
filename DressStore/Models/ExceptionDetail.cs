
using System;

namespace DressStore.Models
{
    public class ExceptionDetail
    {
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ControllerName { get; set; }
        public string AuctionName { get; set; }
        public string StackTrace { get; set; }
        public DateTime Date { get; set; }

    }
}
