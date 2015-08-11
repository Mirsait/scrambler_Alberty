using System;
using System.Collections.Generic;
using System.Text;

namespace Shifr
{
    class AlbertyRu
    {
        string ABC = "абвгдеёжзийклмнопрстуфхцшщыьъэюя АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦШЩЫЬЪЭЮЯ_0123456789.,:;!?%$#()[]<>/*-+=@";//алфавит
        string opentext = "0";//открытый текст
        string wordkey = "0";//ключевое слово
        string shifrtext = "0";//шифрованный текст
        string text = "0";
        bool flag; //указатель на coder(true) или decoder(false)

        public string OpenText
        {
            get { return opentext; }
            set { opentext = value; }
        }
        string WordKey
        {
            get { return wordkey; }
            set { wordkey = value; }
        }
        public string ShifrText
        {
            get { return shifrtext; }
            set { shifrtext = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public AlbertyRu(string otext, string kword, bool flag)
        {
            Text = otext;
            WordKey = kword;
            this.flag = flag;
        }

        char[] linetable(int h)//для coder и decoder
        {
            int n = ABC.Length;
            char[] abcline = new char[n];
            int p = 0;
            //переводим алфавит в массив
            foreach (char s in ABC)
            {
                abcline[p] = s;
                p++;
            }
            //смещаем символы на h
            for (int i = 0; i < n; i++)
            {
                if (i + h > n - 1)
                    abcline[i + h - n] = ABC[i];
                else
                    abcline[i + h] = ABC[i];
            }
            return abcline;
        }

        string SetKey(string keyword)//для coder и decoder
        {//формируем ключ из ключевого слова

            string key = "";
            int n = Text.Length;//количество символов в открытом тексте
            int m = keyword.Length;//количество символов в ключевом слове
            int i = 0;
            int j = 0;
            while (i < n)
            {
                key += keyword[j];
                j = (j == m - 1) ? 0 : j += 1;
                i++;
            }
            return key;
        }

        public string Coder()
        {
            OpenText = Text;
            string key = SetKey(WordKey);           //сформировали ключ
            char[] line = new char[ABC.Length];   //строка таблицы
            string shtext = "";                     //шифрованный текст

            int g = 0;      //индекс символа в OpenText и ключе 
            int row = 0;    //определяет величину сдвига
            int col = 0;    //(номер столбца таблицы)            
            while (g < OpenText.Length)
            {
                int i = 0;
                for (i = 0; i < ABC.Length; i++)
                {
                    if (OpenText[g] == ABC[i]) col = i;
                    if (key[g] == ABC[i]) row = i;
                }
                line = linetable(row);
                shtext += line[col];
                g++;
            }
            ShifrText = shtext;
            return shtext;
        }

        public string Decoder()
        {
            ShifrText = Text;
            string key = SetKey(WordKey);           //сформировали ключ
            char[] line = new char[ABC.Length];   //строка таблицы
            string otext = "";                     //шифрованный текст

            int k = 0;
            int col = 0;
            int row = 0;
            while (k < key.Length)
            {
                int i = 0;
                for (i = 0; i < ABC.Length; i++)
                {
                    if (key[k] == ABC[i]) row = i;
                    line = linetable(row);
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == ShifrText[k]) col = j;
                    }
                }
                otext += ABC[col];
                k++;
            }
            OpenText = otext;
            return otext;
        }

    }
}
