// See https://aka.ms/new-console-template for more information
using static SOLID.LSP.LSP_OFF;
using static SOLID.OCP.OCP_OFF;
//using static SOLID.OCP.OCP_ON;

Console.WriteLine("Hello, World!");

var invoice = new Invoice();

invoice.OrderType = OrderType.Example;
invoice.SetInvoice();

//var invoice = new Invoice( new CompanyInvoice());
//invoice.SetInvoice();

//-------------------------------
