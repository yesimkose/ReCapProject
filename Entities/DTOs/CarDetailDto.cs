using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public interface CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
        public  decimal DailyPrice { get; set; }

    }
}
