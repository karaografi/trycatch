internal class Program
{
    private static void Main(string[] args)
    {

        // try{
        // Console.WriteLine("Bir sayı giriniz");
        // int sayi = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Girmiş Olduğunuz Sayı: " + sayi);
        // }
        // catch(Exception ex)
        // {
        //     Console.WriteLine("Hatalı:"+ ex.Message.ToString());
        // }
        // finally
        // {
        //     Console.WriteLine("İşlem Tamamlandı");
        // }

        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-20000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş Değer Girdiniz");
            Console.WriteLine(ex);
        }catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi Uygun Değil");
            Console.WriteLine(ex);
        }catch(OverflowException ex) 
        {
            Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
            Console.WriteLine(ex);
        }




    }
}