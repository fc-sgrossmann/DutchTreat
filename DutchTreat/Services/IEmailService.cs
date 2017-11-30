using System;
using DutchTreat.ViewModels;

namespace DutchTreat.Services
{
    public interface IEmailService
    {
        void SendMessage(KontaktViewModel contact);
    }
}
