﻿using System;
using System.Windows.Input;

namespace GitClientVS.Contracts.Interfaces.Views
{
    public interface IPullRequestsWindowContainerViewModel : IViewModel
    {
        event EventHandler Closed;
    }
}