
using System;
using System.Transactions;

namespace GunSimulation;

public class Program
{

    public static void Main(string[] args)
    {
        Gun gun = new Gun();


        string gunType;
        int gunCapacity;
        int currentBulletCount;
        int time;

        Console.Write("Enter gun type:");
        gunType = Console.ReadLine();
        Console.Write("Enter gun capacity:");
        gunCapacity = Int32.Parse(Console.ReadLine());
        Console.Write("Enter bullet count:");
        currentBulletCount = Int32.Parse(Console.ReadLine());

        gun._gunCapacity = gunCapacity;
        gun._currnetBulletCount = currentBulletCount;
        gun._gunType = gunType;


        Console.WriteLine("\n\nSelect fire mode:\n1.Autofire\n2.Singlefire");
        int mode = Int32.Parse(Console.ReadLine());


        switch (mode)
        {
            case 1:
                Console.Write("Enter time:");
                time = Int32.Parse(Console.ReadLine());
                gun.AutoFire(time);
                break;
            case 2:
                gun.SingleFire(currentBulletCount, gunCapacity);
                break;
            default:
                Console.WriteLine("Select valid option.");
                Main(null);
                break;
        }


    }






}

public class Gun
{

    public string _gunType;
    public int _gunCapacity;
    public int GunCapacity { get => _gunCapacity; set => _gunCapacity = value; }
    public int _currnetBulletCount;
    public int CurrnetBulletCount { get => _currnetBulletCount; set => _currnetBulletCount = value; }
    public int _time;
    public int Time { get => _time; set => _time = value; }


    public void AutoFire(int time)
    {

        _time = time;


        if (CurrnetBulletCount < GunCapacity && CurrnetBulletCount >= 0)
        {
            while (time > 0)
            {
                CurrnetBulletCount--;
                Console.Write(CurrnetBulletCount + ",");
                time--;
            }
            Console.WriteLine($"Current bullet count in magazine:{CurrnetBulletCount}");
        }
        else
        {
            Console.WriteLine("This gun Can't take this much shots. Use valid numbers.");
        }

    }



    public void SingleFire(int currnetBulletCount, int GunCapacityForSingle)
    {
        CurrnetBulletCount = currnetBulletCount;
        GunCapacity = GunCapacityForSingle;


        if (CurrnetBulletCount < GunCapacity)
        {

            CurrnetBulletCount--;
            Console.WriteLine($"Current bullet count in magazine:{CurrnetBulletCount}");
        }
        else
        {
            Console.WriteLine("This gun Can't take this much bullets. Use count for gun capacity or less.");
            Program.Main(null);
        }



    }




}