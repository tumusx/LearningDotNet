using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Person
{
    int Id { get; set; }
    int idadePessoa {  get; set;}
    String nomePessoa { get; set;}
    public Person(int idadePessoa, string nomePessoa)    {
        this.nomePessoa = nomePessoa;
        this.idadePessoa = idadePessoa;
    }
}

class AccountPerson
{
    String addressAccount { get; set; }
    private List<Person> persons { get; } = new List<Person>();
    int idAccountCurrent { get; set; }

    Person person { get; set;}

    AccountTypes typeAccount;

    public AccountPerson(String addressAccount, Person person, AccountTypes accountTypes)
    {
        this.addressAccount = addressAccount;
        this.person = person;
        this.typeAccount = accountTypes;
    }
}


enum AccountTypes
{
    CONTA_CORRENTE, CONTA_SALARIO, CONTA_POUPANCA;
}