using System;
using System.Collections.Generic;


class Ebook 
{
    string name;
    string author;
    double price;

    public Ebook(string name, string author, double price)
    {
        this.name = name;
        this.author = author;   
        this.price = price; 
    }
    public bool compare(string name)
    {
        if(this.name == name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void see()
    {
        Console.WriteLine(name + "\t" + author + "\t" + price);
    }
}

class AllGoods
{

    List<Ebook> ebooks = new List<Ebook>();

    public AllGoods()
    {
        ebooks.Add(new Ebook("r", "rr", 5));
        ebooks.Add(new Ebook("d", "dd", 5));
        ebooks.Add(new Ebook("f", "ff", 5));
    }
    public void add()
    {
        string a; string b; 
        double c = 0; 
        Console.WriteLine("Виберіть категорію\n" + 
            "1) електронну книгу\n");
        a = Console.ReadLine();
        if (a == "1")
        {
            a = "";
            Console.Clear();
            Console.Write("Назва:");
            a = Console.ReadLine();
            Console.Write("Автор:");
            b = Console.ReadLine();
            Console.Write("Ціна:");
            c = Convert.ToDouble(Console.ReadLine());
            if(a != null && b != null)
            ebooks.Add(new Ebook(a,b,c));
        }
        else
        {
            Console.WriteLine("Такої категорії немає");
        }
    }
    public void see()
    {
        Console.WriteLine("Назва\t" + "Автор\t" + "Ціна\t");
        foreach (Ebook ebook in ebooks)
        { 
            ebook.see();
        }
    }
    public void sell()
    {
        string a;
        Console.WriteLine("Введіть назву товару");
        a = Console.ReadLine();
        foreach (Ebook ebook in ebooks)
        {
            if(ebook.compare(a) == true)
            {
                a = "true";
                Console.WriteLine("Товар додано у кошик");
            }
            if (a != "true")
            {
                Console.WriteLine("Товар не знайдено");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        string a;

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        AllGoods allgoods = new AllGoods();
        while (true)
        {
            a = "";
            
            allgoods.see();

            Console.WriteLine("1) додати товар\n"
                + "2) купити товар\n");

            a = Console.ReadLine();
            Console.Clear();
            if (a == "1")
            {
                allgoods.add();
            }
            else if (a == "2")
            {
                allgoods.sell();

            }
            else
            {
                Console.WriteLine("Опція не знайдена");
            }
        }
    }
}

