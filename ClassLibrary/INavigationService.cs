using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface INavigationService
    {
        Task NavigateToAsync(string route);
        Task NavigateToAsync(string route, ObjectWeAreSending thing);

        Task GoBackAsync();
    }
}
