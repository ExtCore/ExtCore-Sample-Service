// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Shared;

namespace MultiplyExtension
{
  public class MultiplyOperation : IOperation
  {
    public int Calculate(int a, int b)
    {
      return a * b;
    }
  }
}