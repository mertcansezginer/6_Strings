

string metin = "Bugün disarida firtina var!";

int uzunluk = metin.Length;
Console.WriteLine("Metnin uzunlugu " + uzunluk);

char ucuncuKarakter = metin[2];  //belirli karaktere eristik
Console.WriteLine("Metnin ucuncu karakteri: " + ucuncuKarakter);

string buyukHarf = metin.ToUpper();
Console.WriteLine("Metnin buyuk harfli hali: " + buyukHarf);

string kucukHarf = metin.ToLower();
Console.WriteLine("Metnin kucuk harfli hali: " + kucukHarf);

string kesilmisMetin = metin.Substring(6,8);  //metin belirli yerden kesildi, 6. karakterden itibaren 8 karakter alindi
Console.WriteLine("Metnin kesilmis hali: " + kesilmisMetin);

bool iceriyorMu = metin.Contains("firtina");
Console.WriteLine("Metin 'firtina' kelimesini iceriyor mu? " + (iceriyorMu ? "Evet" : "Hayır")); //ternary operator kullandik

