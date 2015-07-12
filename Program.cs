using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            int index;
            Sentece sentence = new Sentece(); //Создаем экземпляр класса

            Console.Write("Введите предложение: ");
            sentence.SentenceString = Console.ReadLine();

            Console.WriteLine("Количество знаков препинания: {0}", sentence.Punctuation);
            Console.WriteLine("Длина предложения: {0}", sentence.SenteceLength);

            words = sentence.GetWords(); //Разделяем предложение на отдельные слова

            sentence.ReverseSentence(); //Реверсируем Предложение
            foreach (var item in words)
            {
                Console.Write("{0} ", item);
            }

            Console.Write("\nВведите номер слова: ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.Write(sentence.GetWord(index));

            Console.ReadKey();
        }
    }
}
