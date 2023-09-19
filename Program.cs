 // Nybble adinda 4 bitlik tip olusturur.
   using System;
   // 4 bitlik tip
   class Nybble {
      int val; // depolama altyapisi
public Nybble() { val = 0; }
public Nybble(int i) {
   val = i;
   val = val & 0xF; //alt 4 biti kaybetme
}
// Nybble + Nybble icin ikili + operatorunu asiri yukle. public static Nybble operator +(Nybble opi, Nybble op2) {
   Nybble result = new Nybble();
   result.val = op1.val + op2.val;
   result.val = result.val & 0xF; // alt 4 biti kaybetme
return result;
}
// Nybble + int icin ikili + operatorunu asiri yukle.
public static Nybble operator +(Nybble op1, int op2)
{
   Nybble result = new Nybble();
   result.val = op1.val + op2;
   result.val = result.val & 0xF; // alt 4 biti kaybetme
   return result;
}
// int + Nybble icin ikili + operatorunu asiri yukle. public static Nybble operator + (int op1, Nybble op2) {
   Nybble result = new Nybble();
   result.val = op1 + op2.val;
   result.val = result.val & 0xF; // alt 4 biti kaybetme
   return result;
}
// ++ operatorunu asiri yukle.
public static Nybble operatör ++(Nybble op)
{
op.val++;
   op.val = op.val & 0xF; // alt 4 biti kaybetme
return op; }
// > operatorunu asiri yukle.
public static bool operator >(Nybble op1, Nybble op2) {
   if(op1.val > op2.val) return true;
  else return false;
}
// < operatorunu asiri yukle.
public static bool operator <(Nybble op1, Nybble op2) {
   if(op1.val < op2.val) return true;
   else return false;
}
// Bir Nybble‘i int‘e donustur
public static implicit operator int (Nybble op)
{
   return op.val;
}
// Bir int‘i Nybble‘a donustur
   public static implicit operator Nybble (int op)
   {
      return new Nybble(op);
   }
}
class NybbleDemo {
   public static void Main() {
      Nybble a = new Nybble(1);
      Nybble b = new Nybble(10);
      Nybble c = new Nybble();
      int t;
      Console.WriteLine(―a: ‖ + (int) a);
      Console.WriteLine(―b: ‖ + (int) b);
      // bir if ifadesinde bir Nybble kullan
      if(a < b) Console.WriteLine(―a is less than b\n‖);
      // iki Nybble‘i topla
      c = a + b;
      Console.WriteLine(―c after c = a + b: ‖ + (int) c);
      //Bir Nybble‘a bir int ekle
      a += 5;
      Console.writeLine(―a after a += 5: ‖ + (int) a);
Console.WriteLine();
// Bir Nyyble‘i bir tamsayi deyim icinde kullan
t = a * 2 + 3;
Console.WriteLine(―Result of a * 2 + 3: ‖ + t);
Console.WriteLine();
//int atamasini ve tasmayi goster
a = 19;
Console.WriteLine(―Result of a = 19: ‖ + (int) a);
 Console.WriteLine();
// donguyu kontrol etmek icin Nybble kullan Console.WriteLine(―Control a for loop with a Nybble.‖); for(a = 0; a < 10; a++)
         Console.Write((int) a + ― ‖);
      Console.WriteLine();
   }
}