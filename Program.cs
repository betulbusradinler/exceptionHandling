/* 
Try-Catch-Finally ve Mantıksal Hatalar

Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

try{ Hataya sebebiyet verme ihtimali olan kod }

catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

*/

try
{
    Console.WriteLine("Bir sayi giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Girmiş olduğunuz sayi: " +sayi);
}
catch(Exception ex){
   Console.WriteLine(" Hata " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}

try{
    //int convert = int.Parse(null);
    //int convert2 = int.Parse("test");
    int convert3 = int.Parse("-21234567891");
}
catch(ArgumentNullException ex){
    Console.WriteLine("Null Exception Hatası.");
    Console.WriteLine(ex);
}
catch(FormatException ex){    
    Console.WriteLine("Veri Tipi Uygun Değil.");
    Console.WriteLine(ex);
}
catch(OverflowException ex){
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("İşlem Başarıyla Tamamlandı");
}
