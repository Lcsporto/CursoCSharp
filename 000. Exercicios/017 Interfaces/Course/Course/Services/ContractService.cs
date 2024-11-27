using System.Globalization;
using Course.Entities;

namespace Course.Services
{
    internal class ContractService
    {
        public Contract Contract { get; set; }
        public int Months { get; set; }

        public IOnlinePaymentService _onlinePaymentService;

        public ContractService(Contract contract, int months, IOnlinePaymentService onlinePaymentService)
        {
            Contract = contract;
            Months = months;
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = _onlinePaymentService.PaymentFee(_onlinePaymentService.Interest(contract.TotalValue, i));
                

                contract.list.Add(new Installment(dueDate, amount)); // Para manter essa opreção no devido lugar, criar uma função no Contract apenas para adicionar elementos na lista;
            }
        }
    }
}
