using System;
using DutchTreat.ViewModels;

namespace DutchTreat.Classes
{
    public interface Iemail
    {
        void email(KontaktViewModel contact);
    }
}
