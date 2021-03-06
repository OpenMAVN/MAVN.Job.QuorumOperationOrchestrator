using System;

namespace MAVN.Job.QuorumOperationOrchestrator.Domain
{
    public class OperationCannotBeProcessedException : Exception
    {
        public OperationCannotBeProcessedException(string walletAddress)
        {
            WalletAddress = walletAddress;
        }

        public string WalletAddress { get; }
    }
}
