// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography;


Product newProduct = new Product(298, "libro", "libro molto bello", 100, 30);

Console.WriteLine(newProduct.GetCode());
Console.WriteLine(newProduct.GetName());
Console.WriteLine(newProduct.GetDescription());
Console.WriteLine(newProduct.GetPrice());
Console.WriteLine(newProduct.GetIva());


Console.WriteLine("nuovo nome: " + newProduct.SetName("libro nuovo"));
Console.WriteLine("nuova descrizione: " + newProduct.SetDescription("libro ancora più bello"));
Console.WriteLine("nuovo prezzo: " + newProduct.SetPrice(20));
Console.WriteLine("nuova iva: " + newProduct.SetIva(10));


newProduct.PrezzoIva();
newProduct.ExtendendName();

//creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

//Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto.

//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
//Buon lavoro!

public class Product
{
    private int code;
    string name;
    string description;
    double price;
    int iva;

    public Product ()
    {
        this.code = new Random().Next(1, 1001);
        
    }

    public Product(int code, string name, string description,double price,int iva)
    {
        this.code = code;
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

    public int PrezzoIva()
    {
        int conversion = Convert.ToInt32(this.price);
        int perc = conversion * this.iva;
        int div = perc / 100;
        int result = conversion - div;
        Console.WriteLine(result);
        return result;
    }

    public void ExtendendName()
    {
        //concatenare codice al nome
        string conversion = Convert.ToString(this.code);
        Console.WriteLine("code: " + this.code + " name: " + this.name);
    }
}