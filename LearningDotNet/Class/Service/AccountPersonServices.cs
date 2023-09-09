using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountPersonServices : IAccountPersonServices
{
    public List<AccountPerson> GetAllAccounts()
    {
        List<AccountPerson> ListPersons = new List<AccountPerson>();
        return ListPersons;
    }

    bool IAccountPersonServices.CreateNewAccountPerson(AccountPerson acccountPerson)
    {
        return true; 
    }
}

interface IAccountPersonServices
{
    bool CreateNewAccountPerson(AccountPerson acccountPerson);
    List<AccountPerson> GetAllAccounts();
}