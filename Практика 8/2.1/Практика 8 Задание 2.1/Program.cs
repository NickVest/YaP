using System;
using System.Threading;

namespace Практика_8_Задание_2.1
{
  class Program
{
  static void Main(string args)
  {
    Mutex oneMutex = null;
    const string MutexName = "RUNMEONLYONCE";
    try // ПытаемсяоткрытьMutex
    {
      oneMutex = Mutex.OpenExisting(MutexName);
    }
    catch (WaitHandleCannotBeOpenedException)
    {
      // He можемоткрытьMutex, потомучтооннесуществует
    }
    // Создаем его, если он не существует 
    if (oneMutex == null)
    {
      oneMutex = new Mutex(true, MutexName);
    }
    else
    {
      // Закрываем Mutexи выходим из приложения,
      // так как разрешается запуск только одного его экземпляра
      oneMutex.Close();
      return;
    }
    Console.WriteLine("Our Application");
    Console.Read();
  }
}
}
