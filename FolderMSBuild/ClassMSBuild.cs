// Decompiled with JetBrains decompiler
// Type: PracticalWork7.FolderMSBuild.ClassMSBuild
// Assembly: PracticalWork7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 068757E4-9F17-4865-BF45-A71ED507080F
// Assembly location: C:\Users\Totiki\YandexDisk\GeekBrains\C#\PracticalWork7\PracticalWork7\bin\Debug\netcoreapp3.1\PracticalWork7.dll

using System;

namespace PracticalWork7.FolderMSBuild
{
  internal class ClassMSBuild
  {
    public static void WorkMethod() => Console.WriteLine("Результат выражения: (a > b) && (c < b) = " + ClassMSBuild.MethodForMSBuild(ClassMSBuild.DataEntryA(), ClassMSBuild.DataEntryB(), ClassMSBuild.DataEntryC()).ToString());

    private static bool MethodForMSBuild(int a, int b, int c) => a > b && c < b;

    private static int DataEntryA()
    {
      Console.Write("Ввеедите a = ");
      return int.Parse(Console.ReadLine());
    }

    private static int DataEntryB()
    {
      Console.Write("Ввеедите b = ");
      return int.Parse(Console.ReadLine());
    }

    private static int DataEntryC()
    {
      Console.Write("Ввеедите c = ");
      return int.Parse(Console.ReadLine());
    }
  }
}
