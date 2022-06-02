using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public class Article
  {
    public Article()
    {
    }

    public int Id { get; set; }

    public string ShortDiscription { get; set; }

    public double Price { get; set; }

    public string Unit { get; set; }

    public string PricePerUnitText { get; set; }

    public string Image { get; set; }
  }
}
