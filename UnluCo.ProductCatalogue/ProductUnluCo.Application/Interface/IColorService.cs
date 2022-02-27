using ProductUnluCo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.Interface
{
    public interface IColorService
    {
        Task Add(ColorDto colorDto);
        void Delete(ColorDto colorDto);
        void Update(ColorDto colorDto);
        Task<List<ColorDto>> GetAll();

    }
}
