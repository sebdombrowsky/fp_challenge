﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public class Product
  {
    public Product()
    {
    }

    public int Id { get; set; }

    public string BrandName { get; set; }

    public string Name { get; set; }

    public string DescriptionText { get; set; }

    public List<Article> Articles { get; set; } = new List<Article>();
  }
}
