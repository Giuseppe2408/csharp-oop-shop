// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography;


Product newProduct = new Product("libro", "libro molto bello", 100, 30);



Console.WriteLine();
Console.WriteLine("funzionalità di reading");
Console.WriteLine();

//funzionalità di lettura
Console.WriteLine("codice: " + newProduct.GetCode());
Console.WriteLine("nome: " + newProduct.GetName());
Console.WriteLine("descrzione: " + newProduct.GetDescription());
Console.WriteLine("prezzo: " + newProduct.GetPrice());
Console.WriteLine("iva: " + newProduct.GetIva());

Console.WriteLine();
Console.WriteLine("funzionalità di setting");
Console.WriteLine();

//funzionalità di setting
Console.WriteLine("nuovo nome: " + newProduct.SetName("libro nuovo"));
Console.WriteLine("nuova descrizione: " + newProduct.SetDescription("libro ancora più bello"));
Console.WriteLine("nuovo prezzo: " + newProduct.SetPrice(20));
Console.WriteLine("nuova iva: " + newProduct.SetIva(10));

Console.WriteLine("il prezzo con l'iva è: " + newProduct.IvaPrice());

newProduct.ExtendendName();
Console.WriteLine();
//bonus
Console.Write("Il codice esteso a 8 cifre è: ");
Console.WriteLine(newProduct.ExtendCode());











//creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
public class Product
{
    private int code;
    string name;
    string description;
    double price;
    int iva;

    public Product ()
    {
        //Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
        //alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        this.code = new Random().Next(1, 1001);
        
    }

    public Product(string name, string description,double price,int iva)
    {
        //this.code = 1000000;
        this.code = new Random().Next(1, 10000001);
        this.name = name;
        this.description = description;
        this.price = price;   
        this.iva = iva;

    }

    // disponibile solo in lettura 
    public int GetCode()
    {
        return this.code;
    }

    //Gli altri attributi siano accessibili sia in lettura che in scrittura
    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public double GetIva()
    {
        return this.iva;
    }

    public int SetCode(int code)
    {
        return this.code = code;
    }

    public string SetName(string name)
    {
        return this.name = name;
    }

    public string SetDescription(string description)
    {
        return this.description = description;
    }

    public double SetPrice(double price)
    {
        return this.price = price;
    }

    public double SetIva(int iva)
    {
        return  this.iva = iva;
    }
    //Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    public int IvaPrice()
    {
        int conversion = Convert.ToInt32(this.price);
        int perc = conversion * this.iva;
        int div = perc / 100;
        int result = conversion - div;
        return result;
    }
    //Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
    public void ExtendendName()
    {
        //concatenare codice al nome
        string conversion = Convert.ToString(this.code);
        Console.WriteLine("code: " + this.code + " name: " + this.name);
    }


    //BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
    public string ExtendCode()
    {
        string conversion = Convert.ToString(this.code);
        int lunghezza = conversion.Length;
        if (lunghezza < 8)
        {
            for (; lunghezza < 8; lunghezza++)
            {
                Console.Write("0");
            }
        }
        return conversion;
    }
}