﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Paycor.Import.ImportHubTest.Common
{
    public interface IValidator <T>
    {
        void Validate();
    }
}
