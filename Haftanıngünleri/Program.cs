using System;

public class HaftanınGünleri
{
    public static void Main(string[] args)
    {
        // Haftanın günlerini gösteren bir dizi tanımlayın.
        string[] haftanınGünleri = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

        // Kullanıcıdan bir sayı girmesini isteyin.
        Console.WriteLine("1-7 arasında bir sayı girin:");
        int gün = int.Parse(Console.ReadLine());

        // Girilen sayıya göre haftanın gününü döndürün.

        if (0 < gün && gün < 8)
        {

            if (gün == 1)
            {
                Console.WriteLine(haftanınGünleri[0]);
            }
            else if (gün == 2)
            {
                Console.WriteLine(haftanınGünleri[1]);
            }
            else if (gün == 3)
            {
                Console.WriteLine(haftanınGünleri[2]);
            }
            else if (gün == 4)
            {
                Console.WriteLine(haftanınGünleri[3]);
            }
            else if (gün == 5)
            {
                Console.WriteLine(haftanınGünleri[4]);
            }
            else if (gün == 6)
            {
                Console.WriteLine(haftanınGünleri[5]);
            }
            else
            {
                Console.WriteLine(haftanınGünleri[6]);
            }

        }
        else Console.WriteLine("hatalı giriş yaptınız ");
    
    
    }
}