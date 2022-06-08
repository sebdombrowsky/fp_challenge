using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public class NavigationModel
  {
    public bool IsDetailsView { get; set; } = true;

    public bool SortAscending { get; set; } = true;

    public bool FilterMoreExpensiveThan2 { get; set; } = false;

    public Dictionary<int, bool> FavouriteStatus { get; set; } = new Dictionary<int, bool>();
  }
}
