using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Sentece
    {
        private int sentenceLength; //Длина предложения
        private int punctuation = 0; //Кол-во знаков препинания
        private string sentenceString, dots = ".,;:!?-"; //Перечисление всех знаков препинания
        private string[] words;

        private void GetPunctuation()
        {
            for (int i = 0; i < sentenceString.Length; i++) //Просматриваем каждый символ предложения
            {
                if (dots.Contains(sentenceString[i])) //Если он является знаком препинания
                {
                    punctuation++; //то увеличиваем счетчик
                }
            }
        }

        public string[] GetWords()
        {
            sentenceString = sentenceString.TrimEnd(new char[] { '.', '!', '?' }); //Убираем в конце знаки препинания
            words = sentenceString.Split(new string[] { " ", ", ", ". ", " - " }, System.StringSplitOptions.RemoveEmptyEntries); //Разделяем предложения на слова
            return words;
        }

        public string[] ReverseSentence()
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper(); //Переводим каждое слово в верхний регистр
            }
            Array.Reverse(words); //Реверсируем массив
            return words;
        }

        public string GetWord(int index)
        {
            if (index - 1 > words.Length || index < 1) //Индекс должен не превышать кол-во слов и быть не меньше 1
            {
                return "Ошибка";
            }
            else
            {
                Array.Reverse(words); //Возвращаем массив слов в исходное состояние
                return words[index - 1].ToLower(); //Возвращаем в программу нужное слово, переведенное в нижний регистр
            }
        }

        public int SenteceLength //Определение длины предложения
        {
            get { sentenceLength = sentenceString.Length; return sentenceLength; }
        }

        public int Punctuation //Нахождение кол-ва знаков препинания
        {
            get { GetPunctuation(); return punctuation; }
        }

        public string SentenceString
        {
            set { sentenceString = value; }
        }
    }
}

