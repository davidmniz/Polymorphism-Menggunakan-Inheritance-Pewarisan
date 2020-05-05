using System;

namespace Inheritance
{
class PrinterWindows
{
private string var1 = "Demo Pewarisan"; //hak akses private berarti tidak dapat diakses oleh kls anak
public string var2 = "10*11";
public string var3 = "9.5*12";
public string var4 = "12*12";//hak akses public berarti dapat diakses oleh kls anak
public PrinterWindows()
{ }
public void cetakData()
{ }
}
class Epson : PrinterWindows
{
public Epson()
{ }
public void cetak()
{
cetakData();
}
}

class Canon : PrinterWindows
{
public Canon()
{ }
public void cetak()
{
cetakData();
}
}

class LaserJet : PrinterWindows
{
public LaserJet()
{ }
public void cetak()
{
cetakData();
}
}






class Printer
{
static void Main(string[] args)
{
PrinterWindows printer;

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1){
                Epson Epson = new Epson();
 
Epson.cetak();
Epson.cetakData();
Console.WriteLine("Epson display dimension : " + Epson.var2);
Console.WriteLine("Epson printer printing...");
            }

            else if (nomorPrinter == 2){
                Canon Canon = new Canon();
            
Canon.cetak();
Canon.cetakData();
Console.WriteLine("Canon display dimension : " + Canon.var3);
Console.WriteLine("Canon printer printing...");
            }
            else
               {LaserJet LaserJet = new LaserJet();
 
LaserJet.cetak();
LaserJet.cetakData();
Console.WriteLine("LaserJet display dimension : " + LaserJet.var4);
Console.WriteLine("LaserJet printer printing...");
               }

 


            Console.ReadKey();
        }

}

}
