using InterfaceExercicio.Entities;
using InterfaceExercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercicio.Services
{
    class ContractService
    {
        private IPaypalService _paymentService;

        public ContractService(IPaypalService onlinePaymentService)
        {
            _paymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
