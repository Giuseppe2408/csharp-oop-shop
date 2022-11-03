// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography;


Product newProduct = new Product("libro", "libro molto bello", 100, 30);



Console.WriteLine();
Console.WriteLine("funzionalità di reading");
Console.WriteLine();

//funzionalità di lettura
Console.WriteLine("codice: " + newProduct.Code);
Console.WriteLine("nome: " + newProduct.Name);
Console.WriteLine("descrzione: " + newProduct.Description);
Console.WriteLine("prezzo: " + newProduct.Price);
Console.WriteLine("iva: " + newProduct.Iva);

Console.WriteLine();
Console.WriteLine("funzionalità di setting");
Console.WriteLine();

//variabili di setting

newProduct.Name = "nuovo lobrp";
newProduct.Description = "nuovas descrizione";
newProduct.Price = 22;
newProduct.Price = 10;

//stampa di setting
Console.WriteLine("nuovo nome: " + newProduct.Name);
Console.WriteLine("nuova descrizione: " + newProduct.Description);
Console.WriteLine("nuovo prezzo: " + newProduct.Price);
Console.WriteLine("nuova iva: " + newProduct.Iva);

Console.WriteLine("il prezzo con l'iva è: " + newProduct.IvaPrice());

newProduct.ExtendendName();
Console.WriteLine();
//bonus
Console.Write("Il codice esteso a 8 cifre è: ");
//Console.WriteLine(newProduct.ExtendCode());











//creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
public class Product
{

    

   

    public double price;
    public int iva;


    public int Code { get; }
    public string Name { get; set;  }
    public string Description { get; set;}
    public double Price { get; set; }
    public int Iva { get; set; }

    public Product ()
    {
        //Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
        //alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        this.Code = new Random().Next(1, 1001);
        
    }

    public Product(string name, string description,double price,int iva)
    {
        //this.code = 1000000;
        this.Code = new Random().Next(1, 100);
        this.Name = name;
        this.Description = description;
        this.Price = price;   
        this.Iva = iva;

    }

    // disponibile solo in lettura 
   

    //Gli altri attributi siano accessibili sia in lettura che in scrittura



    //Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    public int IvaPrice()
    {
        int conversion = Convert.ToInt32(this.Price);
        int perc = conversion * this.Iva;
        int div = perc / 100;
        int result = conversion - div;
        return result;
    }
    //Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
    public void ExtendendName()
    {
        //concatenare codice al nome
        string conversion = Convert.ToString(this.Code);
        Console.WriteLine("code: " + this.Code + " name: " + this.Name);
    }


    //BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
    //public string ExtendCode()
    //{
    //    string conversion = Convert.ToString(this.Code);
    //    int lunghezza = conversion.Length;
    //    string zero = "0";
    //    string result = "";
    //    if (lunghezza < 8)
    //    {
    //        for (i = 0; i < 8; i++)
    //        {
    //            result = zero + conversion;
    //            //Console.Write("0");
    //        }
    //    }
    //    return result;
    //}
}