using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Application.Dto;
using UnluCo.Domain.Models;

namespace UnluCo.Application.Interface
{
    public  interface IColorService
    {
        Task Add(ColorDto colorDto);
        void Delete(ColorDto colorDto);
        void Update(ColorDto colorDto);
        Task<List<ColorDto >> GetAll();
       
    }
}
