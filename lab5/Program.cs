// See https://aka.ms/new-console-template for more information
using Company;
Console.WriteLine("Hello, World!");
Client Andrew = new Client("Andrew", "****");
Client TestClient = new Client("TestNeme", "something");
TransportCompany MinskTrans = new TransportCompany("MinskTrans", 4.45);
TransportCompany BelRail = new TransportCompany("BelRail", 2.24);
Andrew.CreatOrder(MinskTrans, MinskTrans.GetCompTarief(), 20);
Andrew.CreatOrder(BelRail, BelRail.GetCompTarief(), 50);
Andrew.CreatOrder(BelRail, 2.15, 66);
Console.WriteLine(Andrew.GetTotalExpances());
Console.WriteLine(MinskTrans.GetTotalIncome());
Console.WriteLine(BelRail.GetTotalIncome());