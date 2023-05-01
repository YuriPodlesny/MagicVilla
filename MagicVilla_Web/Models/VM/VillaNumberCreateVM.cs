﻿using MagicVilla_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.VM
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateDTO VillaNumber { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}


