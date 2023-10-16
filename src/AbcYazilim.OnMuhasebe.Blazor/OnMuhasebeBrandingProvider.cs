﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbcYazilim.OnMuhasebe.Blazor;

[Dependency(ReplaceServices = true)]
public class OnMuhasebeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OnMuhasebe";
}
