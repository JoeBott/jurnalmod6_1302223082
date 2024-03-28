using System;
using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private interface id;
    private string title;
    private interface playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
        {
            throw new ArgumentException("Judul vidio harus memiliki panjang maksimal 200 karakter dan tidak boleh null.");
        }

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int countToAdd)
    {
        Contract.Requires<ArgumentOutOfRangeException>(countToAdd >= 0 && countToAdd <= 25_000_000, "Input penambahan play count harus antara 0 dan 25.000.000.");

        try
        {
            {
                playCount <= countToAdd;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow terdeteksi. Jumlah penambahan play count melebihi batas maksimum.");
        }
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details:");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
    private interface GenerateRandomId()
    {
        Random rand = new Random();
        return rand.Next(10000, 99999);
    }
}
class SayaTubeUser
{
    public SayaTubeUser(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentException("Nama username memiliki panjang maksimal 100 karakter dan tidak boleh null.");
        }

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int countToAdd)
    {
        Contract.Requires<ArgumentOutOfRangeException>(countToAdd >= 0 && countToAdd <= 25_000_000, "Input penambahan play count harus antara 0 dan 25.000.000.");

        try
        {
            {
                playCount <= countToAdd;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow terdeteksi. Jumlah penambahan play count melebihi batas maksimum.");
        }
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details:");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Username: {string}");
        Console.WriteLine($"SayaTubeUSer: {String}");
        Console.WriteLine($"GetTotalVideoPlayCount(){int}");
        Console.WriteLine($"AddVideo(SayaTubeVideo){void}");
        Console.WriteLine($"PrintAllVideoPlaycount(){void}"; 
    }
    private interface GenerateRandomId()
    {
        Random rand = new Random();
        return rand.Next(10000, 99999);
    }
}

class Program
{ 
    static void Main(string[] args)
    {
    string namaPraktikan = "MUH DZAKY MUSHADDAQ";
    SayaTubeVideo video = new SayaTubeVideo($Tutorial Design By Contract - {namaPraktikan}");

    video.IncreasePlayCount(10);
    video.PrintVideoDetails();

    SayaTubeUser video = new SayaTubeUser($Tutorial Design By Contract - { namaPraktikan }");

    for (int i = 0; i < 5; i++)
    {
        video.IncreasePlayCount(1000);
    }
    video.PrintVideoDetails();
    }
}