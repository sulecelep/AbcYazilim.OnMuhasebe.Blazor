using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbcYazilim.OnMuhasebe.CommonDtos;
public class CodeParameterDto : IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
