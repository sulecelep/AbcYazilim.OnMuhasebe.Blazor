using AbcYazilim.OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbcYazilim.OnMuhasebe.Cariler;
public class CariHareketListParameterDto:PagedResultRequestDto , IDurum , IEntityDto
{
    public Guid CariId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}
