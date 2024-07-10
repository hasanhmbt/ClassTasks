
using System;
using System.Transactions;

namespace GunSimulation;

class Program
{

    public static void Main(string[] args)
    {

        string gunType = Gun._gunType;
        int gunCapacity = Gun._gunCapacity;
        int currentBulletCount = Gun._currnetBulletCount;

        Console.Write("Enter gun type:");
        gunType = Console.ReadLine();
        Console.Write("Enter gun capacity:");
        gunCapacity = Int32.Parse(Console.ReadLine());
        Console.Write("Enter bullet count:");
        currentBulletCount = Int32.Parse(Console.ReadLine());

        Console.WriteLine("\n\nSelect fire mode:\n1.Autofire\n2.Singlefire");
        int mode = Int32.Parse(Console.ReadLine());


        string result = mode switch
        {
            1 => Gun.AutoFire(3),
            2 => Gun.SingleFire(currentBulletCount, gunCapacity),
            3 => "Choose valid option."

        };



    }






}

public class Gun
{

    public static string _gunType;
    public static int _gunCapacity;
    public static int _currnetBulletCount;
    public static int _time;


    public static void AutoFire(int time)
    {

        _time = time;


        if (_currnetBulletCount < _gunCapacity && _currnetBulletCount >= 0)
        {
            while (time > 0)
            {
                _currnetBulletCount--;
                Console.WriteLine(_currnetBulletCount);
                time--;
            }
            Console.WriteLine($"Current bullet count in magazine:{_currnetBulletCount}");
        }
        else
        {
            Console.WriteLine("This gun Can't take this much bullets. Use count for gun capacity or less.");
            Program.Main(null);
        }


    }







    public static void SingleFire(int currnetBulletCount, int GunCapacity)
    {
        _currnetBulletCount = currnetBulletCount;
        _gunCapacity = GunCapacity;


        if (_currnetBulletCount < _gunCapacity)
        {

            _currnetBulletCount--;
            Console.WriteLine($"Current bullet count in magazine:{_currnetBulletCount}");
        }
        else
        {
            Console.WriteLine("This gun Can't take this much bullets. Use count for gun capacity or less.");
            Program.Main(null);
        }





    }




}