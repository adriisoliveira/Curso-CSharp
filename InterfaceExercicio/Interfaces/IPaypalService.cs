﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercicio.Interfaces
{
    interface IPaypalService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);

    }
}
