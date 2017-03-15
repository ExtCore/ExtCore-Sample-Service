// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using ExtCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Shared;

namespace PlusExtension
{
  public class PlusExtension : ExtensionBase
  {
    public override IEnumerable<KeyValuePair<int, Action<IServiceCollection>>> ConfigureServicesActionsByPriorities
    {
      get
      {
        return new Dictionary<int, Action<IServiceCollection>>()
        {
          [1000] = services =>
          {
            services.AddScoped(typeof(IOperation), typeof(PlusOperation));
          }
        };
      }
    }
  }
}