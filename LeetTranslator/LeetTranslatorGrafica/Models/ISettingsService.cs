﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public interface ISettingsService
    {
        IList<Theme> Themes { get; }
    }
}
