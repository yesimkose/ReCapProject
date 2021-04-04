using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(Image carImages, IFormFile file);
        IResult Delete(Image carImages);
        IResult Update(Image carImages, IFormFile file);
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> Get(int id);
    }
}
